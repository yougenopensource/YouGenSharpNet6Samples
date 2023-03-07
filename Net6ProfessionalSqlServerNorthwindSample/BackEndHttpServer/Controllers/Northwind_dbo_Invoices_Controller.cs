/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Northwind_Common.IndirectReferenceTransformerModels;
using Northwind_BackEndCommon.RequestHandlers;
namespace Northwind_BackEndDatabaseClient.Controllers;
[SwaggerTag(@"Controller Description: N/A")]
[RequireHttps]
public class Northwind_dbo_Invoices_Controller : ControllerBase
{
	private readonly INorthwind_dbo_Invoices_RequestHandler _requestHandler;
	public Northwind_dbo_Invoices_Controller(INorthwind_dbo_Invoices_RequestHandler requestHandler)
	{
		_requestHandler = requestHandler;
	}
	/// <summary>
	/// Get All records of Invoices view
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Invoices/GetAll")]
	public async Task<IEnumerable<Northwind_dbo_Invoices_IR>?> GetAll()
	{
		return await _requestHandler.HandleGetAll();
	}
}
