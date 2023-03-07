/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195656 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Standard Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_FrontEndHttpClient.HttpClients;
public interface INorthwind_dbo_CustomerCustomerDemo_HttpClient
{
	Task<IEnumerable<Northwind_dbo_CustomerCustomerDemo>?> GetAll();
	Task<IEnumerable<Northwind_dbo_CustomerCustomerDemo>?> GetByCustomerIDAndCustomerTypeID(String customerID, String customerTypeID);
	Task<Northwind_dbo_CustomerCustomerDemo?> Create(Northwind_dbo_CustomerCustomerDemo input);
	Task UpdateByCustomerIDAndCustomerTypeID(String customerID, String customerTypeID, Northwind_dbo_CustomerCustomerDemo input);
	Task DeleteByCustomerIDAndCustomerTypeID(String customerID, String customerTypeID);
}