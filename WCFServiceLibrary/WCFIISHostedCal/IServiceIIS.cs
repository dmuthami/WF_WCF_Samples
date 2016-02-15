using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFServiceLibrary;

namespace WCFIISHostedCal
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceIIS : ICalculator
    {
        [OperationContract]
        Task<double> circleAreaAsync(double n2);
        // TODO: Add your service operations here
    }

}
