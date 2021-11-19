using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Entities.Dto;

namespace Bussiness.Abstract
{
    public interface IInstalmentService
    {
        List<Instalment> GetAll();
        List<InstalmentDto> GetAllDetails();
        List<InstalmentDto> GetNotPaidDetails();
        List<Instalment> GetSaleInstalments(int saleID);
        List<InstalmentDto> GetCustomerInstalments(int customerID);
        List<InstalmentDto> GetSaleInstalmentsDetails(int saleID);
        List<InstalmentDto> GetThisMonthInstalments();
        List<InstalmentDto> GetLateInstalments();
        List<InstalmentDetailsDto> GetAllCustomerDetails();
        Instalment GetByID(int id);
        InstalmentDto GetDetailsByID(int id);
        int Add(Instalment instalment);
        void Update(Instalment instalment);
        void Delete(Instalment instalment);
    }
}
