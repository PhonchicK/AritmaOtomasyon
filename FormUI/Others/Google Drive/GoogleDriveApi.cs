using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHYAOtomasyon.Others.Google_Drive
{
    public class GoogleDriveApi
    {
        private DriveService service;
        private readonly string[] Scopes = new string[] { DriveService.Scope.Drive, DriveService.Scope.DriveFile, DriveService.Scope.DriveReadonly };

        public GoogleDriveApi()
        {
            UserCredential credential;

            if (!System.IO.File.Exists(Application.StartupPath + "/client_secret_432917447566-locpbja1ds0jo6nef8fdvbq4h65tskab.apps.googleusercontent.com.json"))
            {
                throw new Exception("client_id.json dosyası bulunamadı");
            }

            using (var stream = new FileStream(Application.StartupPath + "/client_secret_432917447566-locpbja1ds0jo6nef8fdvbq4h65tskab.apps.googleusercontent.com.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    Environment.UserName,
                    CancellationToken.None,
                    new FileDataStore(Application.StartupPath + "/google-tokens", true)
                ).Result;
            }

            service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "GoogleDriveExample",

            });

            service.HttpClient.Timeout = TimeSpan.FromMinutes(100);
        }

        public List<Google.Apis.Drive.v3.Data.File> GetFiles(string query = null)
        {
            List<Google.Apis.Drive.v3.Data.File> fileList = new List<Google.Apis.Drive.v3.Data.File>();
            FilesResource.ListRequest request = service.Files.List();
            request.Q = query ?? "mimeType != \"application/vnd.google-apps.folder\"";

            // hangi alanların gelmesini istiyorsak burada belirtiyoruz
            request.Fields = "nextPageToken, files(id, name, createdTime, modifiedTime, mimeType, description, size, trashed)";

            //dosyalar parça parça geliyor, her parçada nextPageToken dönüyor, nextPageToken null gelene kadar bu döngü devam eder.
            // null dönerse tüm dosyalar çekilmiştir
            do
            {
                try
                {
                    FileList files = request.Execute();

                    // her partta gelen dosyaları fileList listesine ekliyoruz
                    fileList.AddRange(files.Files);
                    request.PageToken = files.NextPageToken;
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occurred: " + e.Message);
                    request.PageToken = null;
                }
            } while (!string.IsNullOrEmpty(request.PageToken));

            return fileList;
        }
        private string GetMimeType(string file)
        {
            string mimeType = "application/unknown";
            string ext = System.IO.Path.GetExtension(file).ToLower();

            Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(ext);

            if (regKey != null && regKey.GetValue("Content Type") != null)
            {
                mimeType = regKey.GetValue("Content Type").ToString();
            }

            return mimeType;
        }
        public string CreateFolderAndGetID(string folderName, string parentId = null)
        {
            string query = $"mimeType = \"application/vnd.google-apps.folder\" and name = \"{folderName}\"";
            List<Google.Apis.Drive.v3.Data.File> result = GetFiles(query);
            Google.Apis.Drive.v3.Data.File file = result.FirstOrDefault();

            if (file != null)
            {
                return file.Id;
            }
            else
            {
                file = new Google.Apis.Drive.v3.Data.File
                {
                    Name = folderName,
                    MimeType = "application/vnd.google-apps.folder"
                };

                if (parentId != null)
                {
                    file.Parents = new List<string> { parentId };
                }

                var request = service.Files.Create(file);
                request.Fields = "id";
                var response = request.Execute();
                return response.Id;
            }
        }
        public string GetRootID()
        {
            Google.Apis.Drive.v3.Data.File file = service.Files.Get("root").Execute();
            return file.Id;
        }
        public async Task<Google.Apis.Drive.v3.Data.File> UploadFile(string file, string parentId = null)
        {
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(file);

            if (System.IO.File.Exists(file))
            {
                Google.Apis.Drive.v3.Data.File body = new Google.Apis.Drive.v3.Data.File
                {
                    Name = System.IO.Path.GetFileName(file),
                    Description = "",
                    AppProperties = new Dictionary<string, string> { { "customKey", "customValue" } },
                    MimeType = GetMimeType(file)
                };

                if (!string.IsNullOrEmpty(parentId))
                {
                    body.Parents = new List<string> { parentId };
                }
                else
                {
                    string folderId = CreateFolderAndGetID("IHYA");
                    body.Parents = new List<string> { folderId };
                }

                byte[] byteArray = System.IO.File.ReadAllBytes(file);

                using (var stream = new MemoryStream(byteArray))
                {
                    try
                    {
                        FilesResource.CreateMediaUpload request = service.Files.Create(body, stream, GetMimeType(file));
                        request.SupportsTeamDrives = true;
                        request.Fields = "id, name, createdTime, modifiedTime, mimeType, description, size";

                        await request.UploadAsync();

                        return request.ResponseBody;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                        
                    }
                }
            }
            else
            {
                throw new Exception("Dosya bulunamadı");
            }
        }
        public async Task<string> DeleteFile(string fileId)
        {
            return await service.Files.Delete(fileId).ExecuteAsync();
        }
    }
}
