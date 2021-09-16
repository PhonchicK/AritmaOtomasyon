﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using Entities.Dto;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSaleDal : EfEntityRepositoryBase<Sale, MainContext>, ISaleDal
    {
        public List<SaleDto> GetAllDetails(Expression<Func<SaleDto, bool>> filter = null)
        {
            using (MainContext context = new MainContext())
            {
                var result = from s in context.Sales
                             join c in context.Customers
                             on s.CustomerID equals c.ID
                             select new SaleDto
                             {
                                 ID = s.ID,
                                 CustomerName = c.Name,
                                 CustomerPhoneNumber = c.PhoneNumber,
                                 Product = s.Product,
                                 Price = s.Price,
                                 PaymentType = s.PaymentType,
                                 SaleDate = s.SaleDate,
                                 RemainderPrice = s.RemainderPrice
                             };
                return filter == null ? // if filter is null
                    result.ToList() : // true : return
                    result.Where(filter).ToList();// false : use filter and return
            }
        }

        public SaleDto GetDetails(Expression<Func<SaleDto, bool>> filter)
        {
            using (MainContext context = new MainContext())
            {
                var result = from s in context.Sales
                             join c in context.Customers
                             on s.CustomerID equals c.ID
                             select new SaleDto
                             {
                                 ID = s.ID,
                                 CustomerName = c.Name,
                                 CustomerPhoneNumber = c.PhoneNumber,
                                 Product = s.Product,
                                 Price = s.Price,
                                 PaymentType = s.PaymentType,
                                 SaleDate = s.SaleDate,
                                 RemainderPrice = s.RemainderPrice
                             };
                return result.Where(filter).FirstOrDefault();
            }
        }
    }
}
