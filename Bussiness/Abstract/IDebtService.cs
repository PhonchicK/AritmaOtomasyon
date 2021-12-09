using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IDebtService
    {
        List<Debt> GetAll();
        List<Debt> GetCustomerDebts(int customerID);
        DebtDto GetCustomerDebt(int customerID);
        List<DebtDto> GetAllDetails();
        Debt GetByID(int id);
        int Add(Debt debt);
        void Delete(Debt debt);
        void Update(Debt debt);
    }
}
