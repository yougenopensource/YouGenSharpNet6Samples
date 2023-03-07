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
public class XE_HR_REGIONS_RequestHandler : IXE_HR_REGIONS_RequestHandler
{
    private readonly ILogger<XE_HR_REGIONS_RequestHandler> _logger;
    private readonly IXE_HR_REGIONS_Repository _repository;
    public XE_HR_REGIONS_RequestHandler(
    ILogger<XE_HR_REGIONS_RequestHandler> logger
    ,IXE_HR_REGIONS_Repository repository)
    {
        _logger = logger;
        _repository = repository;
    }
	//Main Handlers
	public async Task<IEnumerable<XE_HR_REGIONS>?> HandleGetAll()
	{
		var retData = await _repository.GetAll();
		return retData;
	}
	public async Task<IEnumerable<XE_HR_REGIONS>?> HandleGetByREGION_ID(Int32 rEGION_ID)
	{
		var retData = await _repository.GetByREGION_ID(rEGION_ID);
		return retData;
	}
	public async Task<XE_HR_REGIONS?> HandleCreate(XE_HR_REGIONS input)
	{
		var results = await _repository.Create(input);
		return results;
	}
	public async Task HandleUpdateByREGION_ID(Int32 rEGION_ID, XE_HR_REGIONS entity)
	{
		await _repository.UpdateByREGION_ID(rEGION_ID, entity);
	}
	public async Task HandleDeleteByREGION_ID(Int32 rEGION_ID)
	{
		await _repository.DeleteByREGION_ID(rEGION_ID);
	}
}