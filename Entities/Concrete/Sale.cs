using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;

namespace Entities.Concrete
{
    [Table(Name = "Sales")]
    public class Sale : IEntity
    {
        [Column(Name = "ID", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int ID { get; set; }
        [Column(Name = "CustomerID", DbType = "INTEGER")]
        public int CustomerID { get; set; }
        [Column(Name = "ProductID", DbType = "VARCHAR")]
        public int ProductID { get; set; }
        [Column(Name = "SaleDate", DbType = "TIMESTAMP")]
        public DateTime SaleDate { get; set; }
        [Column(Name = "PaymentType", DbType = "VARCHAR")]
        public string PaymentType { get; set; }
        [Column(Name = "Price", DbType = "INTEGER")]
        public int Price { get; set; }
        /*[Column(Name = "RemainderPrice", DbType = "INTEGER")]
        public int RemainderPrice { get; set; }//Kalan Tutar*/
        [Column(Name = "Assembler", DbType = "VARCHAR")]
        public string Assembler { get; set; }//Montaj yapan kişi
        [Column(Name = "Comment", DbType = "VARCHAR")]
        public string Comment { get; set; }
    }
}
