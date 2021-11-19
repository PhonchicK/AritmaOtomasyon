using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class InstalmentDetailsDto : IDto
    {
        [Display(AutoGenerateField = false)]
        public int SaleID { get; set; }
        [Display(Name = "Ürün")]
        public string ProductName { get; set; }
        [Display(Name = "Satış Tarihi")]
        public DateTime SaleDate { get; set; }
        [Display(AutoGenerateField = false)]
        public int CustomerID { get; set; }
        [Display(Name = "Müşteri Adı")]
        public string CustomerName { get; set; }
        [Display(Name = "Müşteri Telefon")]
        public string CustomerPhoneNumber { get; set; }
        [Display(Name = "Ödenecek / Ödenmemiş Tarih")]
        public DateTime? DateFirstNotPaid { get; set; }
        [Display(Name = "Kalan Taksit Sayısı")]
        public int TotalInstalmentCount { get; set; }
        [Display(Name = "Kalan Tutar")]
        public int TotalInstalmentPrice { get; set; }
    }
}
