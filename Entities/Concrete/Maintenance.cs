using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Maintenance : IEntity
    {
        public int ID { get; set; }
        public int MaintenanceBaseID { get; set; }
        public int TakedPrice { get; set; }//Alınan Ücret
        public string PersonDoing { get; set; }//Yapan Kişi
        public string Process { get; set; }//İşlem
        public string Note { get; set; }
        public DateTime Date { get; set; }
    }
}
