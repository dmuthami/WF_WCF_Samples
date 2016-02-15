using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WCFServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CalculatorService : ICalculator
    {
        public async Task<double> AddAsync(double n1, double n2)
        {
            var task = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(10000);//Ten Seconds
                return  (n1 + n2);
            });
            return await task.ConfigureAwait(false);
            
        }
        public async Task<double> SubtractAsync(double n1, double n2)
        {
            var task = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(12500);//Ten Seconds
                return (n1 - n2);
            });
            return await task.ConfigureAwait(false);
            
        }
        public async Task<double> MultiplyAsync(double n1, double n2)
        {
            var task = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(15000);//Ten Seconds
                return (n1 * n2);
            });
            return await task.ConfigureAwait(false);         
        }
        public async Task<double> DivideAsync(double n1, double n2)
        {
            var task = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(20000);//Ten Seconds
                return (n1 / n2);
            });
            return await task.ConfigureAwait(false);
        }
    }
}
