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
        //IAsyncResult asynchronous pattern
        [OperationContract(AsyncPattern = true)]
        IAsyncResult BeginCircleAreaMethod(double n1, AsyncCallback callback, object asyncState);
        double EndCircleAreaMethod(IAsyncResult result);

        // TODO: Add your additonal service operations here
    }

}
