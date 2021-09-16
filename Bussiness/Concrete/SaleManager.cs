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
        public SaleManager(ISaleDal _saleDal)
        {
            saleDal = _saleDal;
        }
        public int Add(Sale sale)
        {
            return saleDal.Add(sale).ID;
        }

        public void Delete(Sale sale)
        {
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
