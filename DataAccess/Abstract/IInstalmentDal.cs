using Entities.Concrete;
using Entities.Dto;
using Core.DataAccess;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;

namespace DataAccess.Abstract
{
    public interface IInstalmentDal : IEntityRepository<Instalment>
    {
        InstalmentDto GetDetails(Expression<Func<InstalmentDto, bool>> filter);
        List<InstalmentDto> GetAllDetails(Expression<Func<InstalmentDto, bool>> filter = null);
        List<InstalmentDetailsDto> GetAllCustomerDetails(Expression<Func<InstalmentDetailsDto, bool>> filter = null);
    }
}
