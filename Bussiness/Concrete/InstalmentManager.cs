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
    public class InstalmentManager : IInstalmentService
    {
        IInstalmentDal instalmentDal;
        public InstalmentManager(IInstalmentDal _instalmentDal)
        {
            instalmentDal = _instalmentDal;
        }
        public int Add(Instalment instalment)
        {
            return instalmentDal.Add(instalment).ID;
        }
        public void Delete(Instalment instalment)
        {
            instalmentDal.Delete(instalment);
        }

        public List<Instalment> GetAll()
        {
            return instalmentDal.GetAll();
        }

        public List<InstalmentDto> GetAllDetails()
        {
            return instalmentDal.GetAllDetails();
        }

        public Instalment GetByID(int id)
        {
            return instalmentDal.Get(i => i.ID == id);
        }

        public List<InstalmentDto> GetCustomerInstalments(int customerID)
        {
            return instalmentDal.GetAllDetails(i => i.CustomerID == customerID);
        }

        public InstalmentDto GetDetailsByID(int id)
        {
            return instalmentDal.GetDetails(i => i.ID == id);
        }

        public List<InstalmentDto> GetNotPaidDetails()
        {
            return instalmentDal.GetAllDetails(i => i.PaidPrice < i.PayablePrice);
        }

        public List<Instalment> GetSaleInstalments(int saleID)
        {
            return instalmentDal.GetAll(i => i.SaleID == saleID);
        }

        public void Update(Instalment instalment)
        {
            instalmentDal.Update(instalment);
        }
    }
}
