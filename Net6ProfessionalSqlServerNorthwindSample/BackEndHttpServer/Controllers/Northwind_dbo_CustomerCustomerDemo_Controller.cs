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
public class Northwind_dbo_CustomerCustomerDemo_Controller : ControllerBase
{
	private readonly INorthwind_dbo_CustomerCustomerDemo_RequestHandler _requestHandler;
	public Northwind_dbo_CustomerCustomerDemo_Controller(INorthwind_dbo_CustomerCustomerDemo_RequestHandler requestHandler)
	{
		_requestHandler = requestHandler;
	}
	/// <summary>
	/// Get All records of CustomerCustomerDemo table
	/// </summary>
	[HttpGet, Route("Northwind_dbo_CustomerCustomerDemo/GetAll")]
	public async Task<IEnumerable<Northwind_dbo_CustomerCustomerDemo_IR>?> GetAll()
	{
		return await _requestHandler.HandleGetAll();
	}
	/// <summary>
	/// Get record of CustomerCustomerDemo table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("Northwind_dbo_CustomerCustomerDemo/GetByCustomerIDAndCustomerTypeID")]
	public async Task<IEnumerable<Northwind_dbo_CustomerCustomerDemo_IR>?> GetByCustomerIDAndCustomerTypeID(String customerID, String customerTypeID)
	{
		return await _requestHandler.HandleGetByCustomerIDAndCustomerTypeID(customerID, customerTypeID);
	}
	/// <summary>
	/// Create and return record of CustomerCustomerDemo table
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPost, Route("Northwind_dbo_CustomerCustomerDemo/Create")]
	public async Task<Northwind_dbo_CustomerCustomerDemo_IR?> Create([FromBody]Northwind_dbo_CustomerCustomerDemo_IR input)
	{
		return await _requestHandler.HandleCreate(input);
	}
	/// <summary>
	/// Update record of CustomerCustomerDemo table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("Northwind_dbo_CustomerCustomerDemo/UpdateByCustomerIDAndCustomerTypeID")]
	public async Task UpdateByCustomerIDAndCustomerTypeID(String customerID, String customerTypeID, [FromBody]Northwind_dbo_CustomerCustomerDemo_IR input)
	{
		await _requestHandler.HandleUpdateByCustomerIDAndCustomerTypeID(customerID, customerTypeID, input);
	}
	/// <summary>
	/// Delete record of CustomerCustomerDemo table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("Northwind_dbo_CustomerCustomerDemo/DeleteByCustomerIDAndCustomerTypeID")]
	public async Task DeleteByCustomerIDAndCustomerTypeID(String customerID, String customerTypeID)
	{
		await _requestHandler.HandleDeleteByCustomerIDAndCustomerTypeID(customerID, customerTypeID);
	}
}
