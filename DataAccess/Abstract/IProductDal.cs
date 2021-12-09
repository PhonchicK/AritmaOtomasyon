using Core.DataAccess;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product> 
    {
        List<ProductDto> GetAllDetails(Expression<Func<ProductDto, bool>> filter = null);
        ProductDto GetDetails(Expression<Func<ProductDto, bool>> filter);
    }
}
