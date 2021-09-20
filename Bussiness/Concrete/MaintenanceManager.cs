using Bussiness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class MaintenanceManager : IMaintenanceService
    {
        IMaintenanceDal maintenanceDal;

        public MaintenanceManager(IMaintenanceDal _maintenanceDal)
        {
            this.maintenanceDal = _maintenanceDal;
        }

        public int Add(Maintenance maintenance)
        {
            return maintenanceDal.Add(maintenance).ID;
        }

        public void Delete(Maintenance maintenance)
        {
            maintenanceDal.Delete(maintenance);
        }

        public List<Maintenance> GetAll()
        {
            return maintenanceDal.GetAll();
        }

        public Maintenance GetByID(int id)
        {
            return maintenanceDal.Get(m => m.ID == id);
        }

        public List<Maintenance> GetByBaseID(int maintenanceBaseID)
        {
            return maintenanceDal.GetAll(m => m.MaintenanceBaseID == maintenanceBaseID);
        }

        public void Update(Maintenance maintenance)
        {
            maintenanceDal.Update(maintenance);
        }
    }
}
