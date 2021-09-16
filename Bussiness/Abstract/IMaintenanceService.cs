using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IMaintenanceService
    {
        List<Maintenance> GetAll();
        List<MaintenanceDto> GetAllDetails();
        Maintenance GetByID(int id);
        MaintenanceDto GetDetailsByID(int id);
        int Add(Maintenance maintenance);
        void Update(Maintenance maintenance);
        void Delete(Maintenance maintenance);
    }
}
