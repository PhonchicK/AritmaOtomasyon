using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<ProductDto> GetAllDetails();
        Product GetByID(int id);
        int Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
