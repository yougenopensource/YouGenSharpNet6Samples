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
public class Northwind_dbo_CustomerCustomerDemo_Hub : Hub<INorthwind_dbo_CustomerCustomerDemo_Hub>
{
	private readonly INorthwind_dbo_CustomerCustomerDemo_RequestHandler _requestHandler;
	public Northwind_dbo_CustomerCustomerDemo_Hub(INorthwind_dbo_CustomerCustomerDemo_RequestHandler requestHandler)
	{
		_requestHandler = requestHandler;
	}
	public async Task<IEnumerable<Northwind_dbo_CustomerCustomerDemo_IR>?> GetAll()
	{
		return await _requestHandler.HandleGetAll();
	}
	public async Task<IEnumerable<Northwind_dbo_CustomerCustomerDemo_IR>?> GetByCustomerIDAndCustomerTypeID(String customerID, String customerTypeID)
	{
		return await _requestHandler.HandleGetByCustomerIDAndCustomerTypeID(customerID, customerTypeID);
	}
	public async Task<Northwind_dbo_CustomerCustomerDemo_IR?> Create(Northwind_dbo_CustomerCustomerDemo_IR input)
	{
		return await _requestHandler.HandleCreate(input);
	}
	public async Task UpdateByCustomerIDAndCustomerTypeID(String customerID, String customerTypeID, Northwind_dbo_CustomerCustomerDemo_IR input)
	{
		await _requestHandler.HandleUpdateByCustomerIDAndCustomerTypeID(customerID, customerTypeID, input);
	}
	public async Task DeleteByCustomerIDAndCustomerTypeID(String customerID, String customerTypeID)
	{
		await _requestHandler.HandleDeleteByCustomerIDAndCustomerTypeID(customerID, customerTypeID);
	}
}
