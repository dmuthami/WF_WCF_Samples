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
        [OperationContract]
        Task<double> AddAsync(double n1, double n2);
        [OperationContract]
        Task<double> SubtractAsync(double n1, double n2);
        [OperationContract]
        Task<double> MultiplyAsync(double n1, double n2);
        [OperationContract]
        Task<double> DivideAsync(double n1, double n2);
    }
}
