using Bussiness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class DebtManager : IDebtService
    {
        IDebtDal debtDal;

        public DebtManager(IDebtDal debtDal)
        {
            this.debtDal = debtDal;
        }

        public int Add(Debt debt)
        {
            return debtDal.Add(debt).ID;
        }

        public void Delete(Debt debt)
        {
            debtDal.Delete(debt);
        }

        public List<Debt> GetAll()
        {
            return debtDal.GetAll();
        }

        public List<DebtDto> GetAllDetails()
        {
            return debtDal.GetAllDetails();
        }

        public Debt GetByID(int id)
        {
            return null;
        }

        public List<Debt> GetCustomerDebts(int customerID)
        {
            return debtDal.GetAll(d => d.CustomerID == customerID);
        }

        public void Update(Debt debt)
        {
            debtDal.Update(debt);
        }
    }
}
