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
public class XE_HR_LOCATIONS_Hub : Hub<IXE_HR_LOCATIONS_Hub>
{
	private readonly IXE_HR_LOCATIONS_RequestHandler _requestHandler;
	public XE_HR_LOCATIONS_Hub(IXE_HR_LOCATIONS_RequestHandler requestHandler)
	{
		_requestHandler = requestHandler;
	}
	public async Task<IEnumerable<XE_HR_LOCATIONS_IR>?> GetAll()
	{
		return await _requestHandler.HandleGetAll();
	}
	public async Task<IEnumerable<XE_HR_LOCATIONS_IR>?> GetByCITY(String cITY)
	{
		return await _requestHandler.HandleGetByCITY(cITY);
	}
	public async Task<IEnumerable<XE_HR_LOCATIONS_IR>?> GetByCOUNTRY_ID(String? cOUNTRY_ID)
	{
		return await _requestHandler.HandleGetByCOUNTRY_ID(cOUNTRY_ID);
	}
	public async Task<IEnumerable<XE_HR_LOCATIONS_IR>?> GetByLOCATION_ID(String? lOCATION_ID_IR)
	{
		return await _requestHandler.HandleGetByLOCATION_ID(lOCATION_ID_IR);
	}
	public async Task<IEnumerable<XE_HR_LOCATIONS_IR>?> GetBySTATE_PROVINCE(String? sTATE_PROVINCE)
	{
		return await _requestHandler.HandleGetBySTATE_PROVINCE(sTATE_PROVINCE);
	}
	public async Task<XE_HR_LOCATIONS_IR?> Create(XE_HR_LOCATIONS_IR input)
	{
		return await _requestHandler.HandleCreate(input);
	}
	public async Task UpdateByCITY(String cITY, XE_HR_LOCATIONS_IR input)
	{
		await _requestHandler.HandleUpdateByCITY(cITY, input);
	}
	public async Task UpdateByCOUNTRY_ID(String? cOUNTRY_ID, XE_HR_LOCATIONS_IR input)
	{
		await _requestHandler.HandleUpdateByCOUNTRY_ID(cOUNTRY_ID, input);
	}
	public async Task UpdateByLOCATION_ID(String? lOCATION_ID_IR, XE_HR_LOCATIONS_IR input)
	{
		await _requestHandler.HandleUpdateByLOCATION_ID(lOCATION_ID_IR, input);
	}
	public async Task UpdateBySTATE_PROVINCE(String? sTATE_PROVINCE, XE_HR_LOCATIONS_IR input)
	{
		await _requestHandler.HandleUpdateBySTATE_PROVINCE(sTATE_PROVINCE, input);
	}
	public async Task DeleteByCITY(String cITY)
	{
		await _requestHandler.HandleDeleteByCITY(cITY);
	}
	public async Task DeleteByCOUNTRY_ID(String? cOUNTRY_ID)
	{
		await _requestHandler.HandleDeleteByCOUNTRY_ID(cOUNTRY_ID);
	}
	public async Task DeleteByLOCATION_ID(String? lOCATION_ID_IR)
	{
		await _requestHandler.HandleDeleteByLOCATION_ID(lOCATION_ID_IR);
	}
	public async Task DeleteBySTATE_PROVINCE(String? sTATE_PROVINCE)
	{
		await _requestHandler.HandleDeleteBySTATE_PROVINCE(sTATE_PROVINCE);
	}
}
