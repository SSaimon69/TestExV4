//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MainAppClient.CalcServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalcServiceReference.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CalculateWordSingleService", ReplyAction="http://tempuri.org/IService/CalculateWordSingleServiceResponse")]
        System.Collections.Generic.Dictionary<string, int> CalculateWordSingleService(string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CalculateWordSingleService", ReplyAction="http://tempuri.org/IService/CalculateWordSingleServiceResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, int>> CalculateWordSingleServiceAsync(string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CalculateWordMultiService", ReplyAction="http://tempuri.org/IService/CalculateWordMultiServiceResponse")]
        System.Collections.Generic.Dictionary<string, int> CalculateWordMultiService(string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CalculateWordMultiService", ReplyAction="http://tempuri.org/IService/CalculateWordMultiServiceResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, int>> CalculateWordMultiServiceAsync(string text);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : MainAppClient.CalcServiceReference.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<MainAppClient.CalcServiceReference.IService>, MainAppClient.CalcServiceReference.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.Dictionary<string, int> CalculateWordSingleService(string text) {
            return base.Channel.CalculateWordSingleService(text);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, int>> CalculateWordSingleServiceAsync(string text) {
            return base.Channel.CalculateWordSingleServiceAsync(text);
        }
        
        public System.Collections.Generic.Dictionary<string, int> CalculateWordMultiService(string text) {
            return base.Channel.CalculateWordMultiService(text);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, int>> CalculateWordMultiServiceAsync(string text) {
            return base.Channel.CalculateWordMultiServiceAsync(text);
        }
    }
}
