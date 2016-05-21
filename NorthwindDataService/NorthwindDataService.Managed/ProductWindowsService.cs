using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.ServiceModel;
using System.ServiceProcess;
using System.Configuration;
using System.Configuration.Install;
using NorthwindDataService.Managed.Implementations;

namespace NorthwindDataService.Managed
{
    public class ProductWindowsService : ServiceBase
    {
        public ServiceHost ServiceHost { get; set; }
        public ProductWindowsService()
        {
            ServiceName = "Northwind - Products Service";
        }
        public static void Main()
        {
            ServiceBase.Run(new ProductWindowsService());
        }
        // Start the Windows service.
        protected override void OnStart(string[] args)
        {
            if (ServiceHost != null)
            {
                ServiceHost.Close();
            }

            ServiceHost = new ServiceHost(typeof(ProductService));

            ServiceHost.Open();
        }

        protected override void OnStop()
        {
            if (ServiceHost != null)
            {
                ServiceHost.Close();
                ServiceHost = null;
            }
        }
    }
}
