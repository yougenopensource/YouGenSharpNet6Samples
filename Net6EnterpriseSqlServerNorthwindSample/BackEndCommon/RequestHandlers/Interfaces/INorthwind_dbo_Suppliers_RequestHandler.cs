/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Northwind_BackEndDatabaseClient.Repositories;
using Northwind_Common.IndirectReferenceTransformerModels;
namespace Northwind_BackEndCommon.RequestHandlers;
public interface INorthwind_dbo_Suppliers_RequestHandler
{
	//Main Handlers
	Task<IEnumerable<Northwind_dbo_Suppliers_IR>?> HandleGetAll();
	Task<IEnumerable<Northwind_dbo_Suppliers_IR>?> HandleGetByCompanyName(String companyName);
	Task<IEnumerable<Northwind_dbo_Suppliers_IR>?> HandleGetBySupplierID(String? supplierID_IR);
	Task<IEnumerable<Northwind_dbo_Suppliers_IR>?> HandleGetByPostalCode(String? postalCode);
	Task<Northwind_dbo_Suppliers_IR?> HandleCreate<T>(T irModel) where T : Northwind_dbo_Suppliers_IR;
	Task HandleUpdateByCompanyName<T>(String companyName, T irModel) where T: Northwind_dbo_Suppliers_IR;
	Task HandleUpdateBySupplierID<T>(String? supplierID_IR, T irModel) where T: Northwind_dbo_Suppliers_IR;
	Task HandleUpdateByPostalCode<T>(String? postalCode, T irModel) where T: Northwind_dbo_Suppliers_IR;
	Task HandleDeleteByCompanyName(String companyName);
	Task HandleDeleteBySupplierID(String? supplierID_IR);
	Task HandleDeleteByPostalCode(String? postalCode);
}
