/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202431 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Standard Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using XE_HR_BackEndDatabaseClient.Repositories;
using XE_HR_BackEndSqlEntities.Entities;
namespace XE_HR_BackEndCommon.RequestHandlers;
public class XE_HR_DEPARTMENTS_RequestHandler : IXE_HR_DEPARTMENTS_RequestHandler
{
    private readonly ILogger<XE_HR_DEPARTMENTS_RequestHandler> _logger;
    private readonly IXE_HR_DEPARTMENTS_Repository _repository;
    public XE_HR_DEPARTMENTS_RequestHandler(
    ILogger<XE_HR_DEPARTMENTS_RequestHandler> logger
    ,IXE_HR_DEPARTMENTS_Repository repository)
    {
        _logger = logger;
        _repository = repository;
    }
	//Main Handlers
	public async Task<IEnumerable<XE_HR_DEPARTMENTS>?> HandleGetAll()
	{
		var retData = await _repository.GetAll();
		return retData;
	}
	public async Task<IEnumerable<XE_HR_DEPARTMENTS>?> HandleGetByDEPARTMENT_ID(Int32 dEPARTMENT_ID)
	{
		var retData = await _repository.GetByDEPARTMENT_ID(dEPARTMENT_ID);
		return retData;
	}
	public async Task<IEnumerable<XE_HR_DEPARTMENTS>?> HandleGetByLOCATION_ID(Int32? lOCATION_ID)
	{
		var retData = await _repository.GetByLOCATION_ID(lOCATION_ID);
		return retData;
	}
	public async Task<XE_HR_DEPARTMENTS?> HandleCreate(XE_HR_DEPARTMENTS input)
	{
		var results = await _repository.Create(input);
		return results;
	}
	public async Task HandleUpdateByDEPARTMENT_ID(Int32 dEPARTMENT_ID, XE_HR_DEPARTMENTS entity)
	{
		await _repository.UpdateByDEPARTMENT_ID(dEPARTMENT_ID, entity);
	}
	public async Task HandleUpdateByLOCATION_ID(Int32? lOCATION_ID, XE_HR_DEPARTMENTS entity)
	{
		await _repository.UpdateByLOCATION_ID(lOCATION_ID, entity);
	}
	public async Task HandleDeleteByDEPARTMENT_ID(Int32 dEPARTMENT_ID)
	{
		await _repository.DeleteByDEPARTMENT_ID(dEPARTMENT_ID);
	}
	public async Task HandleDeleteByLOCATION_ID(Int32? lOCATION_ID)
	{
		await _repository.DeleteByLOCATION_ID(lOCATION_ID);
	}
}
