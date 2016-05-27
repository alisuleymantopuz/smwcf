using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ServiceModel; 
using System.Configuration;
using System.Configuration.Install; 
using NorthwindDataService.IoC;

namespace NorthwindDataService.Managed
{
    public class ProductWindowsService : ServiceBase
    {
        // Start the Windows service.
        protected override void OnStart(string[] args)
        {   
            Bootstrapper.Initialize();
        }

        protected override void OnStop()
        {
            Bootstrapper.DisposeApplication();
        }
    }
}
