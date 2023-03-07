/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Northwind_Common.IndirectReferenceTransformerModels;
namespace Northwind_FrontEndSignalRWebsocketClient.SignalRWebsocketClients;
public interface INorthwind_dbo_EmployeeTerritories_SignalRWebsocketClient
{
	Task<IEnumerable<Northwind_dbo_EmployeeTerritories_IR>?> GetAll();
	Task<IEnumerable<Northwind_dbo_EmployeeTerritories_IR>?> GetByBestMatchedQueryPattern(Northwind_dbo_EmployeeTerritories_IR input);
	Task<IEnumerable<Northwind_dbo_EmployeeTerritories_IR>?> GetByEmployeeIDAndTerritoryID(String? employeeID_IR, String territoryID);
	Task<Northwind_dbo_EmployeeTerritories_IR?> Create(Northwind_dbo_EmployeeTerritories_IR input);
	Task UpdateByEmployeeIDAndTerritoryID(String? employeeID_IR, String territoryID, Northwind_dbo_EmployeeTerritories_IR input);
	Task DeleteByEmployeeIDAndTerritoryID(String? employeeID_IR, String territoryID);
    Task InitializeAsync();
    Boolean GetStatus();
    ValueTask DisposeAsync();
}
