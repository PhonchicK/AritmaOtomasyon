using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using Entities.Dto;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfInstalmentDal : EfEntityRepositoryBase<Instalment, MainContext>, IInstalmentDal
    {
        public List<InstalmentDto> GetAllDetails(Expression<Func<InstalmentDto, bool>> filter = null)
        {
            using (MainContext context = new MainContext())
            {
                var result = from i in context.Instalments
                join s in context.Sales
                on i.SaleID equals s.ID
                join c in context.Customers
                on s.CustomerID equals c.ID
                join p in context.Products
                on s.ProductID equals p.ID
                select new InstalmentDto
                {
                    ID = i.ID,
                    CustomerID = c.ID,
                    CustomerName = c.Name,
                    CustomerPhoneNumber = c.PhoneNumber,
                    SaleID = s.ID,
                    Product = p.Name,
                    SaleDate = s.SaleDate,
                    InstalmentNo = i.InstalmentNo,
                    PaidPrice = i.PaidPrice,
                    PaidDate = i.PaidDate,
                    PayablePrice = i.PayablePrice,
                    PaymentDate = i.PaymentDate
                };
                return filter == null ? // if filter is null
                    result.ToList() : // true : return
                    result.Where(filter).ToList();// false : use filter and return
            }
        }

        public InstalmentDto GetDetails(Expression<Func<InstalmentDto, bool>> filter)
        {
            using (MainContext context = new MainContext())
            {
                var result = from i in context.Instalments
                             join s in context.Sales
                             on i.SaleID equals s.ID
                             join c in context.Customers
                             on s.CustomerID equals c.ID
                             join p in context.Products
                             on s.ProductID equals p.ID
                             select new InstalmentDto
                             {
                                 ID = i.ID,
                                 CustomerID = c.ID,
                                 CustomerName = c.Name,
                                 CustomerPhoneNumber = c.PhoneNumber,
                                 SaleID = s.ID,
                                 Product = p.Name,
                                 SaleDate = s.SaleDate,
                                 InstalmentNo = i.InstalmentNo,
                                 PaidPrice = i.PaidPrice,
                                 PaidDate = i.PaidDate,
                                 PayablePrice = i.PayablePrice,
                                 PaymentDate = i.PaymentDate
                             };
                return result.Where(filter).FirstOrDefault();
            }
        }
    }
}
