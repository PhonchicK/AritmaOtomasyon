using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IMaintenanceBaseService
    {
        List<MaintenanceBase> GetAll();
        List<MaintenanceDto> GetAllDetails();
        List<MaintenanceDto> GetClosesDetails();
        MaintenanceBase GetByID(int id);
        MaintenanceDto GetDetailsByID(int id);
        int Add(MaintenanceBase maintenance);
        void Update(MaintenanceBase maintenance);
        void Delete(MaintenanceBase maintenance);
    }
}
