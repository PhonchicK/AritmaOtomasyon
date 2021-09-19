using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using Entities.Dto;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, MainContext>, ICustomerDal
    {
        public List<CustomerDto> GetAllDetails(Expression<Func<CustomerDto, bool>> filter = null)
        {
            using (MainContext context = new MainContext())
            {
                var result = from c in context.Customers
                             join cR in context.Customers
                             on c.ReferanceCustomerID equals cR.ID into crName from refCustomer in crName.DefaultIfEmpty()
                             select new CustomerDto
                             {
                                 ID = c.ID,
                                 Name = c.Name,
                                 PhoneNumber = c.PhoneNumber,
                                 Address = c.Address,
                                 ReferanceCustomerName = refCustomer.Name
                             };
                return filter == null ? // if filter is null
                    result.ToList() : // true : return
                    result.Where(filter).ToList();// false : use filter and return
            }
        }

        public CustomerDto GetDetails(Expression<Func<CustomerDto, bool>> filter)
        {
            using (MainContext context = new MainContext())
            {
                var result = from c in context.Customers
                             join cR in context.Customers
                             on c.ReferanceCustomerID equals cR.ID into crName
                             from refCustomer in crName.DefaultIfEmpty()
                             select new CustomerDto
                             {
                                 ID = c.ID,
                                 Name = c.Name,
                                 PhoneNumber = c.PhoneNumber,
                                 Address = c.Address,
                                 ReferanceCustomerName = refCustomer.Name
                             };
                return result.Where(filter).FirstOrDefault();
            }
        }
    }
}
