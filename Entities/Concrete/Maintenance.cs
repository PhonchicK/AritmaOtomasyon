using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;

namespace Entities.Concrete
{
    [Table(Name = "Maintenances")]
    public class Maintenance : IEntity
    {
        [Column(Name = "ID", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int ID { get; set; }
        [Column(Name = "MaintenanceBaseID", DbType = "INTEGER")]
        public int MaintenanceBaseID { get; set; }
        [Column(Name = "TakedPrice", DbType = "INTEGER")]
        public int TakedPrice { get; set; }//Alınan Ücret
        [Column(Name = "PersonDoing", DbType = "VARCHAR")]
        public string PersonDoing { get; set; }//Yapan Kişi
        [Column(Name = "Process", DbType = "VARCHAR")]
        public string Process { get; set; }//İşlem
        [Column(Name = "Note", DbType = "VARCHAR")]
        public string Note { get; set; }
        [Column(Name = "Date", DbType = "TIMESTAMP")]
        public DateTime Date { get; set; }
    }
}
