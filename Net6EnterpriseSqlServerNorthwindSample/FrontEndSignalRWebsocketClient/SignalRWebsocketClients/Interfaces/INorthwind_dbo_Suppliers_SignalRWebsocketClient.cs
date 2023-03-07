/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Northwind_Common.IndirectReferenceTransformerModels;
namespace Northwind_FrontEndSignalRWebsocketClient.SignalRWebsocketClients;
public interface INorthwind_dbo_Suppliers_SignalRWebsocketClient
{
	Task<IEnumerable<Northwind_dbo_Suppliers_IR>?> GetAll();
	Task<IEnumerable<Northwind_dbo_Suppliers_IR>?> GetByBestMatchedQueryPattern(Northwind_dbo_Suppliers_IR input);
	Task<IEnumerable<Northwind_dbo_Suppliers_IR>?> GetByCompanyName(String companyName);
	Task<IEnumerable<Northwind_dbo_Suppliers_IR>?> GetBySupplierID(String? supplierID_IR);
	Task<IEnumerable<Northwind_dbo_Suppliers_IR>?> GetByPostalCode(String? postalCode);
	Task<Northwind_dbo_Suppliers_IR?> Create(Northwind_dbo_Suppliers_IR input);
	Task UpdateByCompanyName(String companyName, Northwind_dbo_Suppliers_IR input);
	Task UpdateBySupplierID(String? supplierID_IR, Northwind_dbo_Suppliers_IR input);
	Task UpdateByPostalCode(String? postalCode, Northwind_dbo_Suppliers_IR input);
	Task DeleteByCompanyName(String companyName);
	Task DeleteBySupplierID(String? supplierID_IR);
	Task DeleteByPostalCode(String? postalCode);
    Task InitializeAsync();
    Boolean GetStatus();
    ValueTask DisposeAsync();
}
