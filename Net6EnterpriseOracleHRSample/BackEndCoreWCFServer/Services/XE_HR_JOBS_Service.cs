/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202605 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using XE_HR_Common.IndirectReferenceTransformerModels;
using XE_HR_BackEndCommon.RequestHandlers;
namespace XE_HR_BackEndCoreWCFServer.Services;
public partial class XE_HR_JOBS_Service : IXE_HR_JOBS_Service
{
	private readonly IXE_HR_JOBS_RequestHandler _requestHandler;
	public XE_HR_JOBS_Service(IXE_HR_JOBS_RequestHandler requestHandler)
	{
		_requestHandler = requestHandler;
	}
	public async Task<IEnumerable<XE_HR_JOBS_IR>?> GetAll()
	{
		return await _requestHandler.HandleGetAll();
	}
	public async Task<IEnumerable<XE_HR_JOBS_IR>?> GetByJOB_ID(String jOB_ID)
	{
		return await _requestHandler.HandleGetByJOB_ID(jOB_ID);
	}
	public async Task<XE_HR_JOBS_IR?> Create(XE_HR_JOBS_IR input)
	{
		return await _requestHandler.HandleCreate(input);
	}
	public async Task UpdateByJOB_ID(String jOB_ID, XE_HR_JOBS_IR input)
	{
		await _requestHandler.HandleUpdateByJOB_ID(jOB_ID, input);
	}
	public async Task DeleteByJOB_ID(String jOB_ID)
	{
		await _requestHandler.HandleDeleteByJOB_ID(jOB_ID);
	}
}
