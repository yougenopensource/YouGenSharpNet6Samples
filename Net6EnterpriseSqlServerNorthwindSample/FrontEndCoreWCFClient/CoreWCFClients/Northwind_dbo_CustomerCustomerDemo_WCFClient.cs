﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Northwind_FrontEndCoreWCFClient.CoreWCFClients
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Northwind_FrontEndCoreWCFClient.CoreWCFClients.INorthwind_dbo_CustomerCustomerDem" +
        "o_Service")]
    public interface INorthwind_dbo_CustomerCustomerDemo_Service
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_CustomerCustomerDemo_Service/GetAll", ReplyAction="http://tempuri.org/INorthwind_dbo_CustomerCustomerDemo_Service/GetAllResponse")]
        System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_CustomerCustomerDemo_IR[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_CustomerCustomerDemo_Service/GetByCustomerIDAnd" +
            "CustomerTypeID", ReplyAction="http://tempuri.org/INorthwind_dbo_CustomerCustomerDemo_Service/GetByCustomerIDAnd" +
            "CustomerTypeIDResponse")]
        System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_CustomerCustomerDemo_IR[]> GetByCustomerIDAndCustomerTypeIDAsync(string customerID, string customerTypeID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_CustomerCustomerDemo_Service/Create", ReplyAction="http://tempuri.org/INorthwind_dbo_CustomerCustomerDemo_Service/CreateResponse")]
        System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_CustomerCustomerDemo_IR> CreateAsync(Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_CustomerCustomerDemo_IR input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_CustomerCustomerDemo_Service/UpdateByCustomerID" +
            "AndCustomerTypeID", ReplyAction="http://tempuri.org/INorthwind_dbo_CustomerCustomerDemo_Service/UpdateByCustomerID" +
            "AndCustomerTypeIDResponse")]
        System.Threading.Tasks.Task UpdateByCustomerIDAndCustomerTypeIDAsync(string customerID, string customerTypeID, Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_CustomerCustomerDemo_IR input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_CustomerCustomerDemo_Service/DeleteByCustomerID" +
            "AndCustomerTypeID", ReplyAction="http://tempuri.org/INorthwind_dbo_CustomerCustomerDemo_Service/DeleteByCustomerID" +
            "AndCustomerTypeIDResponse")]
        System.Threading.Tasks.Task DeleteByCustomerIDAndCustomerTypeIDAsync(string customerID, string customerTypeID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface INorthwind_dbo_CustomerCustomerDemo_ServiceChannel : Northwind_FrontEndCoreWCFClient.CoreWCFClients.INorthwind_dbo_CustomerCustomerDemo_Service, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class Northwind_dbo_CustomerCustomerDemo_ServiceClient : System.ServiceModel.ClientBase<Northwind_FrontEndCoreWCFClient.CoreWCFClients.INorthwind_dbo_CustomerCustomerDemo_Service>, Northwind_FrontEndCoreWCFClient.CoreWCFClients.INorthwind_dbo_CustomerCustomerDemo_Service
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public Northwind_dbo_CustomerCustomerDemo_ServiceClient() : 
                base(Northwind_dbo_CustomerCustomerDemo_ServiceClient.GetDefaultBinding(), Northwind_dbo_CustomerCustomerDemo_ServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_INorthwind_dbo_CustomerCustomerDemo_Service.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Northwind_dbo_CustomerCustomerDemo_ServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(Northwind_dbo_CustomerCustomerDemo_ServiceClient.GetBindingForEndpoint(endpointConfiguration), Northwind_dbo_CustomerCustomerDemo_ServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Northwind_dbo_CustomerCustomerDemo_ServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(Northwind_dbo_CustomerCustomerDemo_ServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Northwind_dbo_CustomerCustomerDemo_ServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(Northwind_dbo_CustomerCustomerDemo_ServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Northwind_dbo_CustomerCustomerDemo_ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_CustomerCustomerDemo_IR[]> GetAllAsync()
        {
            return base.Channel.GetAllAsync();
        }
        
        public System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_CustomerCustomerDemo_IR[]> GetByCustomerIDAndCustomerTypeIDAsync(string customerID, string customerTypeID)
        {
            return base.Channel.GetByCustomerIDAndCustomerTypeIDAsync(customerID, customerTypeID);
        }
        
        public System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_CustomerCustomerDemo_IR> CreateAsync(Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_CustomerCustomerDemo_IR input)
        {
            return base.Channel.CreateAsync(input);
        }
        
        public System.Threading.Tasks.Task UpdateByCustomerIDAndCustomerTypeIDAsync(string customerID, string customerTypeID, Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_CustomerCustomerDemo_IR input)
        {
            return base.Channel.UpdateByCustomerIDAndCustomerTypeIDAsync(customerID, customerTypeID, input);
        }
        
        public System.Threading.Tasks.Task DeleteByCustomerIDAndCustomerTypeIDAsync(string customerID, string customerTypeID)
        {
            return base.Channel.DeleteByCustomerIDAndCustomerTypeIDAsync(customerID, customerTypeID);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_INorthwind_dbo_CustomerCustomerDemo_Service))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_INorthwind_dbo_CustomerCustomerDemo_Service))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost:5001/Northwind_dbo_CustomerCustomerDemo_Service");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return Northwind_dbo_CustomerCustomerDemo_ServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_INorthwind_dbo_CustomerCustomerDemo_Service);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return Northwind_dbo_CustomerCustomerDemo_ServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_INorthwind_dbo_CustomerCustomerDemo_Service);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_INorthwind_dbo_CustomerCustomerDemo_Service,
        }
    }
}
