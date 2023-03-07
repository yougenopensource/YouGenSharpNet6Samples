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
public interface INorthwind_dbo_Region_SignalRWebsocketClient
{
	Task<IEnumerable<Northwind_dbo_Region_IR>?> GetAll();
	Task<IEnumerable<Northwind_dbo_Region_IR>?> GetByBestMatchedQueryPattern(Northwind_dbo_Region_IR input);
	Task<IEnumerable<Northwind_dbo_Region_IR>?> GetByRegionID(String? regionID_IR);
	Task<Northwind_dbo_Region_IR?> Create(Northwind_dbo_Region_IR input);
	Task UpdateByRegionID(String? regionID_IR, Northwind_dbo_Region_IR input);
	Task DeleteByRegionID(String? regionID_IR);
    Task InitializeAsync();
    Boolean GetStatus();
    ValueTask DisposeAsync();
}
