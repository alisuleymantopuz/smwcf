using NorthwindDataService.Orm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDataService.Repository.Contracts
{
    public interface ICustomerRepository
    {
        Customer Load(string id);
    }
}
