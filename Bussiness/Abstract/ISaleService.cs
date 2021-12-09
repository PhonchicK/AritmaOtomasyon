﻿using Entities.Concrete;
using Entities.Dto;
using System.Collections.Generic;

namespace Bussiness.Abstract
{
    public interface ISaleService
    {
        Sale GetByID(int id);
        SaleDto GetDetailsByID(int id);
        List<Sale> GetAll();
        List<Sale> GetCustomerSales(int customerID);
        List<SaleDto> GetAllDetails();
        List<SaleDto> GetCustomerDetails(int customerID);
        List<SaleDto> GetProductDetails(int productID);
        int Add(Sale sale);
        void Update(Sale sale);
        void Delete(Sale sale);
    }
}
