using NorthwindDataService.DataContracts;
using NorthwindDataService.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwindDataService.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public CustomerInfo LoadById(int id)
        {
            return new CustomerInfo { Id = 1, Name = "ALFKI" };
        }
    }
}