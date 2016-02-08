using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFIISSSLHostedCal
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class SSLServiceIIS : ISSLServiceIIS
    {

        double WCFServiceLibrary.ICalculator.Add(double n1, double n2)
        {
            return n1 + n2;
        }

        double WCFServiceLibrary.ICalculator.Subtract(double n1, double n2)
        {
            return n1 - n2;
        }

        double WCFServiceLibrary.ICalculator.Multiply(double n1, double n2)
        {
            return n1*n2;
        }

        double WCFServiceLibrary.ICalculator.Divide(double n1, double n2)
        {
            return n1 / n2;
        }
    }
}
