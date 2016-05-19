using NorthwindDataService.IoC.RegistryDefinitions;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwindDataService.IoC
{
    public static class Bootstrapper
    {
        private static IContainer _container;
        public static IContainer Container
        {
            get
            {
                if (_container == null)
                    Initialize();

                return _container;
            }
        }
        public static void Initialize()
        {
            _container = new Container(x =>
            {
                x.AddRegistry<RepositoryRegistry>();
                x.AddRegistry<ScannerRegistry>();
            });
        }
    }
}