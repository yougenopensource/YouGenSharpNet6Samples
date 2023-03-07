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
public class Northwind_dbo_Suppliers_Hub : Hub<INorthwind_dbo_Suppliers_Hub>
{
	private readonly INorthwind_dbo_Suppliers_RequestHandler _requestHandler;
	public Northwind_dbo_Suppliers_Hub(INorthwind_dbo_Suppliers_RequestHandler requestHandler)
	{
		_requestHandler = requestHandler;
	}
	public async Task<IEnumerable<Northwind_dbo_Suppliers_IR>?> GetAll()
	{
		return await _requestHandler.HandleGetAll();
	}
	public async Task<IEnumerable<Northwind_dbo_Suppliers_IR>?> GetByCompanyName(String companyName)
	{
		return await _requestHandler.HandleGetByCompanyName(companyName);
	}
	public async Task<IEnumerable<Northwind_dbo_Suppliers_IR>?> GetBySupplierID(String? supplierID_IR)
	{
		return await _requestHandler.HandleGetBySupplierID(supplierID_IR);
	}
	public async Task<IEnumerable<Northwind_dbo_Suppliers_IR>?> GetByPostalCode(String? postalCode)
	{
		return await _requestHandler.HandleGetByPostalCode(postalCode);
	}
	public async Task<Northwind_dbo_Suppliers_IR?> Create(Northwind_dbo_Suppliers_IR input)
	{
		return await _requestHandler.HandleCreate(input);
	}
	public async Task UpdateByCompanyName(String companyName, Northwind_dbo_Suppliers_IR input)
	{
		await _requestHandler.HandleUpdateByCompanyName(companyName, input);
	}
	public async Task UpdateBySupplierID(String? supplierID_IR, Northwind_dbo_Suppliers_IR input)
	{
		await _requestHandler.HandleUpdateBySupplierID(supplierID_IR, input);
	}
	public async Task UpdateByPostalCode(String? postalCode, Northwind_dbo_Suppliers_IR input)
	{
		await _requestHandler.HandleUpdateByPostalCode(postalCode, input);
	}
	public async Task DeleteByCompanyName(String companyName)
	{
		await _requestHandler.HandleDeleteByCompanyName(companyName);
	}
	public async Task DeleteBySupplierID(String? supplierID_IR)
	{
		await _requestHandler.HandleDeleteBySupplierID(supplierID_IR);
	}
	public async Task DeleteByPostalCode(String? postalCode)
	{
		await _requestHandler.HandleDeleteByPostalCode(postalCode);
	}
}
