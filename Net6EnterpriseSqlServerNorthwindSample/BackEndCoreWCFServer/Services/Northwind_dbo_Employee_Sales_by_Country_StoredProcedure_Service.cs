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
public partial class Northwind_dbo_Employee_Sales_by_Country_StoredProcedure_Service : INorthwind_dbo_Employee_Sales_by_Country_StoredProcedure_Service
{
	private readonly INorthwind_dbo_Employee_Sales_by_Country_StoredProcedure_RequestHandler _requestHandler;
	public Northwind_dbo_Employee_Sales_by_Country_StoredProcedure_Service(INorthwind_dbo_Employee_Sales_by_Country_StoredProcedure_RequestHandler requestHandler)
	{
		_requestHandler = requestHandler;
	}
	public async Task<IEnumerable<Northwind_dbo_Employee_Sales_by_Country_OM_IR>?> Call_Northwind_dbo_Employee_Sales_by_Country(Northwind_dbo_Employee_Sales_by_Country_IM_IR input)
	{
		return await _requestHandler.HandleCall_Northwind_dbo_Employee_Sales_by_Country(input);
	}
}
