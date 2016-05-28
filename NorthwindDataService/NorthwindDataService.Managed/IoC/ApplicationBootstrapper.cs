using Autofac;
using Autofac.Integration.Wcf;
using NorthwindDataService.IoC.RegistryDefinitions;
using NorthwindDataService.Managed.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Web;

namespace NorthwindDataService.Managed.IoC
{
    public class ApplicationBootstrapper : IDisposable
    {
        readonly IContainer _container;

        public ApplicationBootstrapper()
        {
            var builder = new ContainerBuilder();

            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            builder.RegisterAssemblyModules(assemblies);

            builder.RegisterAssemblyTypes(assemblies)
                .Where(type => type.IsAssignableTo<IServiceHostInitializer>())
                .As<IServiceHostInitializer>()
                .SingleInstance();

            _container = builder.Build();
        }

        public void Start()
        {
            foreach (var serviceHostInitializer in _container.Resolve<IEnumerable<IServiceHostInitializer>>())
                serviceHostInitializer.Initialize();
        }

        public void Dispose()
        {
            if (_container != null)
                _container.Dispose();
        }
    }
}