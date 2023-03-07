/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195435 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Free Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use for evaluation purposes only. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Northwind_BackEndSqlEntities.Entities;
using Northwind_BackEndCommon.RequestHandlers;
namespace Northwind_BackEndDatabaseClient.Controllers;
[SwaggerTag(@"Controller Description: N/A")]
[RequireHttps]
public class Northwind_dbo_CustomerDemographics_Controller : ControllerBase
{
	private readonly INorthwind_dbo_CustomerDemographics_RequestHandler _requestHandler;
	public Northwind_dbo_CustomerDemographics_Controller(INorthwind_dbo_CustomerDemographics_RequestHandler requestHandler)
	{
		_requestHandler = requestHandler;
	}
	/// <summary>
	/// Get All records of CustomerDemographics table
	/// </summary>
	[HttpGet, Route("Northwind_dbo_CustomerDemographics/GetAll")]
	public async Task<IEnumerable<Northwind_dbo_CustomerDemographics>?> GetAll()
	{
		return await _requestHandler.HandleGetAll();
	}
	/// <summary>
	/// Get record of CustomerDemographics table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("Northwind_dbo_CustomerDemographics/GetByCustomerTypeID")]
	public async Task<IEnumerable<Northwind_dbo_CustomerDemographics>?> GetByCustomerTypeID(String customerTypeID)
	{
		return await _requestHandler.HandleGetByCustomerTypeID(customerTypeID);
	}
	/// <summary>
	/// Create and return record of CustomerDemographics table
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPost, Route("Northwind_dbo_CustomerDemographics/Create")]
	public async Task<Northwind_dbo_CustomerDemographics?> Create([FromBody]Northwind_dbo_CustomerDemographics input)
	{
		return await _requestHandler.HandleCreate(input);
	}
	/// <summary>
	/// Update record of CustomerDemographics table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("Northwind_dbo_CustomerDemographics/UpdateByCustomerTypeID")]
	public async Task UpdateByCustomerTypeID(String customerTypeID, [FromBody]Northwind_dbo_CustomerDemographics input)
	{
		await _requestHandler.HandleUpdateByCustomerTypeID(customerTypeID, input);
	}
	/// <summary>
	/// Delete record of CustomerDemographics table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("Northwind_dbo_CustomerDemographics/DeleteByCustomerTypeID")]
	public async Task DeleteByCustomerTypeID(String customerTypeID)
	{
		await _requestHandler.HandleDeleteByCustomerTypeID(customerTypeID);
	}
}
