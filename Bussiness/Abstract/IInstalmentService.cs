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
        List<Instalment> GetSaleInstalments(int saleID);
        Instalment GetByID(int id);
        InstalmentDto GetDetailsByID(int id);
        int Add(Instalment instalment);
        void Update(Instalment instalment);
        void Delete(Instalment instalment);
    }
}
