using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDataService.Managed
{
    [RunInstaller(true)]
    public class ProjectInstaller : Installer
    {
        private ServiceProcessInstaller ServiceProcessInstaller;
        private ServiceInstaller ServiceInstaller;

        public ProjectInstaller()
        {
            ServiceProcessInstaller = new ServiceProcessInstaller();
            
            ServiceProcessInstaller.Account = ServiceAccount.LocalSystem;
            
            ServiceInstaller = new ServiceInstaller();
            
            ServiceInstaller.ServiceName = "Northwind Windows Service";
            
            Installers.Add(ServiceProcessInstaller);

            Installers.Add(ServiceInstaller);
        }
    }
}
