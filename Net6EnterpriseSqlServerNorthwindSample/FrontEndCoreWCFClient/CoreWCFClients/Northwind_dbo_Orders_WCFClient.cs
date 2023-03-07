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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Northwind_FrontEndCoreWCFClient.CoreWCFClients.INorthwind_dbo_Orders_Service")]
    public interface INorthwind_dbo_Orders_Service
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Orders_Service/GetAll", ReplyAction="http://tempuri.org/INorthwind_dbo_Orders_Service/GetAllResponse")]
        System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Orders_Service/GetByCustomerID", ReplyAction="http://tempuri.org/INorthwind_dbo_Orders_Service/GetByCustomerIDResponse")]
        System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR[]> GetByCustomerIDAsync(string customerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Orders_Service/GetByEmployeeID", ReplyAction="http://tempuri.org/INorthwind_dbo_Orders_Service/GetByEmployeeIDResponse")]
        System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR[]> GetByEmployeeIDAsync(string employeeID_IR);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Orders_Service/GetByOrderDate", ReplyAction="http://tempuri.org/INorthwind_dbo_Orders_Service/GetByOrderDateResponse")]
        System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR[]> GetByOrderDateAsync(System.Nullable<System.DateTime> orderDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Orders_Service/GetByOrderID", ReplyAction="http://tempuri.org/INorthwind_dbo_Orders_Service/GetByOrderIDResponse")]
        System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR[]> GetByOrderIDAsync(string orderID_IR);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Orders_Service/GetByShippedDate", ReplyAction="http://tempuri.org/INorthwind_dbo_Orders_Service/GetByShippedDateResponse")]
        System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR[]> GetByShippedDateAsync(System.Nullable<System.DateTime> shippedDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Orders_Service/GetByShipVia", ReplyAction="http://tempuri.org/INorthwind_dbo_Orders_Service/GetByShipViaResponse")]
        System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR[]> GetByShipViaAsync(string shipVia_IR);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Orders_Service/GetByShipPostalCode", ReplyAction="http://tempuri.org/INorthwind_dbo_Orders_Service/GetByShipPostalCodeResponse")]
        System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR[]> GetByShipPostalCodeAsync(string shipPostalCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Orders_Service/Create", ReplyAction="http://tempuri.org/INorthwind_dbo_Orders_Service/CreateResponse")]
        System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR> CreateAsync(Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Orders_Service/UpdateByCustomerID", ReplyAction="http://tempuri.org/INorthwind_dbo_Orders_Service/UpdateByCustomerIDResponse")]
        System.Threading.Tasks.Task UpdateByCustomerIDAsync(string customerID, Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Orders_Service/UpdateByEmployeeID", ReplyAction="http://tempuri.org/INorthwind_dbo_Orders_Service/UpdateByEmployeeIDResponse")]
        System.Threading.Tasks.Task UpdateByEmployeeIDAsync(string employeeID_IR, Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Orders_Service/UpdateByOrderDate", ReplyAction="http://tempuri.org/INorthwind_dbo_Orders_Service/UpdateByOrderDateResponse")]
        System.Threading.Tasks.Task UpdateByOrderDateAsync(System.Nullable<System.DateTime> orderDate, Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Orders_Service/UpdateByOrderID", ReplyAction="http://tempuri.org/INorthwind_dbo_Orders_Service/UpdateByOrderIDResponse")]
        System.Threading.Tasks.Task UpdateByOrderIDAsync(string orderID_IR, Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Orders_Service/UpdateByShippedDate", ReplyAction="http://tempuri.org/INorthwind_dbo_Orders_Service/UpdateByShippedDateResponse")]
        System.Threading.Tasks.Task UpdateByShippedDateAsync(System.Nullable<System.DateTime> shippedDate, Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Orders_Service/UpdateByShipVia", ReplyAction="http://tempuri.org/INorthwind_dbo_Orders_Service/UpdateByShipViaResponse")]
        System.Threading.Tasks.Task UpdateByShipViaAsync(string shipVia_IR, Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Orders_Service/UpdateByShipPostalCode", ReplyAction="http://tempuri.org/INorthwind_dbo_Orders_Service/UpdateByShipPostalCodeResponse")]
        System.Threading.Tasks.Task UpdateByShipPostalCodeAsync(string shipPostalCode, Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Orders_Service/DeleteByCustomerID", ReplyAction="http://tempuri.org/INorthwind_dbo_Orders_Service/DeleteByCustomerIDResponse")]
        System.Threading.Tasks.Task DeleteByCustomerIDAsync(string customerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Orders_Service/DeleteByEmployeeID", ReplyAction="http://tempuri.org/INorthwind_dbo_Orders_Service/DeleteByEmployeeIDResponse")]
        System.Threading.Tasks.Task DeleteByEmployeeIDAsync(string employeeID_IR);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Orders_Service/DeleteByOrderDate", ReplyAction="http://tempuri.org/INorthwind_dbo_Orders_Service/DeleteByOrderDateResponse")]
        System.Threading.Tasks.Task DeleteByOrderDateAsync(System.Nullable<System.DateTime> orderDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Orders_Service/DeleteByOrderID", ReplyAction="http://tempuri.org/INorthwind_dbo_Orders_Service/DeleteByOrderIDResponse")]
        System.Threading.Tasks.Task DeleteByOrderIDAsync(string orderID_IR);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Orders_Service/DeleteByShippedDate", ReplyAction="http://tempuri.org/INorthwind_dbo_Orders_Service/DeleteByShippedDateResponse")]
        System.Threading.Tasks.Task DeleteByShippedDateAsync(System.Nullable<System.DateTime> shippedDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Orders_Service/DeleteByShipVia", ReplyAction="http://tempuri.org/INorthwind_dbo_Orders_Service/DeleteByShipViaResponse")]
        System.Threading.Tasks.Task DeleteByShipViaAsync(string shipVia_IR);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwind_dbo_Orders_Service/DeleteByShipPostalCode", ReplyAction="http://tempuri.org/INorthwind_dbo_Orders_Service/DeleteByShipPostalCodeResponse")]
        System.Threading.Tasks.Task DeleteByShipPostalCodeAsync(string shipPostalCode);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface INorthwind_dbo_Orders_ServiceChannel : Northwind_FrontEndCoreWCFClient.CoreWCFClients.INorthwind_dbo_Orders_Service, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class Northwind_dbo_Orders_ServiceClient : System.ServiceModel.ClientBase<Northwind_FrontEndCoreWCFClient.CoreWCFClients.INorthwind_dbo_Orders_Service>, Northwind_FrontEndCoreWCFClient.CoreWCFClients.INorthwind_dbo_Orders_Service
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public Northwind_dbo_Orders_ServiceClient() : 
                base(Northwind_dbo_Orders_ServiceClient.GetDefaultBinding(), Northwind_dbo_Orders_ServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_INorthwind_dbo_Orders_Service.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Northwind_dbo_Orders_ServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(Northwind_dbo_Orders_ServiceClient.GetBindingForEndpoint(endpointConfiguration), Northwind_dbo_Orders_ServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Northwind_dbo_Orders_ServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(Northwind_dbo_Orders_ServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Northwind_dbo_Orders_ServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(Northwind_dbo_Orders_ServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Northwind_dbo_Orders_ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR[]> GetAllAsync()
        {
            return base.Channel.GetAllAsync();
        }
        
        public System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR[]> GetByCustomerIDAsync(string customerID)
        {
            return base.Channel.GetByCustomerIDAsync(customerID);
        }
        
        public System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR[]> GetByEmployeeIDAsync(string employeeID_IR)
        {
            return base.Channel.GetByEmployeeIDAsync(employeeID_IR);
        }
        
        public System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR[]> GetByOrderDateAsync(System.Nullable<System.DateTime> orderDate)
        {
            return base.Channel.GetByOrderDateAsync(orderDate);
        }
        
        public System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR[]> GetByOrderIDAsync(string orderID_IR)
        {
            return base.Channel.GetByOrderIDAsync(orderID_IR);
        }
        
        public System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR[]> GetByShippedDateAsync(System.Nullable<System.DateTime> shippedDate)
        {
            return base.Channel.GetByShippedDateAsync(shippedDate);
        }
        
        public System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR[]> GetByShipViaAsync(string shipVia_IR)
        {
            return base.Channel.GetByShipViaAsync(shipVia_IR);
        }
        
        public System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR[]> GetByShipPostalCodeAsync(string shipPostalCode)
        {
            return base.Channel.GetByShipPostalCodeAsync(shipPostalCode);
        }
        
        public System.Threading.Tasks.Task<Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR> CreateAsync(Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR input)
        {
            return base.Channel.CreateAsync(input);
        }
        
        public System.Threading.Tasks.Task UpdateByCustomerIDAsync(string customerID, Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR input)
        {
            return base.Channel.UpdateByCustomerIDAsync(customerID, input);
        }
        
        public System.Threading.Tasks.Task UpdateByEmployeeIDAsync(string employeeID_IR, Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR input)
        {
            return base.Channel.UpdateByEmployeeIDAsync(employeeID_IR, input);
        }
        
        public System.Threading.Tasks.Task UpdateByOrderDateAsync(System.Nullable<System.DateTime> orderDate, Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR input)
        {
            return base.Channel.UpdateByOrderDateAsync(orderDate, input);
        }
        
        public System.Threading.Tasks.Task UpdateByOrderIDAsync(string orderID_IR, Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR input)
        {
            return base.Channel.UpdateByOrderIDAsync(orderID_IR, input);
        }
        
        public System.Threading.Tasks.Task UpdateByShippedDateAsync(System.Nullable<System.DateTime> shippedDate, Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR input)
        {
            return base.Channel.UpdateByShippedDateAsync(shippedDate, input);
        }
        
        public System.Threading.Tasks.Task UpdateByShipViaAsync(string shipVia_IR, Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR input)
        {
            return base.Channel.UpdateByShipViaAsync(shipVia_IR, input);
        }
        
        public System.Threading.Tasks.Task UpdateByShipPostalCodeAsync(string shipPostalCode, Northwind_Common.IndirectReferenceTransformerModels.Northwind_dbo_Orders_IR input)
        {
            return base.Channel.UpdateByShipPostalCodeAsync(shipPostalCode, input);
        }
        
        public System.Threading.Tasks.Task DeleteByCustomerIDAsync(string customerID)
        {
            return base.Channel.DeleteByCustomerIDAsync(customerID);
        }
        
        public System.Threading.Tasks.Task DeleteByEmployeeIDAsync(string employeeID_IR)
        {
            return base.Channel.DeleteByEmployeeIDAsync(employeeID_IR);
        }
        
        public System.Threading.Tasks.Task DeleteByOrderDateAsync(System.Nullable<System.DateTime> orderDate)
        {
            return base.Channel.DeleteByOrderDateAsync(orderDate);
        }
        
        public System.Threading.Tasks.Task DeleteByOrderIDAsync(string orderID_IR)
        {
            return base.Channel.DeleteByOrderIDAsync(orderID_IR);
        }
        
        public System.Threading.Tasks.Task DeleteByShippedDateAsync(System.Nullable<System.DateTime> shippedDate)
        {
            return base.Channel.DeleteByShippedDateAsync(shippedDate);
        }
        
        public System.Threading.Tasks.Task DeleteByShipViaAsync(string shipVia_IR)
        {
            return base.Channel.DeleteByShipViaAsync(shipVia_IR);
        }
        
        public System.Threading.Tasks.Task DeleteByShipPostalCodeAsync(string shipPostalCode)
        {
            return base.Channel.DeleteByShipPostalCodeAsync(shipPostalCode);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_INorthwind_dbo_Orders_Service))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_INorthwind_dbo_Orders_Service))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost:5001/Northwind_dbo_Orders_Service");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return Northwind_dbo_Orders_ServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_INorthwind_dbo_Orders_Service);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return Northwind_dbo_Orders_ServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_INorthwind_dbo_Orders_Service);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_INorthwind_dbo_Orders_Service,
        }
    }
}
