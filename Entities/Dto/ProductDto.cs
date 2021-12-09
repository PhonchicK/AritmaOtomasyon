using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class ProductDto : IDto
    {
        [Display(Name = "$")]
        public int ID { get; set; }
        [Display(Name = "Adı")]
        public string Name { get; set; }
        [Display(Name = "Özellikleri")]
        public string Features { get; set; }
        [Display(Name = "Ücret")]
        public int Price { get; set; }
        [Display(Name = "Stok")]
        public int Count { get; set; }
    }
}
