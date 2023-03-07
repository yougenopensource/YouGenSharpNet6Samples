/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Northwind_BackEndDatabaseClient.Repositories;
using Northwind_Common.IndirectReferenceTransformerModels;
namespace Northwind_BackEndCommon.RequestHandlers;
public interface INorthwind_dbo_Customers_RequestHandler
{
	//Main Handlers
	Task<IEnumerable<Northwind_dbo_Customers_IR>?> HandleGetAll();
	Task<IEnumerable<Northwind_dbo_Customers_IR>?> HandleGetByCity(String? city);
	Task<IEnumerable<Northwind_dbo_Customers_IR>?> HandleGetByCompanyName(String companyName);
	Task<IEnumerable<Northwind_dbo_Customers_IR>?> HandleGetByCustomerID(String customerID);
	Task<IEnumerable<Northwind_dbo_Customers_IR>?> HandleGetByPostalCode(String? postalCode);
	Task<IEnumerable<Northwind_dbo_Customers_IR>?> HandleGetByRegion(String? region);
	Task<Northwind_dbo_Customers_IR?> HandleCreate<T>(T irModel) where T : Northwind_dbo_Customers_IR;
	Task HandleUpdateByCity<T>(String? city, T irModel) where T: Northwind_dbo_Customers_IR;
	Task HandleUpdateByCompanyName<T>(String companyName, T irModel) where T: Northwind_dbo_Customers_IR;
	Task HandleUpdateByCustomerID<T>(String customerID, T irModel) where T: Northwind_dbo_Customers_IR;
	Task HandleUpdateByPostalCode<T>(String? postalCode, T irModel) where T: Northwind_dbo_Customers_IR;
	Task HandleUpdateByRegion<T>(String? region, T irModel) where T: Northwind_dbo_Customers_IR;
	Task HandleDeleteByCity(String? city);
	Task HandleDeleteByCompanyName(String companyName);
	Task HandleDeleteByCustomerID(String customerID);
	Task HandleDeleteByPostalCode(String? postalCode);
	Task HandleDeleteByRegion(String? region);
}
