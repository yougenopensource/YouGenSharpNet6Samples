/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202431 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Standard Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using XE_HR_BackEndSqlEntities.Entities;
using XE_HR_BackEndCommon.RequestHandlers;
namespace XE_HR_BackEndDatabaseClient.Controllers;
[SwaggerTag(@"Controller Description: N/A")]
[RequireHttps]
public class XE_HR_EMP_DETAILS_VIEW_Controller : ControllerBase
{
	private readonly IXE_HR_EMP_DETAILS_VIEW_RequestHandler _requestHandler;
	public XE_HR_EMP_DETAILS_VIEW_Controller(IXE_HR_EMP_DETAILS_VIEW_RequestHandler requestHandler)
	{
		_requestHandler = requestHandler;
	}
	/// <summary>
	/// Get All records of EMP_DETAILS_VIEW view
	/// </summary>
	[HttpGet, Route("XE_HR_EMP_DETAILS_VIEW/GetAll")]
	public async Task<IEnumerable<XE_HR_EMP_DETAILS_VIEW>?> GetAll()
	{
		return await _requestHandler.HandleGetAll();
	}
}
