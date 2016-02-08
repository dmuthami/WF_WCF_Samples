using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GettingStartedClient.CalculatorServiceRef;//Self Service Host
using GettingStartedClient.WindowsServiceRef; //Windows Service Reference
using GettingStartedClient.IISServiceRef; //IIS Service reference
using GettingStartedClient.IISSSLServiceRef;

namespace GettingStartedClient
{
    class Program
    {
        static void Main(string[] args)
        {

            Program program = new Program();
            Console.WriteLine("Self Service Host: Type 1 at the prompt");
            Console.WriteLine("Windows Service Host: Type 2 at the prompt");
            Console.WriteLine("IIS Service Host: Type 3 at the prompt");
            Console.WriteLine("IIS SSL Service Host: Type 4 at the prompt");
            Console.WriteLine("To Exit the Application: Type 5 at the prompt");

            string line = Console.ReadLine(); // Get string from user

            if (line.ToString() == "1")
            {
                program.SelfServiceMenu();
            }
            else if (line.ToString() == "2")
            {
                program.WindowsServiceMenu();
            }
            else if (line.ToString() == "3")
            {
                program.IISServiceMenu();
            }
            else if (line.ToString() == "4")
            {
                program.IISSSLServiceMenu();
            }
            else
            {
                Console.WriteLine ("To Exit");
                Console.ReadLine();
            }
            

        }

        private void SelfServiceMenu()
        {
            //Step 1: Create an instance of the WCF proxy.
            CalculatorServiceRef.CalculatorClient client = new CalculatorServiceRef.CalculatorClient();

            // Step 2: Call the service operations.
            // Call the Add service operation.
            double value1 = 100.00D;
            double value2 = 15.99D;
            double result = client.Add(value1, value2);
            Console.WriteLine("Add({0},{1}) = {2}", value1, value2, result);

            // Call the Subtract service operation.
            value1 = 145.00D;
            value2 = 76.54D;
            result = client.Subtract(value1, value2);
            Console.WriteLine("Subtract({0},{1}) = {2}", value1, value2, result);

            // Call the Multiply service operation.
            value1 = 9.00D;
            value2 = 81.25D;
            result = client.Multiply(value1, value2);
            Console.WriteLine("Multiply({0},{1}) = {2}", value1, value2, result);

            // Call the Divide service operation.
            value1 = 22.00D;
            value2 = 7.00D;
            result = client.Divide(value1, value2);
            Console.WriteLine("Divide({0},{1}) = {2}", value1, value2, result);

            //Step 3: Closing the client gracefully closes the connection and cleans up resources.
            client.Close();

            Console.ReadLine(); // wait for user input
        }

        private void WindowsServiceMenu()
        {
            WindowsServiceRef.CalculatorClient client = new WindowsServiceRef.CalculatorClient();
            // Step 2: Call the service operations.
            // Call the Add service operation.
            double value1 = 213.00D;
            double value2 = 65.99D;
            double result = client.Add(value1, value2);
            Console.WriteLine("Add({0},{1}) = {2}", value1, value2, result);

            // Call the Subtract service operation.
            value1 = 256.00D;
            value2 = 67.54D;
            result = client.Subtract(value1, value2);
            Console.WriteLine("Subtract({0},{1}) = {2}", value1, value2, result);

            // Call the Multiply service operation.
            value1 = 92.00D;
            value2 = 452.25D;
            result = client.Multiply(value1, value2);
            Console.WriteLine("Multiply({0},{1}) = {2}", value1, value2, result);

            // Call the Divide service operation.
            value1 = 89.00D;
            value2 = 99.00D;
            result = client.Divide(value1, value2);
            Console.WriteLine("Divide({0},{1}) = {2}", value1, value2, result);

            //Step 3: Closing the client gracefully closes the connection and cleans up resources.
            client.Close();

            Console.ReadLine(); // wait for user input
        }

        private void IISServiceMenu()
        {
            IISServiceRef.ServiceIISClient client = new    IISServiceRef.ServiceIISClient();
         
            // Step 2: Call the service operations.
            // Call the Add service operation.
            double value1 = 4.00D;
            double value2 = 4.99D;
            double result = client.Add(value1, value2);
            Console.WriteLine("Add({0},{1}) = {2}", value1, value2, result);

            // Call the Subtract service operation.
            value1 = 10.00D;
            value2 = 6.54D;
            result = client.Subtract(value1, value2);
            Console.WriteLine("Subtract({0},{1}) = {2}", value1, value2, result);

            // Call the Multiply service operation.
            value1 = 2.00D;
            value2 = 2.25D;
            result = client.Multiply(value1, value2);
            Console.WriteLine("Multiply({0},{1}) = {2}", value1, value2, result);

            // Call the Divide service operation.
            value1 = 27.00D;
            value2 = 9.00D;
            result = client.Divide(value1, value2);
            Console.WriteLine("Divide({0},{1}) = {2}", value1, value2, result);

            value1 = 7.00D;
            result = client.circleArea(value1);
            Console.WriteLine("Area of a Circle(Radius: {0}) = {1}", value1, result);

            //Step 3: Closing the client gracefully closes the connection and cleans up resources.
            client.Close();

            Console.ReadLine(); // wait for user input
        }

        private void IISSSLServiceMenu()
        {
            
            IISSSLServiceRef.SSLServiceIISClient client = new IISSSLServiceRef.SSLServiceIISClient();
            // Step 2: Call the service operations.
            // Call the Add service operation.
            Console.WriteLine(Environment.NewLine + "------------------------------");
            Console.WriteLine("Consuming SSL WCF Service");
            double value1 = 100.00D;
            double value2 = 100.00D;
            double result = client.Add(value1, value2);
            Console.WriteLine("Add({0},{1}) = {2}", value1, value2, result);

            // Call the Subtract service operation.
            value1 = 200.54D;
            value2 = 100.54D;
            result = client.Subtract(value1, value2);
            Console.WriteLine("Subtract({0},{1}) = {2}", value1, value2, result);

            // Call the Multiply service operation.
            value1 = 10.00D;
            value2 = 10.00D;
            result = client.Multiply(value1, value2);
            Console.WriteLine("Multiply({0},{1}) = {2}", value1, value2, result);

            // Call the Divide service operation.
            value1 = 1000.00D;
            value2 = 10.00D;
            result = client.Divide(value1, value2);
            Console.WriteLine("Divide({0},{1}) = {2}", value1, value2, result);
            Console.WriteLine(Environment.NewLine+"End of SSL WCF Service");
            Console.WriteLine("------------------------------");

            //Step 3: Closing the client gracefully closes the connection and cleans up resources.
            client.Close();

            Console.ReadLine(); // wait for user input
        }
    }
}
