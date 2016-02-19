using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using WCFServiceLibrary;

namespace GettingStartedSelfHost
{
    //Create a console application project to host the service.
    //Create a service host for the service.
    //Enable metadata exchange.
    //Open the service host.
    class Program
    {
        static void Main(string[] args)
        {
            //// Step 1 Create a URI to serve as the base address.
            //Step 1 - Creates an instance of the Uri class to hold the base address of the service. Services are identified by a URL which contains a base address and an optional URI. 
            //The base address is formatted as follows:[transport]://[machine-name or domain][:optional port #]/[optional URI segment]The base address for the calculator service uses the HTTP transport, localhost, port 8000, and the URI segment “GettingStarted”
            
            Uri baseAddress = new Uri("http://localhost:8000/GettingStarted/");

            //// Step 2 Create a ServiceHost instance
            //Step 2 – Creates an instance of the T:System.ServiceModel.ServicHost class to host the service. 
            //The constructor takes two parameters, the type of the class that implements the service contract, 
            //and the base address of the service.

            ServiceHost selfHost = new ServiceHost(typeof(CalculatorService), baseAddress);

            try
            {
                //// Step 3 Add a service endpoint.
                //Step 3 – Creates a T:System.ServiceModel.ServiceEndpoint instance. 
                //A service endpoint is composed of an address, a binding, and a service contract. 
                //The T:System.ServiceModel.ServiceEndpoint constructor therefore takes the service contract interface type,
                //a binding, and an address.

                selfHost.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "CalculatorService");

                // Step 4 Enable metadata exchange.

                //Step 4 – Enable metadata exchange. Clients will use metadata exchange to generate proxies that will be used to call the service operations. 
                //To enable metadata exchange create a ServiceMetadataBehavior instance, 
                //set it’s HttpGetEnabled property to true, and add the behavior to the P:System.ServiceModel.ServiceHost.Behaviors 
                //collection of the ServiceHost instance.
                
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);

                // Step 5 Start the service.

                //Step 5 – Open the ServiceHost to listen for incoming messages. Notice the code waits for the user to hit enter. If you do not do this, the app will close immediately and the service will shut down.
                //Also notice a try/catch block used. After the ServiceHost has been instantiated, 
                //all other code is placed in a try/catch block. For more information about safely catching exceptions thrown 
                //by ServiceHost, see Avoiding Problems with the Using Statement 

                selfHost.Open();
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press <ENTER> to terminate service.");
                Console.WriteLine();
                Console.ReadLine();

                // Close the ServiceHostBase to shutdown the service.
                selfHost.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                selfHost.Abort();
            }
        }
    }
}
