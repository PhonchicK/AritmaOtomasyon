using Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;

namespace Entities.Concrete
{
    [Table(Name = "Customers")]
    public class Customer : IEntity
    {
        [Column(Name = "ID", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER"), Display(Name = "$")]
        [Key]
        public int ID { get; set; }
        [Column(Name = "Name", DbType = "VARCHAR"), Display(Name = "Adı")]
        public string Name { get; set; }
        [Column(Name = "PhoneNumber", DbType = "VARCHAR"), Display(Name = "Telefon Numarası")]
        public string PhoneNumber { get; set; }
        [Column(Name = "Address", DbType = "VARCHAR"), Display(Name = "Adres")]
        public string Address { get; set; }
        [Column(Name = "Comment", DbType = "VARCHAR"), Display(Name = "Açıklama")]
        public string Comment { get; set; }
    }
}
