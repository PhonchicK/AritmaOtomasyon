using Entities.Concrete;
using Entities.Dto;
using System.Collections.Generic;

namespace Bussiness.Abstract
{
    public interface ICustomerService
    {
        Customer GetByID(int id);
        CustomerDto GetDetails(int id);
        List<Customer> GetAll();
        List<CustomerDto> GetAllDetails();
        int Add(Customer customer);
        void Delete(Customer customer);
        void Update(Customer customer);
    }
}
