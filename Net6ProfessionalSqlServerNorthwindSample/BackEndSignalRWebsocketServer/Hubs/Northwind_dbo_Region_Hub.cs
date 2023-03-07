/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.SignalR;
using Northwind_Common.IndirectReferenceTransformerModels;
using Northwind_BackEndCommon.RequestHandlers;
namespace Northwind_BackEndSignalRWebsocketServer.Hubs;
public class Northwind_dbo_Region_Hub : Hub<INorthwind_dbo_Region_Hub>
{
	private readonly INorthwind_dbo_Region_RequestHandler _requestHandler;
	public Northwind_dbo_Region_Hub(INorthwind_dbo_Region_RequestHandler requestHandler)
	{
		_requestHandler = requestHandler;
	}
	public async Task<IEnumerable<Northwind_dbo_Region_IR>?> GetAll()
	{
		return await _requestHandler.HandleGetAll();
	}
	public async Task<IEnumerable<Northwind_dbo_Region_IR>?> GetByRegionID(String? regionID_IR)
	{
		return await _requestHandler.HandleGetByRegionID(regionID_IR);
	}
	public async Task<Northwind_dbo_Region_IR?> Create(Northwind_dbo_Region_IR input)
	{
		return await _requestHandler.HandleCreate(input);
	}
	public async Task UpdateByRegionID(String? regionID_IR, Northwind_dbo_Region_IR input)
	{
		await _requestHandler.HandleUpdateByRegionID(regionID_IR, input);
	}
	public async Task DeleteByRegionID(String? regionID_IR)
	{
		await _requestHandler.HandleDeleteByRegionID(regionID_IR);
	}
}
