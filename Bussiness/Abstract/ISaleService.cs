using Entities.Concrete;
using System.Collections.Generic;

namespace Bussiness.Abstract
{
    public interface ISaleService
    {
        Sale GetByID(int id);
        List<Sale> GetAll();
        void Add(Sale sale);
        void Update(Sale sale);
        void Delete(Sale sale);
    }
}
