using NorthwindDataService.Orm;
using NorthwindDataService.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwindDataService.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public NorthwindEntities NorthwindEntities { get; private set; }
        public CustomerRepository(NorthwindEntities northwindEntities)
        {
            NorthwindEntities = northwindEntities;
        }

        public Customer Load(string id)
        {
            return NorthwindEntities.Customers.FirstOrDefault(x => x.CustomerID == id);
        }
    }
}