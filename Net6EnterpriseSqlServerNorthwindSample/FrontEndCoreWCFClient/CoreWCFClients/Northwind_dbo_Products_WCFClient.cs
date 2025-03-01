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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Northwind_FrontEndCoreWCFClient.CoreWCFClients.INorthwind_dbo_Products_Service")]
    public interface INorthwind_dbo_Products_Service
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Products_Service/GetAll", ReplyAction="http://tempuri.org/INorthwind_dbo_Products_Service/GetAllResponse")]
        System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Products_IR[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Products_Service/GetByCategoryID", ReplyAction="http://tempuri.org/INorthwind_dbo_Products_Service/GetByCategoryIDResponse")]
        System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Products_IR[]> GetByCategoryIDAsync(string categoryID_IR);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Products_Service/GetByProductID", ReplyAction="http://tempuri.org/INorthwind_dbo_Products_Service/GetByProductIDResponse")]
        System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Products_IR[]> GetByProductIDAsync(string productID_IR);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Products_Service/GetByProductName", ReplyAction="http://tempuri.org/INorthwind_dbo_Products_Service/GetByProductNameResponse")]
        System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Products_IR[]> GetByProductNameAsync(string productName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Products_Service/GetBySupplierID", ReplyAction="http://tempuri.org/INorthwind_dbo_Products_Service/GetBySupplierIDResponse")]
        System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Products_IR[]> GetBySupplierIDAsync(string supplierID_IR);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Products_Service/Create", ReplyAction="http://tempuri.org/INorthwind_dbo_Products_Service/CreateResponse")]
        System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Products_IR> CreateAsync(Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Products_IR input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Products_Service/UpdateByCategoryID", ReplyAction="http://tempuri.org/INorthwind_dbo_Products_Service/UpdateByCategoryIDResponse")]
        System.Threading.Tasks.Task UpdateByCategoryIDAsync(string categoryID_IR, Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Products_IR input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Products_Service/UpdateByProductID", ReplyAction="http://tempuri.org/INorthwind_dbo_Products_Service/UpdateByProductIDResponse")]
        System.Threading.Tasks.Task UpdateByProductIDAsync(string productID_IR, Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Products_IR input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Products_Service/UpdateByProductName", ReplyAction="http://tempuri.org/INorthwind_dbo_Products_Service/UpdateByProductNameResponse")]
        System.Threading.Tasks.Task UpdateByProductNameAsync(string productName, Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Products_IR input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Products_Service/UpdateBySupplierID", ReplyAction="http://tempuri.org/INorthwind_dbo_Products_Service/UpdateBySupplierIDResponse")]
        System.Threading.Tasks.Task UpdateBySupplierIDAsync(string supplierID_IR, Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Products_IR input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Products_Service/DeleteByCategoryID", ReplyAction="http://tempuri.org/INorthwind_dbo_Products_Service/DeleteByCategoryIDResponse")]
        System.Threading.Tasks.Task DeleteByCategoryIDAsync(string categoryID_IR);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Products_Service/DeleteByProductID", ReplyAction="http://tempuri.org/INorthwind_dbo_Products_Service/DeleteByProductIDResponse")]
        System.Threading.Tasks.Task DeleteByProductIDAsync(string productID_IR);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Products_Service/DeleteByProductName", ReplyAction="http://tempuri.org/INorthwind_dbo_Products_Service/DeleteByProductNameResponse")]
        System.Threading.Tasks.Task DeleteByProductNameAsync(string productName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Products_Service/DeleteBySupplierID", ReplyAction="http://tempuri.org/INorthwind_dbo_Products_Service/DeleteBySupplierIDResponse")]
        System.Threading.Tasks.Task DeleteBySupplierIDAsync(string supplierID_IR);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface INorthwind_dbo_Products_ServiceChannel : Northwind_FrontEndCoreWCFClient.CoreWCFClients.INorthwind_dbo_Products_Service, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class Northwind_dbo_Products_ServiceClient : System.ServiceModel.ClientBase<Northwind_FrontEndCoreWCFClient.CoreWCFClients.INorthwind_dbo_Products_Service>, Northwind_FrontEndCoreWCFClient.CoreWCFClients.INorthwind_dbo_Products_Service
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public Northwind_dbo_Products_ServiceClient() : 
                base(Northwind_dbo_Products_ServiceClient.GetDefaultBinding(), Northwind_dbo_Products_ServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_INorthwind_dbo_Products_Service.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Northwind_dbo_Products_ServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(Northwind_dbo_Products_ServiceClient.GetBindingForEndpoint(endpointConfiguration), Northwind_dbo_Products_ServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Northwind_dbo_Products_ServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(Northwind_dbo_Products_ServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Northwind_dbo_Products_ServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(Northwind_dbo_Products_ServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Northwind_dbo_Products_ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Products_IR[]> GetAllAsync()
        {
            return base.Channel.GetAllAsync();
        }
        
        public System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Products_IR[]> GetByCategoryIDAsync(string categoryID_IR)
        {
            return base.Channel.GetByCategoryIDAsync(categoryID_IR);
        }
        
        public System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Products_IR[]> GetByProductIDAsync(string productID_IR)
        {
            return base.Channel.GetByProductIDAsync(productID_IR);
        }
        
        public System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Products_IR[]> GetByProductNameAsync(string productName)
        {
            return base.Channel.GetByProductNameAsync(productName);
        }
        
        public System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Products_IR[]> GetBySupplierIDAsync(string supplierID_IR)
        {
            return base.Channel.GetBySupplierIDAsync(supplierID_IR);
        }
        
        public System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Products_IR> CreateAsync(Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Products_IR input)
        {
            return base.Channel.CreateAsync(input);
        }
        
        public System.Threading.Tasks.Task UpdateByCategoryIDAsync(string categoryID_IR, Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Products_IR input)
        {
            return base.Channel.UpdateByCategoryIDAsync(categoryID_IR, input);
        }
        
        public System.Threading.Tasks.Task UpdateByProductIDAsync(string productID_IR, Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Products_IR input)
        {
            return base.Channel.UpdateByProductIDAsync(productID_IR, input);
        }
        
        public System.Threading.Tasks.Task UpdateByProductNameAsync(string productName, Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Products_IR input)
        {
            return base.Channel.UpdateByProductNameAsync(productName, input);
        }
        
        public System.Threading.Tasks.Task UpdateBySupplierIDAsync(string supplierID_IR, Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Products_IR input)
        {
            return base.Channel.UpdateBySupplierIDAsync(supplierID_IR, input);
        }
        
        public System.Threading.Tasks.Task DeleteByCategoryIDAsync(string categoryID_IR)
        {
            return base.Channel.DeleteByCategoryIDAsync(categoryID_IR);
        }
        
        public System.Threading.Tasks.Task DeleteByProductIDAsync(string productID_IR)
        {
            return base.Channel.DeleteByProductIDAsync(productID_IR);
        }
        
        public System.Threading.Tasks.Task DeleteByProductNameAsync(string productName)
        {
            return base.Channel.DeleteByProductNameAsync(productName);
        }
        
        public System.Threading.Tasks.Task DeleteBySupplierIDAsync(string supplierID_IR)
        {
            return base.Channel.DeleteBySupplierIDAsync(supplierID_IR);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_INorthwind_dbo_Products_Service))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_INorthwind_dbo_Products_Service))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost:5001/Northwind_dbo_Products_Service");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return Northwind_dbo_Products_ServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_INorthwind_dbo_Products_Service);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return Northwind_dbo_Products_ServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_INorthwind_dbo_Products_Service);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_INorthwind_dbo_Products_Service,
        }
    }
}
