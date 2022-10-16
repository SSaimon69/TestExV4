using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CalcService
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        Dictionary<string, int> CalculateWordSingleService(string text);

        [OperationContract]
        ConcurrentDictionary<string, int> CalculateWordMultiService(string text);
    }
}
