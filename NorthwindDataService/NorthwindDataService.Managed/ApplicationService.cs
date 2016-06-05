using NorthwindDataService.Managed.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDataService.Managed
{ 
    public class ApplicationService : ServiceBase
    {
        ApplicationBootstrapper _bootstrapper;

        protected override void OnStart(string[] args)
        {
            _bootstrapper = new ApplicationBootstrapper();
            _bootstrapper.Start();
        }

        protected override void OnStop()
        {
            _bootstrapper.Dispose();
        }
    }
}
