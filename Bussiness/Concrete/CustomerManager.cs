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
        ISaleService saleService;
        IDebtService debtService;
        public CustomerManager(ICustomerDal _customerDal, ISaleService _saleService, IDebtService _debtService)
        {
            customerDal = _customerDal;
            saleService = _saleService;
            debtService = _debtService;
        }
        public int Add(Customer customer)
        {
            return customerDal.Add(customer).ID;
        }

        public void Delete(Customer customer)
        {
            foreach(var item in saleService.GetCustomerSales(customer.ID))
            {
                if (item != null)
                    saleService.Delete(item);
            }
            foreach(var item in debtService.GetCustomerDebts(customer.ID))
            {
                if (item != null)
                    debtService.Delete(item);
            }
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
