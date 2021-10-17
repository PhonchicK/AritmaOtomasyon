using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class DebtDto : IDto
    {
        [Display(Name = "$")]
        public int ID { get; set; }
        [Display(AutoGenerateField = false)]
        public int CustomerID { get; set; }
        [Display(Name = "Müşteri Adı")]
        public string CustomerName { get; set; }
        [Display(Name = "Müşteri Telefon")]
        public string CustomerPhoneNumber { get; set; }
        [Display(Name = "Bakiye")]
        public int Balance { get; set; }
        [Display(Name = "Alacak")]
        public int Receive { get; set; }
        [Display(Name = "Verecek")]
        public int Give { get; set; }
    }
}
