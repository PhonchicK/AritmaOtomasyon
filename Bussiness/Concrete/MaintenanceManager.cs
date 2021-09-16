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
    public class MaintenanceManager : IMaintenanceService
    {
        IMaintenanceDal maintenanceDal;
        public MaintenanceManager(IMaintenanceDal _maintenanceDal)
        {
            maintenanceDal = _maintenanceDal;
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

        public List<MaintenanceDto> GetAllDetails()
        {
            return maintenanceDal.GetAllDetails();
        }

        public Maintenance GetByID(int id)
        {
            return maintenanceDal.Get(m => m.ID == id);
        }

        public MaintenanceDto GetDetailsByID(int id)
        {
            return maintenanceDal.GetDetails(m => m.ID == id);
        }

        public void Update(Maintenance maintenance)
        {
            maintenanceDal.Update(maintenance);
        }
    }
}
