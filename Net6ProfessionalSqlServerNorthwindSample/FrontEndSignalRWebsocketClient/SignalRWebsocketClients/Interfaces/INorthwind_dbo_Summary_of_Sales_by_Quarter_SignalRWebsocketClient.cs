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
public interface INorthwind_dbo_Summary_of_Sales_by_Quarter_SignalRWebsocketClient
{
	Task<IEnumerable<Northwind_dbo_Summary_of_Sales_by_Quarter_IR>?> GetAll();
	Task<IEnumerable<Northwind_dbo_Summary_of_Sales_by_Quarter_IR>?> GetByBestMatchedQueryPattern(Northwind_dbo_Summary_of_Sales_by_Quarter_IR input);
    Task InitializeAsync();
    Boolean GetStatus();
    ValueTask DisposeAsync();
}
