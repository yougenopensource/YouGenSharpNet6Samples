/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195435 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Free Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use for evaluation purposes only. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Northwind_BackEndDatabaseClient.Repositories;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndCommon.RequestHandlers;
public interface INorthwind_dbo_Territories_RequestHandler
{
	//Main Handlers
	Task<IEnumerable<Northwind_dbo_Territories>?> HandleGetAll();
	Task<IEnumerable<Northwind_dbo_Territories>?> HandleGetByTerritoryID(String territoryID);
	Task<Northwind_dbo_Territories?> HandleCreate(Northwind_dbo_Territories entity);
	Task HandleUpdateByTerritoryID(String territoryID, Northwind_dbo_Territories entity);
	Task HandleDeleteByTerritoryID(String territoryID);
}
