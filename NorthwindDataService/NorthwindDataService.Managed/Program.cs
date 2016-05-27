using NorthwindDataService.IoC;
using NorthwindDataService.Managed.Contracts;
using NorthwindDataService.Managed.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Autofac.Integration.Wcf;

namespace NorthwindDataService.Managed
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (Environment.UserInteractive)
            {
                Bootstrapper.Initialize();
                Console.WriteLine("Bootstrapper initialized, server ready.");
                Console.ReadLine();
            }
            else
            {
                ServiceBase.Run(new ServiceBase[] { new ProductWindowsService() });
            }
        }
    }
}
