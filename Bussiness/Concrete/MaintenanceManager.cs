using Bussiness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class MaintenanceManager : IMaintenanceService
    {
        IMaintenanceDal maintenanceDal;
        IMaintenanceBaseDal maintenanceBaseDal;
        ISaleDal saleDal;

        public MaintenanceManager(IMaintenanceDal _maintenanceDal, IMaintenanceBaseDal _maintenanceBaseDal, ISaleDal _saleDal)
        {
            this.maintenanceDal = _maintenanceDal;
            this.maintenanceBaseDal = _maintenanceBaseDal;
            this.saleDal = _saleDal;
        }

        public int Add(Maintenance maintenance)
        {
            return maintenanceDal.Add(maintenance).ID;
        }

        public void Delete(Maintenance maintenance)
        {
            maintenanceDal.Delete(maintenance);
        }

        public List<Maintenance> GetAll()
        {
            return maintenanceDal.GetAll();
        }

        public Maintenance GetByID(int id)
        {
            return maintenanceDal.Get(m => m.ID == id);
        }

        public List<Maintenance> GetByBaseID(int maintenanceBaseID)
        {
            return maintenanceDal.GetAll(m => m.MaintenanceBaseID == maintenanceBaseID);
        }

        public void Update(Maintenance maintenance)
        {
            maintenanceDal.Update(maintenance);
        }

        public List<Maintenance> GetByCustomerID(int customerID)
        {
            List<Maintenance> results = new List<Maintenance>();
            var sales = saleDal.GetAll(s => s.CustomerID == customerID);
            List<int> baseIDs = new List<int>();
            foreach (var item in sales)
            {
                var obj = maintenanceBaseDal.Get(mB => mB.SaleID == item.ID);
                if (obj == null)
                    continue;
                baseIDs.Add(obj.ID);
            }
            foreach (var item in baseIDs)
            {
                results.AddRange(maintenanceDal.GetAll(m => m.MaintenanceBaseID == item));
            }
            return results;
        }

        public List<Maintenance> GetBySaleID(int saleID)
        {
            List<Maintenance> results = new List<Maintenance>();

            foreach (var item in maintenanceBaseDal.GetAll(mB => mB.SaleID == saleID))
            {
                results.AddRange(maintenanceDal.GetAll(m => m.MaintenanceBaseID == item.ID));
            }
            return results;
        }
    }
}
