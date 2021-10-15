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
    public interface IDebtDal : IEntityRepository<Debt>
    {
        List<DebtDto> GetAllDetails(Expression<Func<DebtDto, bool>> filter = null);
        DebtDto GetCustomerDebt(int customerID);
    }
}
