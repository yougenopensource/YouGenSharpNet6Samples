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
public partial class Northwind_dbo_Product_Sales_for_1997_Service : INorthwind_dbo_Product_Sales_for_1997_Service
{
	private readonly INorthwind_dbo_Product_Sales_for_1997_RequestHandler _requestHandler;
	public Northwind_dbo_Product_Sales_for_1997_Service(INorthwind_dbo_Product_Sales_for_1997_RequestHandler requestHandler)
	{
		_requestHandler = requestHandler;
	}
	public async Task<IEnumerable<Northwind_dbo_Product_Sales_for_1997_IR>?> GetAll()
	{
		return await _requestHandler.HandleGetAll();
	}
}
