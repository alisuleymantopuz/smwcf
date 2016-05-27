using Autofac;
using Autofac.Integration.Wcf;
using NorthwindDataService.IoC.RegistryDefinitions;
using NorthwindDataService.Managed.Contracts;
using NorthwindDataService.Managed.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Web;

namespace NorthwindDataService.Managed
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
            var builder = new ContainerBuilder();
             
            builder.Register(c => new ChannelFactory<IProductService>(new NetTcpBinding(SecurityMode.None)
            {
                CloseTimeout = TimeSpan.FromMinutes(1),
                OpenTimeout = TimeSpan.FromMinutes(1),
                SendTimeout = TimeSpan.FromMinutes(10),
                ReceiveTimeout = TimeSpan.FromMinutes(10)
            },
            new EndpointAddress("net.tcp://localhost:9002/ProductService"))).SingleInstance();

            builder.Register(c => c.Resolve<ChannelFactory<IProductService>>()
                .CreateChannel())
                .As<IProductService>()
                .UseWcfSafeRelease();

            builder.RegisterType<ProductService>().As<IProductService>();

            _container = builder.Build();

            AutofacHostFactory.Container = _container;
        }

        public static void DisposeApplication()
        {

        }
    }
}