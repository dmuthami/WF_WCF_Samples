using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

using WCFServiceLibrary;

namespace WindowsServiceHost
{
    public class CalculatorWindowsService : ServiceBase
    {
        //Add a local variable to reference the ServiceHost Instance
        public ServiceHost serviceHost = null;

        /// <summary>
        /// Constructor class
        /// </summary>
        public CalculatorWindowsService()
        {
            // Name the Windows Service
            ServiceName = "WCFWindowsServiceSample";
        }

        //Define the main method that calls the service base
        public static void Main()
        {
            ServiceBase.Run(new CalculatorWindowsService());
        }
        /// <summary>
        ///  Start the Windows service
        ///  Override the OnStart(String[]) method by creating and opening a new
        ///  ServiceHost instance as shown in the following code.
        /// </summary>
        /// <param name="args"></param>
        protected override void OnStart(string[] args)
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
            }

            // Create a ServiceHost for the CalculatorService type and 
            // provide the base address.
            serviceHost = new ServiceHost(typeof(CalculatorService));

            // Open the ServiceHostBase to create listeners and start 
            // listening for messages.
            serviceHost.Open();
        }
        /// <summary>
        /// Override the OnStop method closing the ServiceHost as shown in the following code.
        /// </summary>
        protected override void OnStop()
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
                serviceHost = null;
            }
        }
    }
}
