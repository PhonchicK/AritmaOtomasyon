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
    public class StockInManager : IStockInService
    {
        private IStockInDal stockInDal;

        public StockInManager(IStockInDal stockInDal)
        {
            this.stockInDal = stockInDal;
        }

        public int Add(StockIn stockIn)
        {
            return stockInDal.Add(stockIn).ID;
        }

        public void Delete(StockIn stockIn)
        {
            stockInDal.Delete(stockIn);
        }

        public StockIn Get(int id)
        {
            return stockInDal.Get(s => s.ID == id);
        }

        public List<StockIn> GetAll()
        {
            return stockInDal.GetAll();
        }

        public List<StockIn> GetProductStockIns(int productID)
        {
            return stockInDal.GetAll(s => s.ProductID == productID);
        }

        public void Update(StockIn stockIn)
        {
            stockInDal.Update(stockIn);
        }
    }
}
