using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Dto
{
    public class InstalmentDto : IDto
    {
        [Display(Name = "$")]
        public int ID { get; set; }
        [Display(AutoGenerateField = false)]
        public int CustomerID { get; set; }
        [Display(Name = "Müşteri Adı")]
        public string CustomerName { get; set; }
        [Display(Name = "Müşteri Numarası")]
        public string CustomerPhoneNumber { get; set; }
        [Display(AutoGenerateField = false)]
        public int SaleID { get; set; }
        [Display(Name = "Ürün")]
        public string Product { get; set; }
        [Display(Name = "Satış Tarihi")]
        public DateTime SaleDate { get; set; }
        [Display(Name = "Taksit Sıra")]
        public int InstalmentNo { get; set; }
        [Display(Name = "Ödenecek Tutar")]
        public int PayablePrice { get; set; }
        [Display(Name = "Ödenen Tutar")]
        public int PaidPrice { get; set; }
        [Display(Name = "Ödeme Tarihi")]
        public DateTime PaymentDate { get; set; }
        [Display(Name = "Ödenen Tarih")]
        public DateTime PaidDate { get; set; }
    }
}
