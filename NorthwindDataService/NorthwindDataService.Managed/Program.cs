using NorthwindDataService.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Autofac.Integration.Wcf;
using Autofac;
using Autofac.Core;
using NorthwindDataService.Managed.IoC;

namespace NorthwindDataService.Managed
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (Environment.UserInteractive)
            {
                var bootsrapper = new ApplicationBootstrapper();
                bootsrapper.Start();

                Console.WriteLine("Bootstrapper initialized, server ready.");
                Console.ReadLine();
            }
            else
            {
                ServiceBase.Run(new ServiceBase[] { new ApplicationService() });
            }
        }
    }
}
