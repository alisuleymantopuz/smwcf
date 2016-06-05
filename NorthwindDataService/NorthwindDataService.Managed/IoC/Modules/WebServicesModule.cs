﻿using Autofac;
using NorthwindDataService.Managed.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDataService.Managed.IoC.Modules
{
    public class WebServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new ProductService())
                .As<IProductService>()
                .InstancePerDependency();


        }
    }
}
