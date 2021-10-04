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
        public SaleManager(ISaleDal _saleDal, IInstalmentDal _instalmentDal, IMaintenanceBaseDal _maintenanceBaseDal)
        {
            saleDal = _saleDal;
            instalmentDal = _instalmentDal;
            maintenanceBaseDal = _maintenanceBaseDal;
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

            var maintenance = maintenanceBaseDal.Get(m => m.SaleID == sale.ID);
            if (maintenance != null)
                maintenanceBaseDal.Delete(maintenance);

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
