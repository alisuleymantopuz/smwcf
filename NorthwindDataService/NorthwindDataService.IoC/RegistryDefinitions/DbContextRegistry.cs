using NorthwindDataService.Orm;
using StructureMap;
using StructureMap.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwindDataService.IoC.RegistryDefinitions
{
    public class DbContextRegistry : Registry
    {
        public DbContextRegistry()
        {
            For<NorthwindEntities>().LifecycleIs(Lifecycles.ThreadLocal);
        }
    }
}