using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMaintenanceDal : EfEntityRepositoryBase<Maintenance, MainContext>, IMaintenanceDal
    {
        public List<MaintenanceDto> GetAllDetails(Expression<Func<MaintenanceDto, bool>> filter = null)
        {
            using (MainContext context = new MainContext())
            {
                var result = from m in context.Maintenances
                             join s in context.Sales
                             on m.SaleID equals s.ID
                             join c in context.Customers
                             on s.CustomerID equals c.ID
                             select new MaintenanceDto
                             {
                                 ID = m.ID,
                                 CustomerName = c.Name,
                                 CustomerPhoneNumber = c.PhoneNumber,
                                 CustomerAddress = c.Address,
                                 Product = s.Product,
                                 StartDate = m.StartDate,
                                 MaintenanceInterval = m.MaintenanceInterval,
                                 LastMaintenance = m.LastMaintenance
                             };
                return filter == null ? // if filter is null
                    result.ToList() : // true : return
                    result.Where(filter).ToList();// false : use filter and return
            }
        }

        public MaintenanceDto GetDetails(Expression<Func<MaintenanceDto, bool>> filter)
        {
            using (MainContext context = new MainContext())
            {
                var result = from m in context.Maintenances
                             join s in context.Sales
                             on m.SaleID equals s.ID
                             join c in context.Customers
                             on s.CustomerID equals c.ID
                             select new MaintenanceDto
                             {
                                 ID = m.ID,
                                 CustomerName = c.Name,
                                 CustomerPhoneNumber = c.PhoneNumber,
                                 CustomerAddress = c.Address,
                                 Product = s.Product,
                                 StartDate = m.StartDate,
                                 MaintenanceInterval = m.MaintenanceInterval,
                                 LastMaintenance = m.LastMaintenance
                             };
                return result.Where(filter).FirstOrDefault();
            }
        }
    }
}