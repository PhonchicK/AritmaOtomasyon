using Bussiness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class MaintenanceBaseManager : IMaintenanceBaseService
    {
        IMaintenanceBaseDal maintenanceBaseDal;
        IMaintenanceDal maintenanceDal;
        public MaintenanceBaseManager(IMaintenanceBaseDal _maintenanceBaseDal, IMaintenanceDal _maintenanceDal)
        {
            maintenanceBaseDal = _maintenanceBaseDal;
            maintenanceDal = _maintenanceDal;
        }
        public int Add(MaintenanceBase maintenanceBase)
        {
            return maintenanceBaseDal.Add(maintenanceBase).ID;
        }

        public void Delete(MaintenanceBase maintenanceBase)
        {
            foreach (var item in maintenanceDal.GetAll(m => m.MaintenanceBaseID == maintenanceBase.ID))
            {
                if (item != null)
                    maintenanceDal.Delete(item);
            }
            maintenanceBaseDal.Delete(maintenanceBase);
        }

        public List<MaintenanceBase> GetAll()
        {
            return maintenanceBaseDal.GetAll();
        }

        public List<MaintenanceDto> GetAllDetails()
        {
            return maintenanceBaseDal.GetAllDetails();
            //return items.Select(m => new MaintenanceDto());
        }

        public MaintenanceBase GetByID(int id)
        {
            return maintenanceBaseDal.Get(m => m.ID == id);
        }

        public List<MaintenanceDto> GetClosesDetails()
        {
            return maintenanceBaseDal.GetAllDetails(m => m.DistanceOfNextMaintenance < 32 && m.DistanceOfNextMaintenance > -32);
        }

        public List<MaintenanceDto> GetCustomerDetails(int customerID)
        {
            return maintenanceBaseDal.GetAllDetails(m => m.CustomerID == customerID);
        }

        public MaintenanceDto GetDetailsByID(int id)
        {
            return maintenanceBaseDal.GetDetails(m => m.ID == id);
        }

        public List<MaintenanceDto> GetSaleDetails(int saleID)
        {
            return maintenanceBaseDal.GetAllDetails(mB => mB.SaleID == saleID);
        }

        public void Update(MaintenanceBase maintenanceBase)
        {
            maintenanceBaseDal.Update(maintenanceBase);
        }
    }
}
