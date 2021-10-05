using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SQLite;
using System.Linq;
using System.Linq.Expressions;

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
                                 CustomerID = s.CustomerID,
                                 CustomerName = c.Name,
                                 CustomerPhoneNumber = c.PhoneNumber,
                                 CustomerAddress = c.Address,
                                 SaleID = s.ID,
                                 ProductID = s.ProductID,
                                 Product = p.Name,
                                 StartDate = mB.StartDate,
                                 MaintenanceInterval = mB.MaintenanceInterval,
                                 LastMaintenance = LastMaintenance.Date,
                                 SaleDate = s.SaleDate
                             };

                result = result.ToList().Select(m => new MaintenanceDto(m.ID,m.CustomerID, m.CustomerName, m.CustomerPhoneNumber, m.CustomerAddress,m.SaleID, m.ProductID, m.Product, m.StartDate, m.MaintenanceInterval, m.LastMaintenance, m.SaleDate)).AsQueryable();

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
                                 CustomerID = s.CustomerID,
                                 CustomerName = c.Name,
                                 CustomerPhoneNumber = c.PhoneNumber,
                                 CustomerAddress = c.Address,
                                 SaleID = s.ID,
                                 ProductID = s.ProductID,
                                 Product = p.Name,
                                 StartDate = mB.StartDate,
                                 MaintenanceInterval = mB.MaintenanceInterval,
                                 LastMaintenance = LastMaintenance.Date,
                                 SaleDate = s.SaleDate
                             };

                result = result.ToList().Select(m => new MaintenanceDto(m.ID, m.CustomerID, m.CustomerName, m.CustomerPhoneNumber, m.CustomerAddress, m.SaleID, m.ProductID, m.Product, m.StartDate, m.MaintenanceInterval, m.LastMaintenance, m.SaleDate)).AsQueryable();

                return result.Where(filter).FirstOrDefault();
            }
        }
    }
}