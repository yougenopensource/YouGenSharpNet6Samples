/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195656 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Standard Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Northwind_BackEndSqlEntities.Entities;
using Northwind_BackEndCommon.RequestHandlers;
namespace Northwind_BackEndDatabaseClient.Controllers;
[SwaggerTag(@"Controller Description: N/A")]
[RequireHttps]
public class Northwind_dbo_Sales_Totals_by_Amount_Controller : ControllerBase
{
	private readonly INorthwind_dbo_Sales_Totals_by_Amount_RequestHandler _requestHandler;
	public Northwind_dbo_Sales_Totals_by_Amount_Controller(INorthwind_dbo_Sales_Totals_by_Amount_RequestHandler requestHandler)
	{
		_requestHandler = requestHandler;
	}
	/// <summary>
	/// Get All records of Sales_Totals_by_Amount view
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Sales_Totals_by_Amount/GetAll")]
	public async Task<IEnumerable<Northwind_dbo_Sales_Totals_by_Amount>?> GetAll()
	{
		return await _requestHandler.HandleGetAll();
	}
}
