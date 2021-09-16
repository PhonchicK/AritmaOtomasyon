using System;
using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Entities.Dto
{
    public class MaintenanceDto : IDto
    {
        [Display(Name = "$")]
        public int ID { get; set; }
        [Display(Name = "Müşteri Adı")]
        public string CustomerName { get; set; }
        [Display(Name = "Müşteri Telefon")]
        public string CustomerPhoneNumber { get; set; }
        [Display(Name = "Müşteri Adres")]
        public string CustomerAddress { get; set; }
        [Display(Name = "Ürün")]
        public string Product { get; set; }
        [Display(Name = "Bakım Aralığı")]
        public int MaintenanceInterval { get; set; }
        [Display(Name = "Bakım Başlangıcı")]
        public DateTime StartDate { get; set; }
        [Display(Name = "Son Bakım")]
        public DateTime LastMaintenance { get; set; }
    }
}
