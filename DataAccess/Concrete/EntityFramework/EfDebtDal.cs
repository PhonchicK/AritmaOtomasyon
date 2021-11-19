using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDebtDal : EfEntityRepositoryBase<Debt, MainContext>, IDebtDal
    {
        public List<DebtDto> GetAllDetails(Expression<Func<DebtDto, bool>> filter = null)
        {
            using (MainContext context = new MainContext())
            {
                var result = from d in context.Debts
                             group d by d.CustomerID into dC
                             join c in context.Customers
                             on dC.Key equals c.ID
                             select new DebtDto
                             {
                                 CustomerID = c.ID,
                                 CustomerName = c.Name,
                                 CustomerPhoneNumber = c.PhoneNumber,
                                 Receive = dC.Sum(d => d.Receive),
                                 Give = dC.Sum(d => d.Give),
                                 Balance = dC.Sum(d => d.Give) - dC.Sum(d => d.Receive)
                             };
                return filter == null ? // if filter is null
                    result.ToList() : // true : return
                    result.Where(filter).ToList();// false : use filter and return
            }
        }

        public DebtDto GetCustomerDebt(int customerID)
        {
            using (MainContext context = new MainContext())
            {
                var result = from d in context.Debts
                             group d by d.CustomerID into dC
                             join c in context.Customers
                             on dC.Key equals c.ID
                             select new DebtDto
                             {
                                 CustomerID = c.ID,
                                 CustomerName = c.Name,
                                 CustomerPhoneNumber = c.PhoneNumber,
                                 Receive = dC.Sum(d => d.Receive),
                                 Give = dC.Sum(d => d.Give),
                                 Balance = dC.Sum(d => d.Give) - dC.Sum(d => d.Receive)
                             };
                return result.Where(r => r.CustomerID == customerID).FirstOrDefault();// false : use filter and return
            }
        }
    }
}
