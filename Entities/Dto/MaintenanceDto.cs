using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Core.Entities;

namespace Entities.Dto
{
    public class MaintenanceDto : IDto
    {
        [Display(Name = "$")]
        public int ID { get; set; }

        public MaintenanceDto(int id, int customerID, string customerName, string customerPhoneNumber, string customerAddress,int saleID,int productID, string product, DateTime startDate, int maintenanceInterval, DateTime? lastMaintenance,DateTime saleDate)
        {
            ID = id;
            CustomerID = customerID;
            CustomerName = customerName;
            CustomerPhoneNumber = customerPhoneNumber;
            CustomerAddress = customerAddress;
            SaleID = saleID;
            ProductID = productID;
            Product = product;
            StartDate = startDate;
            MaintenanceInterval = maintenanceInterval;
            LastMaintenance = lastMaintenance;
            SaleDate = saleDate;

            if (LastMaintenance != null)
                NextMaintenance = LastMaintenance.Value.Date.AddMonths(maintenanceInterval);
            else
                NextMaintenance = SaleDate.Date.AddMonths(maintenanceInterval);

            DistanceOfNextMaintenance = ((int)(NextMaintenance - DateTime.Now).Value.TotalDays);
        }
        public MaintenanceDto()
        {

        }
        [Display(AutoGenerateField = false)]
        public int CustomerID { get; set; }
        [Display(Name = "Müşteri Adı")]
        public string CustomerName { get; set; }
        [Display(Name = "Müşteri Telefon")]
        public string CustomerPhoneNumber { get; set; }
        [Display(Name = "Müşteri Adres")]
        public string CustomerAddress { get; set; }
        [Display(AutoGenerateField = false)]
        public int SaleID { get; set; }
        [Display(AutoGenerateField = false)]
        public int ProductID { get; set; }
        [Display(Name = "Ürün")]
        public string Product { get; set; }
        [Display(AutoGenerateField = false)]
        public DateTime StartDate { get; set; }
        [Display(Name = "Sonraki Bakım")]
        public int? DistanceOfNextMaintenance { get; set; }
        [Display(Name = "Sonraki Bakım Tarihi")]
        public DateTime? NextMaintenance { get; set; }
        [Display(Name = "Bakım Aralığı")]
        public int MaintenanceInterval { get; set; }
        [Display(Name = "Son Bakım")]
        public DateTime? LastMaintenance { get; set; }
        [Display(Name = "Alış Tarihi")]
        public DateTime SaleDate { get; set; }
    }
}
