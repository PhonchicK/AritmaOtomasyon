﻿using Entities.Concrete;
using System.Collections.Generic;

namespace Bussiness.Abstract
{
    public interface ICustomerService
    {
        Customer GetByID(int id);
        List<Customer> GetAll();
        void Add(Customer customer);
        void Delete(Customer customer);
        void Update(Customer customer);
    }
}