using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;

namespace Entities.Concrete
{
    [Table(Name = "Maintenances")]
    public class Maintenance : IEntity
    {
        [Column(Name = "ID", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER"), Display(Name = "$")]
        [Key]
        public int ID { get; set; }
        [Column(Name = "MaintenanceBaseID", DbType = "INTEGER"),Display(AutoGenerateField = false)]
        public int MaintenanceBaseID { get; set; }
        [Column(Name = "TakedPrice", DbType = "INTEGER"), Display(Name = "Alınan Ücret")]
        public int TakedPrice { get; set; }//Alınan Ücret
        [Column(Name = "PersonDoing", DbType = "VARCHAR"), Display(Name = "Yapan Kişi")]
        public string PersonDoing { get; set; }//Yapan Kişi
        [Column(Name = "Process", DbType = "VARCHAR"), Display(Name = "Yapılan İşlem")]
        public string Process { get; set; }//İşlem
        [Column(Name = "Note", DbType = "VARCHAR"), Display(Name = "Not")]
        public string Note { get; set; }
        [Column(Name = "Date", DbType = "TIMESTAMP"), Display(Name = "Tarih")]
        public DateTime Date { get; set; }
    }
}
