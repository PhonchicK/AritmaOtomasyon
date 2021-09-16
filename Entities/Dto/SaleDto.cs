using System;
using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Entities.Dto
{
    public class SaleDto : IDto
    {
        [Display(Name = "$")]
        public int ID { get; set; }
        [Display(Name = "Müşteri Adı")]
        public string CustomerName { get; set; }
        [Display(Name = "Müşteri Telefon")]
        public string CustomerPhoneNumber { get; set; }
        [Display(Name = "Ürün")]
        public string Product { get; set; }
        [Display(Name = "Satış Tarihi")]
        public DateTime SaleDate { get; set; }
        [Display(Name = "Ödeme Türü")]
        public string PaymentType { get; set; }
        [Display(Name = "Tutar")]
        public int Price { get; set; }
        [Display(Name = "Kalan Tutar")]
        public int RemainderPrice { get; set; }
    }
}
