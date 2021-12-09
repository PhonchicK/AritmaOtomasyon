using Bussiness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal productDal;
        public ProductManager(IProductDal _productDal)
        {
            productDal = _productDal;
        }
        public int Add(Product product)
        {
            return productDal.Add(product).ID;
        }

        public void Delete(Product product)
        {
            productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return productDal.GetAll();
        }

        public List<ProductDto> GetAllDetails()
        {
            return productDal.GetAllDetails();
        }

        public Product GetByID(int id)
        {
            return productDal.Get(p => p.ID == id);
        }

        public void Update(Product product)
        {
            productDal.Update(product);
        }
    }
}
