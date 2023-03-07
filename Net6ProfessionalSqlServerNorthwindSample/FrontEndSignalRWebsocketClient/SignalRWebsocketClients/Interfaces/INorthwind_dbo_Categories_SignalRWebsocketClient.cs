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
public interface INorthwind_dbo_Categories_SignalRWebsocketClient
{
	Task<IEnumerable<Northwind_dbo_Categories_IR>?> GetAll();
	Task<IEnumerable<Northwind_dbo_Categories_IR>?> GetByBestMatchedQueryPattern(Northwind_dbo_Categories_IR input);
	Task<IEnumerable<Northwind_dbo_Categories_IR>?> GetByCategoryName(String categoryName);
	Task<IEnumerable<Northwind_dbo_Categories_IR>?> GetByCategoryID(String? categoryID_IR);
	Task<Northwind_dbo_Categories_IR?> Create(Northwind_dbo_Categories_IR input);
	Task UpdateByCategoryName(String categoryName, Northwind_dbo_Categories_IR input);
	Task UpdateByCategoryID(String? categoryID_IR, Northwind_dbo_Categories_IR input);
	Task DeleteByCategoryName(String categoryName);
	Task DeleteByCategoryID(String? categoryID_IR);
    Task InitializeAsync();
    Boolean GetStatus();
    ValueTask DisposeAsync();
}
