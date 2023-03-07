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
public class Northwind_dbo_Suppliers_Controller : ControllerBase
{
	private readonly INorthwind_dbo_Suppliers_RequestHandler _requestHandler;
	public Northwind_dbo_Suppliers_Controller(INorthwind_dbo_Suppliers_RequestHandler requestHandler)
	{
		_requestHandler = requestHandler;
	}
	/// <summary>
	/// Get All records of Suppliers table
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Suppliers/GetAll")]
	public async Task<IEnumerable<Northwind_dbo_Suppliers_IR>?> GetAll()
	{
		return await _requestHandler.HandleGetAll();
	}
	/// <summary>
	/// Get record of Suppliers table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Suppliers/GetByCompanyName")]
	public async Task<IEnumerable<Northwind_dbo_Suppliers_IR>?> GetByCompanyName(String companyName)
	{
		return await _requestHandler.HandleGetByCompanyName(companyName);
	}
	/// <summary>
	/// Get record of Suppliers table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Suppliers/GetBySupplierID")]
	public async Task<IEnumerable<Northwind_dbo_Suppliers_IR>?> GetBySupplierID(String? supplierID_IR)
	{
		return await _requestHandler.HandleGetBySupplierID(supplierID_IR);
	}
	/// <summary>
	/// Get record of Suppliers table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Suppliers/GetByPostalCode")]
	public async Task<IEnumerable<Northwind_dbo_Suppliers_IR>?> GetByPostalCode(String? postalCode)
	{
		return await _requestHandler.HandleGetByPostalCode(postalCode);
	}
	/// <summary>
	/// Create and return record of Suppliers table
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPost, Route("Northwind_dbo_Suppliers/Create")]
	public async Task<Northwind_dbo_Suppliers_IR?> Create([FromBody]Northwind_dbo_Suppliers_IR input)
	{
		return await _requestHandler.HandleCreate(input);
	}
	/// <summary>
	/// Update record of Suppliers table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("Northwind_dbo_Suppliers/UpdateByCompanyName")]
	public async Task UpdateByCompanyName(String companyName, [FromBody]Northwind_dbo_Suppliers_IR input)
	{
		await _requestHandler.HandleUpdateByCompanyName(companyName, input);
	}
	/// <summary>
	/// Update record of Suppliers table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("Northwind_dbo_Suppliers/UpdateBySupplierID")]
	public async Task UpdateBySupplierID(String? supplierID_IR, [FromBody]Northwind_dbo_Suppliers_IR input)
	{
		await _requestHandler.HandleUpdateBySupplierID(supplierID_IR, input);
	}
	/// <summary>
	/// Update record of Suppliers table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("Northwind_dbo_Suppliers/UpdateByPostalCode")]
	public async Task UpdateByPostalCode(String? postalCode, [FromBody]Northwind_dbo_Suppliers_IR input)
	{
		await _requestHandler.HandleUpdateByPostalCode(postalCode, input);
	}
	/// <summary>
	/// Delete record of Suppliers table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("Northwind_dbo_Suppliers/DeleteByCompanyName")]
	public async Task DeleteByCompanyName(String companyName)
	{
		await _requestHandler.HandleDeleteByCompanyName(companyName);
	}
	/// <summary>
	/// Delete record of Suppliers table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("Northwind_dbo_Suppliers/DeleteBySupplierID")]
	public async Task DeleteBySupplierID(String? supplierID_IR)
	{
		await _requestHandler.HandleDeleteBySupplierID(supplierID_IR);
	}
	/// <summary>
	/// Delete record of Suppliers table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("Northwind_dbo_Suppliers/DeleteByPostalCode")]
	public async Task DeleteByPostalCode(String? postalCode)
	{
		await _requestHandler.HandleDeleteByPostalCode(postalCode);
	}
}
