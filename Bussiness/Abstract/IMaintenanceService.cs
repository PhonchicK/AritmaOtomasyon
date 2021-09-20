using Entities.Concrete;
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
        List<Maintenance> GetByBaseID(int maintenanceBaseID);
        Maintenance GetByID(int id);
        int Add(Maintenance maintenance);
        void Update(Maintenance maintenance);
        void Delete(Maintenance maintenance);
    }
}
