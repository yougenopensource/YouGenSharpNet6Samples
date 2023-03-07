/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202507 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.SignalR;
using XE_HR_Common.IndirectReferenceTransformerModels;
using XE_HR_BackEndCommon.RequestHandlers;
namespace XE_HR_BackEndSignalRWebsocketServer.Hubs;
public class XE_HR_COUNTRIES_Hub : Hub<IXE_HR_COUNTRIES_Hub>
{
	private readonly IXE_HR_COUNTRIES_RequestHandler _requestHandler;
	public XE_HR_COUNTRIES_Hub(IXE_HR_COUNTRIES_RequestHandler requestHandler)
	{
		_requestHandler = requestHandler;
	}
	public async Task<IEnumerable<XE_HR_COUNTRIES_IR>?> GetAll()
	{
		return await _requestHandler.HandleGetAll();
	}
	public async Task<IEnumerable<XE_HR_COUNTRIES_IR>?> GetByCOUNTRY_ID(String cOUNTRY_ID)
	{
		return await _requestHandler.HandleGetByCOUNTRY_ID(cOUNTRY_ID);
	}
	public async Task<XE_HR_COUNTRIES_IR?> Create(XE_HR_COUNTRIES_IR input)
	{
		return await _requestHandler.HandleCreate(input);
	}
	public async Task UpdateByCOUNTRY_ID(String cOUNTRY_ID, XE_HR_COUNTRIES_IR input)
	{
		await _requestHandler.HandleUpdateByCOUNTRY_ID(cOUNTRY_ID, input);
	}
	public async Task DeleteByCOUNTRY_ID(String cOUNTRY_ID)
	{
		await _requestHandler.HandleDeleteByCOUNTRY_ID(cOUNTRY_ID);
	}
}
