using NorthwindDataService.Repository;
using NorthwindDataService.Repository.Contracts;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwindDataService.IoC.RegistryDefinitions
{
    public class RepositoryRegistry : Registry
    {
        public RepositoryRegistry()
        {
            For<ICustomerRepository>().Use<CustomerRepository>();
        }
    }
}