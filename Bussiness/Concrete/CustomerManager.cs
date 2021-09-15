using Bussiness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Bussiness.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal customerDal;
        public CustomerManager(ICustomerDal _customerDal)
        {
            customerDal = _customerDal;
        }
        public void Add(Customer customer)
        {
            customerDal.Add(customer);
        }

        public void Delete(Customer customer)
        {
            customerDal.Delete(customer);
        }

        public List<Customer> GetAll()
        {
            return customerDal.GetAll();
        }

        public Customer GetByID(int id)
        {
            return customerDal.Get(c => c.ID == id);
        }

        public void Update(Customer customer)
        {
            customerDal.Update(customer);
        }
    }
}
