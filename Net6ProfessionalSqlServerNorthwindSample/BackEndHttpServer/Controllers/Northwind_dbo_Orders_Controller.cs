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
public class Northwind_dbo_Orders_Controller : ControllerBase
{
	private readonly INorthwind_dbo_Orders_RequestHandler _requestHandler;
	public Northwind_dbo_Orders_Controller(INorthwind_dbo_Orders_RequestHandler requestHandler)
	{
		_requestHandler = requestHandler;
	}
	/// <summary>
	/// Get All records of Orders table
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Orders/GetAll")]
	public async Task<IEnumerable<Northwind_dbo_Orders_IR>?> GetAll()
	{
		return await _requestHandler.HandleGetAll();
	}
	/// <summary>
	/// Get record of Orders table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Orders/GetByCustomerID")]
	public async Task<IEnumerable<Northwind_dbo_Orders_IR>?> GetByCustomerID(String? customerID)
	{
		return await _requestHandler.HandleGetByCustomerID(customerID);
	}
	/// <summary>
	/// Get record of Orders table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Orders/GetByEmployeeID")]
	public async Task<IEnumerable<Northwind_dbo_Orders_IR>?> GetByEmployeeID(String? employeeID_IR)
	{
		return await _requestHandler.HandleGetByEmployeeID(employeeID_IR);
	}
	/// <summary>
	/// Get record of Orders table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Orders/GetByOrderDate")]
	public async Task<IEnumerable<Northwind_dbo_Orders_IR>?> GetByOrderDate(DateTime? orderDate)
	{
		return await _requestHandler.HandleGetByOrderDate(orderDate);
	}
	/// <summary>
	/// Get record of Orders table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Orders/GetByOrderID")]
	public async Task<IEnumerable<Northwind_dbo_Orders_IR>?> GetByOrderID(String? orderID_IR)
	{
		return await _requestHandler.HandleGetByOrderID(orderID_IR);
	}
	/// <summary>
	/// Get record of Orders table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Orders/GetByShippedDate")]
	public async Task<IEnumerable<Northwind_dbo_Orders_IR>?> GetByShippedDate(DateTime? shippedDate)
	{
		return await _requestHandler.HandleGetByShippedDate(shippedDate);
	}
	/// <summary>
	/// Get record of Orders table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Orders/GetByShipVia")]
	public async Task<IEnumerable<Northwind_dbo_Orders_IR>?> GetByShipVia(String? shipVia_IR)
	{
		return await _requestHandler.HandleGetByShipVia(shipVia_IR);
	}
	/// <summary>
	/// Get record of Orders table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Orders/GetByShipPostalCode")]
	public async Task<IEnumerable<Northwind_dbo_Orders_IR>?> GetByShipPostalCode(String? shipPostalCode)
	{
		return await _requestHandler.HandleGetByShipPostalCode(shipPostalCode);
	}
	/// <summary>
	/// Create and return record of Orders table
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPost, Route("Northwind_dbo_Orders/Create")]
	public async Task<Northwind_dbo_Orders_IR?> Create([FromBody]Northwind_dbo_Orders_IR input)
	{
		return await _requestHandler.HandleCreate(input);
	}
	/// <summary>
	/// Update record of Orders table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("Northwind_dbo_Orders/UpdateByCustomerID")]
	public async Task UpdateByCustomerID(String? customerID, [FromBody]Northwind_dbo_Orders_IR input)
	{
		await _requestHandler.HandleUpdateByCustomerID(customerID, input);
	}
	/// <summary>
	/// Update record of Orders table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("Northwind_dbo_Orders/UpdateByEmployeeID")]
	public async Task UpdateByEmployeeID(String? employeeID_IR, [FromBody]Northwind_dbo_Orders_IR input)
	{
		await _requestHandler.HandleUpdateByEmployeeID(employeeID_IR, input);
	}
	/// <summary>
	/// Update record of Orders table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("Northwind_dbo_Orders/UpdateByOrderDate")]
	public async Task UpdateByOrderDate(DateTime? orderDate, [FromBody]Northwind_dbo_Orders_IR input)
	{
		await _requestHandler.HandleUpdateByOrderDate(orderDate, input);
	}
	/// <summary>
	/// Update record of Orders table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("Northwind_dbo_Orders/UpdateByOrderID")]
	public async Task UpdateByOrderID(String? orderID_IR, [FromBody]Northwind_dbo_Orders_IR input)
	{
		await _requestHandler.HandleUpdateByOrderID(orderID_IR, input);
	}
	/// <summary>
	/// Update record of Orders table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("Northwind_dbo_Orders/UpdateByShippedDate")]
	public async Task UpdateByShippedDate(DateTime? shippedDate, [FromBody]Northwind_dbo_Orders_IR input)
	{
		await _requestHandler.HandleUpdateByShippedDate(shippedDate, input);
	}
	/// <summary>
	/// Update record of Orders table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("Northwind_dbo_Orders/UpdateByShipVia")]
	public async Task UpdateByShipVia(String? shipVia_IR, [FromBody]Northwind_dbo_Orders_IR input)
	{
		await _requestHandler.HandleUpdateByShipVia(shipVia_IR, input);
	}
	/// <summary>
	/// Update record of Orders table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("Northwind_dbo_Orders/UpdateByShipPostalCode")]
	public async Task UpdateByShipPostalCode(String? shipPostalCode, [FromBody]Northwind_dbo_Orders_IR input)
	{
		await _requestHandler.HandleUpdateByShipPostalCode(shipPostalCode, input);
	}
	/// <summary>
	/// Delete record of Orders table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("Northwind_dbo_Orders/DeleteByCustomerID")]
	public async Task DeleteByCustomerID(String? customerID)
	{
		await _requestHandler.HandleDeleteByCustomerID(customerID);
	}
	/// <summary>
	/// Delete record of Orders table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("Northwind_dbo_Orders/DeleteByEmployeeID")]
	public async Task DeleteByEmployeeID(String? employeeID_IR)
	{
		await _requestHandler.HandleDeleteByEmployeeID(employeeID_IR);
	}
	/// <summary>
	/// Delete record of Orders table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("Northwind_dbo_Orders/DeleteByOrderDate")]
	public async Task DeleteByOrderDate(DateTime? orderDate)
	{
		await _requestHandler.HandleDeleteByOrderDate(orderDate);
	}
	/// <summary>
	/// Delete record of Orders table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("Northwind_dbo_Orders/DeleteByOrderID")]
	public async Task DeleteByOrderID(String? orderID_IR)
	{
		await _requestHandler.HandleDeleteByOrderID(orderID_IR);
	}
	/// <summary>
	/// Delete record of Orders table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("Northwind_dbo_Orders/DeleteByShippedDate")]
	public async Task DeleteByShippedDate(DateTime? shippedDate)
	{
		await _requestHandler.HandleDeleteByShippedDate(shippedDate);
	}
	/// <summary>
	/// Delete record of Orders table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("Northwind_dbo_Orders/DeleteByShipVia")]
	public async Task DeleteByShipVia(String? shipVia_IR)
	{
		await _requestHandler.HandleDeleteByShipVia(shipVia_IR);
	}
	/// <summary>
	/// Delete record of Orders table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("Northwind_dbo_Orders/DeleteByShipPostalCode")]
	public async Task DeleteByShipPostalCode(String? shipPostalCode)
	{
		await _requestHandler.HandleDeleteByShipPostalCode(shipPostalCode);
	}
}
