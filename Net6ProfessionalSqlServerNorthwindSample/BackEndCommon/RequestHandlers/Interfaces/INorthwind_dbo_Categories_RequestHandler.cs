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
public interface INorthwind_dbo_Categories_RequestHandler
{
	//Main Handlers
	Task<IEnumerable<Northwind_dbo_Categories_IR>?> HandleGetAll();
	Task<IEnumerable<Northwind_dbo_Categories_IR>?> HandleGetByCategoryName(String categoryName);
	Task<IEnumerable<Northwind_dbo_Categories_IR>?> HandleGetByCategoryID(String? categoryID_IR);
	Task<Northwind_dbo_Categories_IR?> HandleCreate<T>(T irModel) where T : Northwind_dbo_Categories_IR;
	Task HandleUpdateByCategoryName<T>(String categoryName, T irModel) where T: Northwind_dbo_Categories_IR;
	Task HandleUpdateByCategoryID<T>(String? categoryID_IR, T irModel) where T: Northwind_dbo_Categories_IR;
	Task HandleDeleteByCategoryName(String categoryName);
	Task HandleDeleteByCategoryID(String? categoryID_IR);
}
