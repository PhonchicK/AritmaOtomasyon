using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;

namespace Entities.Concrete
{
    [Table( Name = "Maintenances")]
    public class Maintenance : IEntity
    {
        [Column(Name = "ID", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int ID { get; set; }
        [Column(Name = "SaleID", DbType = "INTEGER")]
        public int SaleID { get; set; }
        [Column(Name = "StartDate", DbType = "TIMESTAMP")]
        public DateTime StartDate { get; set; }
        [Column(Name = "MaintenanceInterval", DbType = "INTEGER")]
        public int MaintenanceInterval { get; set; }
        [Column(Name = "LastMaintenance", DbType = "TIMESTAMP")]
        public DateTime LastMaintenance { get; set; }
    }
}
