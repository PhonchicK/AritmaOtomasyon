using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;

namespace Entities.Concrete
{
    [Table(Name = "Products")]
    public class Product : IEntity
    {
        [Column(Name = "ID", DbType = "INTEGER"), Display(Name = "$")]
        public int ID { get; set; }
        [Column(Name = "Name", DbType = "VARCHAR"), Display(Name = "Model")]
        public string Name { get; set; }
        [Column(Name = "Features", DbType = "VARCHAR"), Display(Name = "Özellikler")]
        public string Features { get; set; }
        [Column(Name = "DefaultPrice", DbType = "INTEGER"), Display(Name = "Fiyat")]
        public int DefaultPrice { get; set; }
    }
}
