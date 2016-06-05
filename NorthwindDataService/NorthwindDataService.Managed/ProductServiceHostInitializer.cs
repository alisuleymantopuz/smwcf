using Autofac;
using NorthwindDataService.Managed.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDataService.Managed
{
    public class ProductServiceHostInitializer : ServiceHostInitializerBase<ProductService, IProductService>
    {
        public ProductServiceHostInitializer(ILifetimeScope lifetimeScope)
            : base(lifetimeScope)
        {

        }
    }
}
