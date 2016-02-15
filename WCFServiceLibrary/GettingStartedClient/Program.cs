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
                //Self Service Client
                Task taskSelfServiceMenu = new Task(SelfServiceMenu);
                taskSelfServiceMenu.Start();
                taskSelfServiceMenu.Wait();
            }
            else if (line.ToString() == "2")
            {
                //Windows Service Client
                Task taskWindowsServiceMenu = new Task(WindowsServiceMenu);
                taskWindowsServiceMenu.Start();
                taskWindowsServiceMenu.Wait();
            }
            else if (line.ToString() == "3")
            {
                //IIS Service Client
                Task taskIISServiceMenu = new Task(IISServiceMenu);
                taskIISServiceMenu.Start();
                taskIISServiceMenu.Wait();
            }
            else if (line.ToString() == "4")
            {
                //IIS SSL Service Client
                Task taskIISSSLServiceMenu = new Task(IISSSLServiceMenu);
                taskIISSSLServiceMenu.Start();
                taskIISSSLServiceMenu.Wait();
            }
            else
            {
                Console.WriteLine("Exiting after none of the above choices was picked");
                Console.ReadLine();
            }
            Console.WriteLine("Hope you have enjoyed consuming a WCF");
            Console.ReadLine();
        }

        static async void SelfServiceMenu()
        {
            //Step 1: Create an instance of the WCF proxy.
            CalculatorServiceRef.CalculatorClient client = new CalculatorServiceRef.CalculatorClient();

            // Step 2: Call the service operations.
            // Call the Add service operation.
            double value1Add = 21.00D;
            double value2Add = 82.99D;
            var task = Task.Factory.StartNew(() => client.AddAsync(value1Add, value2Add));
            var str = await task;
            await str.ContinueWith(e =>
            {
                if (e.IsCompleted)
                {
                    Console.WriteLine("Add({0},{1}) = {2}", value1Add, value2Add, str.Result);
                }
            });
            Console.WriteLine("Waiting for the Addition result");

            // Call the Subtract service operation.
            double value1Subtract = 73.00D;
            double value2Subtract = 19.54D;
            var taskSubtract = Task.Factory.StartNew(() => client.SubtractAsync(value1Subtract, value2Subtract));
            var strsubtract = await taskSubtract;
            await strsubtract.ContinueWith(e =>
            {
                if (e.IsCompleted)
                {
                    Console.WriteLine("Subtract({0},{1}) = {2}", value1Subtract, value2Subtract, strsubtract.Result);
                }
            });
            Console.WriteLine("Waiting for the Subtract result");

            // Call the Multiply service operation.
            double value1Multiply = 93.00D;
            double value2Multiply = 43.25D;
            var taskMultiply = Task.Factory.StartNew(() => client.MultiplyAsync(value1Multiply, value2Multiply));
            var strMultiply = await taskMultiply;
            await strMultiply.ContinueWith(e =>
            {
                if (e.IsCompleted)
                {
                    Console.WriteLine("Multiply({0},{1}) = {2}", value1Multiply, value2Multiply, strMultiply.Result);
                }
            });
            Console.WriteLine("Waiting for the Multiply result");

            // Call the Divide service operation.
            double value1Divide = 22.00D;
            double value2Divide = 33.00D;
            var taskDivide = Task.Factory.StartNew(() => client.DivideAsync(value1Divide, value2Divide));
            var strDivide = await taskDivide;
            await strDivide.ContinueWith(e =>
            {
                if (e.IsCompleted)
                {
                    Console.WriteLine("Divide ({0},{1}) = {2}", value1Divide, value2Divide, strDivide.Result);
                }
            });
            Console.WriteLine("Waiting for the Divide result");
        }

        static async void WindowsServiceMenu()
        {
            WindowsServiceRef.CalculatorClient client = new WindowsServiceRef.CalculatorClient();
            // Step 2: Call the service operations.
            // Call the Add service operation.
            double value1Add = 213.00D;
            double value2Add = 65.99D;
            var task = Task.Factory.StartNew(() => client.AddAsync(value1Add, value2Add));
            var str = await task;
            await str.ContinueWith(e =>
            {
                if (e.IsCompleted)
                {
                    Console.WriteLine("Add({0},{1}) = {2}", value1Add, value2Add, str.Result);
                }
            });
            Console.WriteLine("Waiting for the Addition result");

            // Call the Subtract service operation.
            double value1Subtract = 256.00D;
            double value2Subtract = 67.54D;
            var taskSubtract = Task.Factory.StartNew(() => client.SubtractAsync(value1Subtract, value2Subtract));
            var strsubtract = await taskSubtract;
            await strsubtract.ContinueWith(e =>
            {
                if (e.IsCompleted)
                {
                    Console.WriteLine("Subtract({0},{1}) = {2}", value1Subtract, value2Subtract, strsubtract.Result);
                }
            });
            Console.WriteLine("Waiting for the Subtract result");

            // Call the Multiply service operation.
            double value1Multiply = 92.00D;
            double value2Multiply = 452.25D;
            var taskMultiply = Task.Factory.StartNew(() => client.MultiplyAsync(value1Multiply, value2Multiply));
            var strMultiply = await taskMultiply;
            await strMultiply.ContinueWith(e =>
            {
                if (e.IsCompleted)
                {
                    Console.WriteLine("Multiply({0},{1}) = {2}", value1Multiply, value2Multiply, strMultiply.Result);
                }
            });
            Console.WriteLine("Waiting for the Multiply result");

            // Call the Divide service operation.
            double value1Divide = 89.00D;
            double value2Divide = 99.00D;
            var taskDivide = Task.Factory.StartNew(() => client.DivideAsync(value1Divide, value2Divide));
            var strDivide = await taskDivide;
            await strDivide.ContinueWith(e =>
            {
                if (e.IsCompleted)
                {
                    Console.WriteLine("Divide ({0},{1}) = {2}", value1Divide, value2Divide, strDivide.Result);
                }
            });
            Console.WriteLine("Waiting for the Divide result");

        }

        static async void IISServiceMenu()
        {
            IISServiceRef.ServiceIISClient client = new IISServiceRef.ServiceIISClient();

            // Step 2: Call the service operations.
            // Call the Add service operation.
            double value1Add = 312.00D;
            double value2Add = 74.99D;
            var task = Task.Factory.StartNew(() => client.AddAsync(value1Add, value2Add));
            var str = await task;
            await str.ContinueWith(e =>
            {
                if (e.IsCompleted)
                {
                    Console.WriteLine("Add({0},{1}) = {2}", value1Add, value2Add, str.Result);
                }
            });
            Console.WriteLine("Waiting for the Addition result");

            // Call the Subtract service operation.
            double value1Subtract = 652.00D;
            double value2Subtract = 76.54D;
            var taskSubtract = Task.Factory.StartNew(() => client.SubtractAsync(value1Subtract, value2Subtract));
            var strsubtract = await taskSubtract;
            await strsubtract.ContinueWith(e =>
            {
                if (e.IsCompleted)
                {
                    Console.WriteLine("Subtract({0},{1}) = {2}", value1Subtract, value2Subtract, strsubtract.Result);
                }
            });
            Console.WriteLine("Waiting for the Subtract result");

            // Call the Multiply service operation.
            double value1Multiply = 29.00D;
            double value2Multiply = 254.25D;
            var taskMultiply = Task.Factory.StartNew(() => client.MultiplyAsync(value1Multiply, value2Multiply));
            var strMultiply = await taskMultiply;
            await strMultiply.ContinueWith(e =>
            {
                if (e.IsCompleted)
                {
                    Console.WriteLine("Multiply({0},{1}) = {2}", value1Multiply, value2Multiply, strMultiply.Result);
                }
            });
            Console.WriteLine("Waiting for the Multiply result");

            // Call the Divide service operation.
            double value1Divide = 45.00D;
            double value2Divide = 56.00D;
            var taskDivide = Task.Factory.StartNew(() => client.DivideAsync(value1Divide, value2Divide));
            var strDivide = await taskDivide;
            await strDivide.ContinueWith(e =>
            {
                if (e.IsCompleted)
                {
                    Console.WriteLine("Divide ({0},{1}) = {2}", value1Divide, value2Divide, strDivide.Result);
                }
            });
            Console.WriteLine("Waiting for the Divide result");

            double valueCircleArea = 7.00D;
            var taskCircleArea = Task.Factory.StartNew(() => client.circleAreaAsync(valueCircleArea));
            var strCircleArea = await taskCircleArea;
            await strCircleArea.ContinueWith(e =>
            {
                if (e.IsCompleted)
                {
                    Console.WriteLine("Area of A Circle ({0}) = {1}", valueCircleArea, strCircleArea.Result);
                }
            });
            Console.WriteLine("Waiting for the Circle Area result");
        }

        static async void IISSSLServiceMenu()
        {

            IISSSLServiceRef.SSLServiceIISClient client = new IISSSLServiceRef.SSLServiceIISClient();
            // Step 2: Call the service operations.
            // Call the Add service operation.
            //Console.WriteLine(Environment.NewLine + "------------------------------");
            //Console.WriteLine("Consuming SSL WCF Service");
            // Step 2: Call the service operations.
            // Call the Add service operation.
            double value1Add = 75.00D;
            double value2Add = 84.99D;
            var task = Task.Factory.StartNew(() => client.AddAsync(value1Add, value2Add));
            var str = await task;
            await str.ContinueWith(e =>
            {
                if (e.IsCompleted)
                {
                    Console.WriteLine("Add({0},{1}) = {2}", value1Add, value2Add, str.Result);
                }
            });
            Console.WriteLine("Waiting for the Addition result");

            // Call the Subtract service operation.
            double value1Subtract = 26.00D;
            double value2Subtract = 35.54D;
            var taskSubtract = Task.Factory.StartNew(() => client.SubtractAsync(value1Subtract, value2Subtract));
            var strsubtract = await taskSubtract;
            await strsubtract.ContinueWith(e =>
            {
                if (e.IsCompleted)
                {
                    Console.WriteLine("Subtract({0},{1}) = {2}", value1Subtract, value2Subtract, strsubtract.Result);
                }
            });
            Console.WriteLine("Waiting for the Subtract result");

            // Call the Multiply service operation.
            double value1Multiply = 95.00D;
            double value2Multiply = 689.25D;
            var taskMultiply = Task.Factory.StartNew(() => client.MultiplyAsync(value1Multiply, value2Multiply));
            var strMultiply = await taskMultiply;
            await strMultiply.ContinueWith(e =>
            {
                if (e.IsCompleted)
                {
                    Console.WriteLine("Multiply({0},{1}) = {2}", value1Multiply, value2Multiply, strMultiply.Result);
                }
            });
            Console.WriteLine("Waiting for the Multiply result");

            // Call the Divide service operation.
            double value1Divide = 59.00D;
            double value2Divide = 49.00D;
            var taskDivide = Task.Factory.StartNew(() => client.DivideAsync(value1Divide, value2Divide));
            var strDivide = await taskDivide;
            await strDivide.ContinueWith(e =>
            {
                if (e.IsCompleted)
                {
                    Console.WriteLine("Divide ({0},{1}) = {2}", value1Divide, value2Divide, strDivide.Result);
                }
            });
            Console.WriteLine("Waiting for the Divide result");
            //Console.WriteLine(Environment.NewLine+"End of SSL WCF Service");
            //Console.WriteLine("------------------------------");

        }
    }
}
