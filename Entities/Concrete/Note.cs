using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [Table(Name = "Notes")]
    public class Note : IEntity
    {
        [Column(Name = "ID", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER"), Key, Display(Name = "$")]
        public int ID { get; set; }
        [Column(Name = "Name", DbType = "TEXT"), Display(Name = "İsim")]
        public string Name { get; set; }
        [Column(Name = "Date", DbType = "TIMESTAMP"), Display(Name = "Tarih")]
        public DateTime Date { get; set; }
        [Column(Name = "Content", DbType = "TEXT"), Display(Name = "İçerik")]
        public string Content { get; set; }
    }
}
