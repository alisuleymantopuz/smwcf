using NorthwindDataService.Managed.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDataService.Managed.Implementations
{
    public class ProductService : IProductService
    {
        public int TotalProductCount()
        {
            return 5;
        }
    }
}
