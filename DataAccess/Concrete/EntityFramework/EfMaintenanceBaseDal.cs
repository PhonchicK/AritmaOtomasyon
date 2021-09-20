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
    public class EfMaintenanceBaseDal : EfEntityRepositoryBase<MaintenanceBase, MainContext>, IMaintenanceBaseDal
    {
        public List<MaintenanceDto> GetAllDetails(Expression<Func<MaintenanceDto, bool>> filter = null)
        {
            using (MainContext context = new MainContext())
            {
                var result = from mB in context.MaintenanceBases
                             join s in context.Sales
                             on mB.SaleID equals s.ID
                             join c in context.Customers
                             on s.CustomerID equals c.ID
                             join p in context.Products
                             on s.ProductID equals p.ID
                             join m in context.Maintenances
                             on mB.LastMaintenanceID equals m.ID into lastMaintenance
                             from LastMaintenance in lastMaintenance.DefaultIfEmpty()
                             select new MaintenanceDto
                             {
                                 ID = mB.ID,
                                 CustomerName = c.Name,
                                 CustomerPhoneNumber = c.PhoneNumber,
                                 CustomerAddress = c.Address,
                                 Product = p.Name,
                                 StartDate = mB.StartDate,
                                 MaintenanceInterval = mB.MaintenanceInterval,
                                 LastMaintenance = LastMaintenance.Date
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
                var result = from mB in context.MaintenanceBases
                             join s in context.Sales
                             on mB.SaleID equals s.ID
                             join c in context.Customers
                             on s.CustomerID equals c.ID
                             join p in context.Products
                             on s.ProductID equals p.ID
                             join m in context.Maintenances
                             on mB.LastMaintenanceID equals m.ID into lastMaintenance
                             from LastMaintenance in lastMaintenance.DefaultIfEmpty()
                             select new MaintenanceDto
                             {
                                 ID = mB.ID,
                                 CustomerName = c.Name,
                                 CustomerPhoneNumber = c.PhoneNumber,
                                 CustomerAddress = c.Address,
                                 Product = p.Name,
                                 StartDate = mB.StartDate,
                                 MaintenanceInterval = mB.MaintenanceInterval,
                                 LastMaintenance = LastMaintenance.Date
                             };
                return result.Where(filter).FirstOrDefault();
            }
        }
    }
}