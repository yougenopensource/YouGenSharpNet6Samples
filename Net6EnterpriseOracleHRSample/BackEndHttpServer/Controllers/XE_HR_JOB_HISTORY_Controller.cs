/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202605 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using XE_HR_Common.IndirectReferenceTransformerModels;
using XE_HR_BackEndCommon.RequestHandlers;
namespace XE_HR_BackEndDatabaseClient.Controllers;
[SwaggerTag(@"Controller Description: Table that stores job history of the employees. If an employee changes departments within the job or changes jobs within the department, new rows get inserted into this table with old job information of the employee. Contains a complex primary key: employee_id+start_date.Contains 25 rows. References with jobs, employees, and departments tables.")]
[RequireHttps]
public class XE_HR_JOB_HISTORY_Controller : ControllerBase
{
	private readonly IXE_HR_JOB_HISTORY_RequestHandler _requestHandler;
	public XE_HR_JOB_HISTORY_Controller(IXE_HR_JOB_HISTORY_RequestHandler requestHandler)
	{
		_requestHandler = requestHandler;
	}
	/// <summary>
	/// Get All records of JOB_HISTORY table
	/// </summary>
	[HttpGet, Route("XE_HR_JOB_HISTORY/GetAll")]
	public async Task<IEnumerable<XE_HR_JOB_HISTORY_IR>?> GetAll()
	{
		return await _requestHandler.HandleGetAll();
	}
	/// <summary>
	/// Get record of JOB_HISTORY table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("XE_HR_JOB_HISTORY/GetByEMPLOYEE_IDAndSTART_DATE")]
	public async Task<IEnumerable<XE_HR_JOB_HISTORY_IR>?> GetByEMPLOYEE_IDAndSTART_DATE(String? eMPLOYEE_ID_IR, DateTime sTART_DATE)
	{
		return await _requestHandler.HandleGetByEMPLOYEE_IDAndSTART_DATE(eMPLOYEE_ID_IR, sTART_DATE);
	}
	/// <summary>
	/// Get record of JOB_HISTORY table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("XE_HR_JOB_HISTORY/GetByDEPARTMENT_ID")]
	public async Task<IEnumerable<XE_HR_JOB_HISTORY_IR>?> GetByDEPARTMENT_ID(String? dEPARTMENT_ID_IR)
	{
		return await _requestHandler.HandleGetByDEPARTMENT_ID(dEPARTMENT_ID_IR);
	}
	/// <summary>
	/// Get record of JOB_HISTORY table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("XE_HR_JOB_HISTORY/GetByEMPLOYEE_ID")]
	public async Task<IEnumerable<XE_HR_JOB_HISTORY_IR>?> GetByEMPLOYEE_ID(String? eMPLOYEE_ID_IR)
	{
		return await _requestHandler.HandleGetByEMPLOYEE_ID(eMPLOYEE_ID_IR);
	}
	/// <summary>
	/// Get record of JOB_HISTORY table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("XE_HR_JOB_HISTORY/GetByJOB_ID")]
	public async Task<IEnumerable<XE_HR_JOB_HISTORY_IR>?> GetByJOB_ID(String jOB_ID)
	{
		return await _requestHandler.HandleGetByJOB_ID(jOB_ID);
	}
	/// <summary>
	/// Create and return record of JOB_HISTORY table
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPost, Route("XE_HR_JOB_HISTORY/Create")]
	public async Task<XE_HR_JOB_HISTORY_IR?> Create([FromBody]XE_HR_JOB_HISTORY_IR input)
	{
		return await _requestHandler.HandleCreate(input);
	}
	/// <summary>
	/// Update record of JOB_HISTORY table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("XE_HR_JOB_HISTORY/UpdateByEMPLOYEE_IDAndSTART_DATE")]
	public async Task UpdateByEMPLOYEE_IDAndSTART_DATE(String? eMPLOYEE_ID_IR, DateTime sTART_DATE, [FromBody]XE_HR_JOB_HISTORY_IR input)
	{
		await _requestHandler.HandleUpdateByEMPLOYEE_IDAndSTART_DATE(eMPLOYEE_ID_IR, sTART_DATE, input);
	}
	/// <summary>
	/// Update record of JOB_HISTORY table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("XE_HR_JOB_HISTORY/UpdateByDEPARTMENT_ID")]
	public async Task UpdateByDEPARTMENT_ID(String? dEPARTMENT_ID_IR, [FromBody]XE_HR_JOB_HISTORY_IR input)
	{
		await _requestHandler.HandleUpdateByDEPARTMENT_ID(dEPARTMENT_ID_IR, input);
	}
	/// <summary>
	/// Update record of JOB_HISTORY table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("XE_HR_JOB_HISTORY/UpdateByEMPLOYEE_ID")]
	public async Task UpdateByEMPLOYEE_ID(String? eMPLOYEE_ID_IR, [FromBody]XE_HR_JOB_HISTORY_IR input)
	{
		await _requestHandler.HandleUpdateByEMPLOYEE_ID(eMPLOYEE_ID_IR, input);
	}
	/// <summary>
	/// Update record of JOB_HISTORY table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("XE_HR_JOB_HISTORY/UpdateByJOB_ID")]
	public async Task UpdateByJOB_ID(String jOB_ID, [FromBody]XE_HR_JOB_HISTORY_IR input)
	{
		await _requestHandler.HandleUpdateByJOB_ID(jOB_ID, input);
	}
	/// <summary>
	/// Delete record of JOB_HISTORY table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("XE_HR_JOB_HISTORY/DeleteByEMPLOYEE_IDAndSTART_DATE")]
	public async Task DeleteByEMPLOYEE_IDAndSTART_DATE(String? eMPLOYEE_ID_IR, DateTime sTART_DATE)
	{
		await _requestHandler.HandleDeleteByEMPLOYEE_IDAndSTART_DATE(eMPLOYEE_ID_IR, sTART_DATE);
	}
	/// <summary>
	/// Delete record of JOB_HISTORY table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("XE_HR_JOB_HISTORY/DeleteByDEPARTMENT_ID")]
	public async Task DeleteByDEPARTMENT_ID(String? dEPARTMENT_ID_IR)
	{
		await _requestHandler.HandleDeleteByDEPARTMENT_ID(dEPARTMENT_ID_IR);
	}
	/// <summary>
	/// Delete record of JOB_HISTORY table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("XE_HR_JOB_HISTORY/DeleteByEMPLOYEE_ID")]
	public async Task DeleteByEMPLOYEE_ID(String? eMPLOYEE_ID_IR)
	{
		await _requestHandler.HandleDeleteByEMPLOYEE_ID(eMPLOYEE_ID_IR);
	}
	/// <summary>
	/// Delete record of JOB_HISTORY table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("XE_HR_JOB_HISTORY/DeleteByJOB_ID")]
	public async Task DeleteByJOB_ID(String jOB_ID)
	{
		await _requestHandler.HandleDeleteByJOB_ID(jOB_ID);
	}
}
