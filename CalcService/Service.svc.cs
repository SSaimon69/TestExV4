using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WordCalc;

namespace CalcService
{
    public class Service : IService
    {
        public Dictionary<string, int> CalculateWordSingleService(string text)
        {
            return new Calc().CalculateWordSingle(text);
        }

        public ConcurrentDictionary<string, int> CalculateWordMultiService(string text)
        {
            return new Calc().CalculateWordMulti(text);
        }
    }
}
