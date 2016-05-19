using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMap.Graph;

namespace NorthwindDataService.IoC.RegistryDefinitions
{
    public class ScannerRegistry : Registry
    {
        public ScannerRegistry()
        {
            Scan(x =>
            {
                x.AssembliesFromApplicationBaseDirectory();
                x.TheCallingAssembly();
                x.WithDefaultConventions();
            });
        }
    }
}