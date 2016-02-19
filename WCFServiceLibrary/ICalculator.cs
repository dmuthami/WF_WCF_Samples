using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Namespace="http://Microsoft.ServiceModel.Samples")]
    public interface ICalculator
    {
        //IAsyncResult asynchronous pattern
        [OperationContract(AsyncPattern = true)]
        IAsyncResult BeginAddMethod(double n1, double n2, AsyncCallback callback, object asyncState);
        double EndAddMethod(IAsyncResult result);

        [OperationContract(AsyncPattern = true)]
        IAsyncResult BeginSubtractMethod(double n1, double n2, AsyncCallback callback, object asyncState);
        double EndSubtractMethod(IAsyncResult result);

        [OperationContract(AsyncPattern = true)]
        IAsyncResult BeginMultiplyMethod(double n1, double n2, AsyncCallback callback, object asyncState);

        double EndMultiplyMethod(IAsyncResult result);

        [OperationContract(AsyncPattern = true)]
        IAsyncResult BeginDivideMethod(double n1, double n2, AsyncCallback callback, object asyncState);

        double EndDivideMethod(IAsyncResult result);
    }
}
