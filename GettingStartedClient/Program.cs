using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using GettingStartedClient.CalculatorServiceRef;//Self Service Host
using GettingStartedClient.WindowsServiceRef; //Windows Service Reference
//using GettingStartedClient.IISServiceRef; //IIS Service reference
//using GettingStartedClient.IISSSLServiceRef;

namespace GettingStartedClient
{
    class Program
    {
        //Windows Service Client
        static WindowsServiceRef.CalculatorClient clientWS = new WindowsServiceRef.CalculatorClient();

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

            }
            else if (line.ToString() == "2")
            {

                double value1Add = 21.00D;
                double value2Add = 82.99D;
                clientWS.BeginAddMethod(value1Add, value2Add, new AsyncCallback(GetAddDataCallBack), null);
                Console.WriteLine("Waiting for the windows service host async operation.......");

            }
            else if (line.ToString() == "3")
            {

            }
            else if (line.ToString() == "4")
            {

            }
            else
            {
                Console.WriteLine("Exiting after none of the above choices was picked");
                Console.ReadLine();
            }
            
            Console.ReadLine();
        }

        static void GetAddDataCallBack(IAsyncResult result)
        {
            Console.WriteLine(clientWS.EndAddMethod(result).ToString());
        }
    }
}
