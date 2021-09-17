using Entities.Concrete;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.SqlServer;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace DataAccess.Concrete.EntityFramework
{
    public class MainContext : DbContext
    {
        //private static string connectionString = @"Server=phonchick.mssql.somee.com;Database=phonchick;User Id=phonchick_SQLLogin_1;Password=klehpsn2ed;MultipleActiveResultSets=True;App=EntityFramework";

        //public MainContext() : base(connectionString) { }

        public MainContext() :
            base(new SQLiteConnection()
            {
                ConnectionString = new SQLiteConnectionStringBuilder() { DataSource = "Main.db", ForeignKeys = true }.ConnectionString
            }, true)
        {
            this.Database.CreateIfNotExists();
        }
        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }*/

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Instalment> Instalments { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
