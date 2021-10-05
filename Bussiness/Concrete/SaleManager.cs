using Bussiness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System.Collections.Generic;

namespace Bussiness.Concrete
{
    public class SaleManager : ISaleService
    {
        ISaleDal saleDal;
        IInstalmentDal instalmentDal;
        IMaintenanceBaseDal maintenanceBaseDal;
        IMaintenanceDal maintenanceDal;
        public SaleManager(ISaleDal _saleDal, IInstalmentDal _instalmentDal, IMaintenanceBaseDal _maintenanceBaseDal, IMaintenanceDal _maintenanceDal)
        {
            saleDal = _saleDal;
            instalmentDal = _instalmentDal;
            maintenanceBaseDal = _maintenanceBaseDal;
            maintenanceDal = _maintenanceDal;
        }
        public int Add(Sale sale)
        {
            return saleDal.Add(sale).ID;
        }

        public void Delete(Sale sale)
        {
            var instalments = instalmentDal.GetAll(i => i.SaleID == sale.ID);
            if(instalments.Count > 0)
            {
                foreach(var item in instalments)
                {
                    instalmentDal.Delete(item);
                }
            }

            var maintenanceBase = maintenanceBaseDal.Get(m => m.SaleID == sale.ID);
            if (maintenanceBase != null)
                maintenanceBaseDal.Delete(maintenanceBase);

            foreach (var item in maintenanceDal.GetAll(m => m.MaintenanceBaseID == maintenanceBase.ID))
            {
                if (item != null)
                    maintenanceDal.Delete(item);
            }

            saleDal.Delete(sale);
        }

        public List<Sale> GetAll()
        {
            return saleDal.GetAll();
        }

        public List<SaleDto> GetAllDetails()
        {
            return saleDal.GetAllDetails();
        }

        public Sale GetByID(int id)
        {
            return saleDal.Get(s => s.ID == id);
        }

        public List<SaleDto> GetCustomerDetails(int customerID)
        {
            return saleDal.GetAllDetails(s => s.CustomerID == customerID);
        }

        public List<Sale> GetCustomerSales(int customerID)
        {
            return saleDal.GetAll(s => s.CustomerID == customerID);
        }

        public SaleDto GetDetailsByID(int id)
        {
            return saleDal.GetDetails(s => s.ID == id);
        }

        public void Update(Sale sale)
        {
            saleDal.Update(sale);
        }
    }
}
