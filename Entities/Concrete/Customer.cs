using Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;

namespace Entities.Concrete
{
    [Table(Name = "Customers")]
    public class Customer : IEntity
    {
        [Column(Name = "ID", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int ID { get; set; }
        [Column(Name = "Name", DbType = "VARCHAR")]
        public string Name { get; set; }
        [Column(Name = "PhoneNumber", DbType = "VARCHAR")]
        public string PhoneNumber { get; set; }
        [Column(Name = "Address", DbType = "VARCHAR")]
        public string Address { get; set; }
        [Column(Name = "ReferanceCustomerID", DbType = "INTEGER",CanBeNull = true)]
        public int? ReferanceCustomerID { get; set; }//Referans olan Müşterinin IDs si
    }
}
