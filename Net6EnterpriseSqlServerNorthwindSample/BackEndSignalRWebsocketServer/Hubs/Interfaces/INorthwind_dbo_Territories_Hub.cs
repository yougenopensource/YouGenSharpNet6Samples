/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Northwind_Common.IndirectReferenceTransformerModels;
namespace Northwind_BackEndSignalRWebsocketServer.Hubs;
public interface INorthwind_dbo_Territories_Hub
{
	Task<IEnumerable<Northwind_dbo_Territories_IR>?> HandleGeAll();
	Task<IEnumerable<Northwind_dbo_Territories_IR>?> GetByTerritoryID(String territoryID);
	Task<Northwind_dbo_Territories_IR?> HandleCreate(Northwind_dbo_Territories_IR input);
	Task UpdateByTerritoryID(String territoryID, Northwind_dbo_Territories_IR input);
	Task DeleteByTerritoryID(String territoryID);
}
