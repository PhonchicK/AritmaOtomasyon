using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, MainContext>, IProductDal
    {
        public List<ProductDto> GetAllDetails(Expression<Func<ProductDto, bool>> filter = null)
        {
            using (MainContext context = new MainContext())
            {
                var result = from p in context.Products
                             select new ProductDto
                             {
                                 ID = p.ID,
                                 Name = p.Name,
                                 Features = p.Features,
                                 Price = p.DefaultPrice,
                                 Count = ((context.StockIns.Where(si => si.ProductID == p.ID).Count() > 0 ? context.StockIns.Where(si => si.ProductID == p.ID).Sum(s => s.Count) : 0) - context.Sales.Where(s => s.ProductID == p.ID).Count())
                             };
                return filter == null ? // if filter is null
                    result.ToList() : // true : return
                    result.Where(filter).ToList();// false : use filter and return
            }
        }

        public ProductDto GetDetails(Expression<Func<ProductDto, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
