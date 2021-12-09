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
    [Table(Name = "StockIns")]
    public class StockIn : IEntity
    {
        [Column(Name = "ID", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER"), Display(Name = "$")]
        public int ID { get; set; }
        [Column(Name = "ProductID", DbType = "INTEGER"), Display(AutoGenerateField = false)]
        public int ProductID { get; set; }
        [Column(Name = "Count", DbType = "INTEGER"), Display(Name = "Miktar")]
        public int Count { get; set; }
        [Column(Name = "WhoPurchase", DbType = "VARCHAR", CanBeNull = true), Display(Name = "Nereden")]
        public string WhoPurchase { get; set; }
    }
}
