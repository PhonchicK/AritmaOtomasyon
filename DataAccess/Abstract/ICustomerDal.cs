using Core.DataAccess;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer> 
    {
        List<CustomerDto> GetAllDetails(Expression<Func<CustomerDto, bool>> filter = null);
        CustomerDto GetDetails(Expression<Func<CustomerDto, bool>> filter);
    }
}
