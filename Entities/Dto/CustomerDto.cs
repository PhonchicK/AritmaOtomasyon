using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class CustomerDto :IDto
    {
        [Display(Name = "$")]
        public int ID { get; set; }
        [Display(Name = "Adı")]
        public string Name { get; set; }
        [Display(Name = "Telefon Numarası")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Adres")]
        public string Address { get; set; }
        [Display(Name = "Referans Adı")]
        public string ReferanceCustomerName { get; set; }
        [Display(AutoGenerateField = false)]
        public int? ReferancePrice { get; set; }
    }
}
