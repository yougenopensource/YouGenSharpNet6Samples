/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Northwind_Common.IndirectReferenceTransformerModels;
using Northwind_BackEndCommon.RequestHandlers;
namespace Northwind_BackEndCoreWCFServer.Services;
public partial class Northwind_dbo_Shippers_Service : INorthwind_dbo_Shippers_Service
{
	private readonly INorthwind_dbo_Shippers_RequestHandler _requestHandler;
	public Northwind_dbo_Shippers_Service(INorthwind_dbo_Shippers_RequestHandler requestHandler)
	{
		_requestHandler = requestHandler;
	}
	public async Task<IEnumerable<Northwind_dbo_Shippers_IR>?> GetAll()
	{
		return await _requestHandler.HandleGetAll();
	}
	public async Task<IEnumerable<Northwind_dbo_Shippers_IR>?> GetByShipperID(String? shipperID_IR)
	{
		return await _requestHandler.HandleGetByShipperID(shipperID_IR);
	}
	public async Task<Northwind_dbo_Shippers_IR?> Create(Northwind_dbo_Shippers_IR input)
	{
		return await _requestHandler.HandleCreate(input);
	}
	public async Task UpdateByShipperID(String? shipperID_IR, Northwind_dbo_Shippers_IR input)
	{
		await _requestHandler.HandleUpdateByShipperID(shipperID_IR, input);
	}
	public async Task DeleteByShipperID(String? shipperID_IR)
	{
		await _requestHandler.HandleDeleteByShipperID(shipperID_IR);
	}
}
