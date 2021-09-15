using Bussiness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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
        public void Add(Sale sale)
        {
            saleDal.Add(sale);
        }

        public void Delete(Sale sale)
        {
            saleDal.Delete(sale);
        }

        public List<Sale> GetAll()
        {
            return saleDal.GetAll();
        }

        public Sale GetByID(int id)
        {
            return saleDal.Get(s => s.ID == id);
        }

        public void Update(Sale sale)
        {
            saleDal.Update(sale);
        }
    }
}
