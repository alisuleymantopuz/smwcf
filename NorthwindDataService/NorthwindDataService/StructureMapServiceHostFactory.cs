using NorthwindDataService.IoC;
using StructureMap;
using StructureMap.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Web;

namespace NorthwindDataService
{
    public class StructureMapServiceHostFactory : ServiceHostFactoryBase
    {
        public static IContainer Container;

        public StructureMapServiceHostFactory()
        {
            Container = Bootstrapper.Container;
        }

        protected ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            return new StructureMapServiceHost(serviceType, baseAddresses);
        }

        public override ServiceHostBase CreateServiceHost(string constructorString, Uri[] baseAddresses)
        {
            var t = Type.GetType(constructorString, true);

            return CreateServiceHost(t, baseAddresses);
        }
    }
}