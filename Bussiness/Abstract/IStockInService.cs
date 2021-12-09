using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IStockInService
    {
        List<StockIn> GetProductStockIns(int productID);
        StockIn Get(int id);
        List<StockIn> GetAll();
        int Add(StockIn stockIn);
        void Update(StockIn stockIn);
        void Delete(StockIn stockIn);
    }
}
