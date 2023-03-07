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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Northwind_FrontEndCoreWCFClient.CoreWCFClients.INorthwind_dbo_Suppliers_Service")]
    public interface INorthwind_dbo_Suppliers_Service
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Suppliers_Service/GetAll", ReplyAction="http://tempuri.org/INorthwind_dbo_Suppliers_Service/GetAllResponse")]
        System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Suppliers_IR[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Suppliers_Service/GetByCompanyName", ReplyAction="http://tempuri.org/INorthwind_dbo_Suppliers_Service/GetByCompanyNameResponse")]
        System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Suppliers_IR[]> GetByCompanyNameAsync(string companyName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Suppliers_Service/GetBySupplierID", ReplyAction="http://tempuri.org/INorthwind_dbo_Suppliers_Service/GetBySupplierIDResponse")]
        System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Suppliers_IR[]> GetBySupplierIDAsync(string supplierID_IR);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Suppliers_Service/GetByPostalCode", ReplyAction="http://tempuri.org/INorthwind_dbo_Suppliers_Service/GetByPostalCodeResponse")]
        System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Suppliers_IR[]> GetByPostalCodeAsync(string postalCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Suppliers_Service/Create", ReplyAction="http://tempuri.org/INorthwind_dbo_Suppliers_Service/CreateResponse")]
        System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Suppliers_IR> CreateAsync(Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Suppliers_IR input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Suppliers_Service/UpdateByCompanyName", ReplyAction="http://tempuri.org/INorthwind_dbo_Suppliers_Service/UpdateByCompanyNameResponse")]
        System.Threading.Tasks.Task UpdateByCompanyNameAsync(string companyName, Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Suppliers_IR input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Suppliers_Service/UpdateBySupplierID", ReplyAction="http://tempuri.org/INorthwind_dbo_Suppliers_Service/UpdateBySupplierIDResponse")]
        System.Threading.Tasks.Task UpdateBySupplierIDAsync(string supplierID_IR, Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Suppliers_IR input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Suppliers_Service/UpdateByPostalCode", ReplyAction="http://tempuri.org/INorthwind_dbo_Suppliers_Service/UpdateByPostalCodeResponse")]
        System.Threading.Tasks.Task UpdateByPostalCodeAsync(string postalCode, Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Suppliers_IR input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Suppliers_Service/DeleteByCompanyName", ReplyAction="http://tempuri.org/INorthwind_dbo_Suppliers_Service/DeleteByCompanyNameResponse")]
        System.Threading.Tasks.Task DeleteByCompanyNameAsync(string companyName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Suppliers_Service/DeleteBySupplierID", ReplyAction="http://tempuri.org/INorthwind_dbo_Suppliers_Service/DeleteBySupplierIDResponse")]
        System.Threading.Tasks.Task DeleteBySupplierIDAsync(string supplierID_IR);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Suppliers_Service/DeleteByPostalCode", ReplyAction="http://tempuri.org/INorthwind_dbo_Suppliers_Service/DeleteByPostalCodeResponse")]
        System.Threading.Tasks.Task DeleteByPostalCodeAsync(string postalCode);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface INorthwind_dbo_Suppliers_ServiceChannel : Northwind_FrontEndCoreWCFClient.CoreWCFClients.INorthwind_dbo_Suppliers_Service, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class Northwind_dbo_Suppliers_ServiceClient : System.ServiceModel.ClientBase<Northwind_FrontEndCoreWCFClient.CoreWCFClients.INorthwind_dbo_Suppliers_Service>, Northwind_FrontEndCoreWCFClient.CoreWCFClients.INorthwind_dbo_Suppliers_Service
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public Northwind_dbo_Suppliers_ServiceClient() : 
                base(Northwind_dbo_Suppliers_ServiceClient.GetDefaultBinding(), Northwind_dbo_Suppliers_ServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_INorthwind_dbo_Suppliers_Service.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Northwind_dbo_Suppliers_ServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(Northwind_dbo_Suppliers_ServiceClient.GetBindingForEndpoint(endpointConfiguration), Northwind_dbo_Suppliers_ServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Northwind_dbo_Suppliers_ServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(Northwind_dbo_Suppliers_ServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Northwind_dbo_Suppliers_ServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(Northwind_dbo_Suppliers_ServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Northwind_dbo_Suppliers_ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Suppliers_IR[]> GetAllAsync()
        {
            return base.Channel.GetAllAsync();
        }
        
        public System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Suppliers_IR[]> GetByCompanyNameAsync(string companyName)
        {
            return base.Channel.GetByCompanyNameAsync(companyName);
        }
        
        public System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Suppliers_IR[]> GetBySupplierIDAsync(string supplierID_IR)
        {
            return base.Channel.GetBySupplierIDAsync(supplierID_IR);
        }
        
        public System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Suppliers_IR[]> GetByPostalCodeAsync(string postalCode)
        {
            return base.Channel.GetByPostalCodeAsync(postalCode);
        }
        
        public System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Suppliers_IR> CreateAsync(Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Suppliers_IR input)
        {
            return base.Channel.CreateAsync(input);
        }
        
        public System.Threading.Tasks.Task UpdateByCompanyNameAsync(string companyName, Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Suppliers_IR input)
        {
            return base.Channel.UpdateByCompanyNameAsync(companyName, input);
        }
        
        public System.Threading.Tasks.Task UpdateBySupplierIDAsync(string supplierID_IR, Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Suppliers_IR input)
        {
            return base.Channel.UpdateBySupplierIDAsync(supplierID_IR, input);
        }
        
        public System.Threading.Tasks.Task UpdateByPostalCodeAsync(string postalCode, Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Suppliers_IR input)
        {
            return base.Channel.UpdateByPostalCodeAsync(postalCode, input);
        }
        
        public System.Threading.Tasks.Task DeleteByCompanyNameAsync(string companyName)
        {
            return base.Channel.DeleteByCompanyNameAsync(companyName);
        }
        
        public System.Threading.Tasks.Task DeleteBySupplierIDAsync(string supplierID_IR)
        {
            return base.Channel.DeleteBySupplierIDAsync(supplierID_IR);
        }
        
        public System.Threading.Tasks.Task DeleteByPostalCodeAsync(string postalCode)
        {
            return base.Channel.DeleteByPostalCodeAsync(postalCode);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_INorthwind_dbo_Suppliers_Service))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_INorthwind_dbo_Suppliers_Service))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost:5001/Northwind_dbo_Suppliers_Service");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return Northwind_dbo_Suppliers_ServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_INorthwind_dbo_Suppliers_Service);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return Northwind_dbo_Suppliers_ServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_INorthwind_dbo_Suppliers_Service);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_INorthwind_dbo_Suppliers_Service,
        }
    }
}