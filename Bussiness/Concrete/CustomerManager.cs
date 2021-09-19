using Bussiness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
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
        public int Add(Customer customer)
        {
            return customerDal.Add(customer).ID;
        }

        public void Delete(Customer customer)
        {
            customerDal.Delete(customer);
        }

        public List<Customer> GetAll()
        {
            return customerDal.GetAll();
        }

        public List<CustomerDto> GetAllDetails()
        {
            return customerDal.GetAllDetails();
        }

        public Customer GetByID(int id)
        {
            return customerDal.Get(c => c.ID == id);
        }

        public CustomerDto GetDetails(int id)
        {
            return customerDal.GetDetails(c => c.ID == id);
        }

        public void Update(Customer customer)
        {
            customerDal.Update(customer);
        }
    }
}
