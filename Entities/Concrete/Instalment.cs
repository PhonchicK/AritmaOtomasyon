using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;

namespace Entities.Concrete
{
    [Table(Name = "Instalments")]
    public class Instalment : IEntity
    {
        [Column(Name = "ID", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int ID { get; set; }
        [Column(Name = "SaleID", DbType = "INTEGER")]
        public int SaleID { get; set; }
        [Column(Name = "InstalmentNo", DbType = "INTEGER")]
        public int InstalmentNo { get; set; }//Taksit in ödeme sırası
        [Column(Name = "PayablePrice", DbType = "INTEGER")]
        public int PayablePrice { get; set; }//Ödenecek Tutar
        [Column(Name = "PaidPrice", DbType = "INTEGER")]
        public int PaidPrice { get; set; }//Ödenen Tutar
        [Column(Name = "PaymentDate", DbType = "TIMESTAMP")]
        public DateTime PaymentDate { get; set; }//Ödenecek Gün
        [Column(Name = "PaidDate", DbType = "TIMESTAMP")]
        public DateTime? PaidDate { get; set; }//Ödenen Gün
    }
}
