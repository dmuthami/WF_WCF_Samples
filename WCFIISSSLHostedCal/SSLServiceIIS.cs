using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WCFIISSSLHostedCal
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class SSLServiceIIS : ISSLServiceIIS
    {

        public IAsyncResult BeginAddMethod(double n1, double n2, AsyncCallback callback, object asyncState)
        {
            var task = Task<double>.Factory.StartNew((res) => MyBeginAddMethod(asyncState, n1, n2), asyncState);
            return task.ContinueWith(res => callback(task));

        }
        public double EndAddMethod(IAsyncResult result)
        {
            return ((Task<double>)result).Result;
        }

        private double MyBeginAddMethod(object asyncState, double n1, double n2)
        {
            Thread.Sleep(10000);//Ten Seconds
            return (n1 + n2);
        }

        public IAsyncResult BeginSubtractMethod(double n1, double n2, AsyncCallback callback, object asyncState)
        {
            var task = Task<double>.Factory.StartNew((res) => MyBeginSubtractMethod(asyncState, n1, n2), asyncState);
            return task.ContinueWith(res => callback(task));

        }
        public double EndSubtractMethod(IAsyncResult result)
        {
            return ((Task<double>)result).Result;
        }

        private double MyBeginSubtractMethod(object asyncState, double n1, double n2)
        {
            Thread.Sleep(10000);//Ten Seconds
            return (n1 - n2);
        }

        public IAsyncResult BeginMultiplyMethod(double n1, double n2, AsyncCallback callback, object asyncState)
        {
            var task = Task<double>.Factory.StartNew((res) => MyBeginMultiplyMethod(asyncState, n1, n2), asyncState);
            return task.ContinueWith(res => callback(task));

        }
        public double EndMultiplyMethod(IAsyncResult result)
        {
            return ((Task<double>)result).Result;
        }

        private double MyBeginMultiplyMethod(object asyncState, double n1, double n2)
        {
            Thread.Sleep(10000);//Ten Seconds
            return (n1 * n2);
        }

        public IAsyncResult BeginDivideMethod(double n1, double n2, AsyncCallback callback, object asyncState)
        {
            var task = Task<double>.Factory.StartNew((res) => MyBeginDivideMethod(asyncState, n1, n2), asyncState);
            return task.ContinueWith(res => callback(task));

        }
        public double EndDivideMethod(IAsyncResult result)
        {
            return ((Task<double>)result).Result;
        }

        private double MyBeginDivideMethod(object asyncState, double n1, double n2)
        {
            Thread.Sleep(10000);//Ten Seconds
            return (n1 / n2);
        }
    }
}
