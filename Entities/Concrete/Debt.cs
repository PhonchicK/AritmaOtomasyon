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
    [Table(Name = "Debts")]
    public class Debt : IEntity
    {
        [Column(Name = "ID", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER"), Key, Display(Name = "$")]
        public int ID { get; set; }
        [Column(Name = "CustomerID", DbType = "INTEGER"), Display(AutoGenerateField = false)]
        public int CustomerID { get; set; }

        [Column(Name = "Comment", DbType = "VARCHAR", CanBeNull = true), Display(Name = "Açıklama")]
        public string Comment { get; set; }
        [Column(Name = "Date", DbType = "TIMESTAMP"), Display(Name = "Tarih")]
        public DateTime Date { get; set; }

        [Column(Name = "Receive", DbType = "INTEGER"), Display(Name = "Alacak")]
        public int Receive { get; set; }//Alacak
        [Column(Name = "Give", DbType = "INTEGER"), Display(Name = "Verecek")]
        public int Give { get; set; }//Verecek
    }
}
