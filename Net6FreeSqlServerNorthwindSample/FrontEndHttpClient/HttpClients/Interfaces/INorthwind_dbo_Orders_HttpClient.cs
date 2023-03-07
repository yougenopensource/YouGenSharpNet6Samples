/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195435 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Free Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use for evaluation purposes only. ****
**** This comment block must not be removed. ****
 */
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_FrontEndHttpClient.HttpClients;
public interface INorthwind_dbo_Orders_HttpClient
{
	Task<IEnumerable<Northwind_dbo_Orders>?> GetAll();
	Task<IEnumerable<Northwind_dbo_Orders>?> GetByCustomerID(String? customerID);
	Task<IEnumerable<Northwind_dbo_Orders>?> GetByEmployeeID(Int32? employeeID);
	Task<IEnumerable<Northwind_dbo_Orders>?> GetByOrderDate(DateTime? orderDate);
	Task<IEnumerable<Northwind_dbo_Orders>?> GetByOrderID(Int32 orderID);
	Task<IEnumerable<Northwind_dbo_Orders>?> GetByShippedDate(DateTime? shippedDate);
	Task<IEnumerable<Northwind_dbo_Orders>?> GetByShipVia(Int32? shipVia);
	Task<IEnumerable<Northwind_dbo_Orders>?> GetByShipPostalCode(String? shipPostalCode);
	Task<Northwind_dbo_Orders?> Create(Northwind_dbo_Orders input);
	Task UpdateByCustomerID(String? customerID, Northwind_dbo_Orders input);
	Task UpdateByEmployeeID(Int32? employeeID, Northwind_dbo_Orders input);
	Task UpdateByOrderDate(DateTime? orderDate, Northwind_dbo_Orders input);
	Task UpdateByOrderID(Int32 orderID, Northwind_dbo_Orders input);
	Task UpdateByShippedDate(DateTime? shippedDate, Northwind_dbo_Orders input);
	Task UpdateByShipVia(Int32? shipVia, Northwind_dbo_Orders input);
	Task UpdateByShipPostalCode(String? shipPostalCode, Northwind_dbo_Orders input);
	Task DeleteByCustomerID(String? customerID);
	Task DeleteByEmployeeID(Int32? employeeID);
	Task DeleteByOrderDate(DateTime? orderDate);
	Task DeleteByOrderID(Int32 orderID);
	Task DeleteByShippedDate(DateTime? shippedDate);
	Task DeleteByShipVia(Int32? shipVia);
	Task DeleteByShipPostalCode(String? shipPostalCode);
}
