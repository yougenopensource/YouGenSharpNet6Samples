/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307201813 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Free Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use for evaluation purposes only. ****
**** This comment block must not be removed. ****
 */
using XE_HR_BackEndSqlEntities.Entities;
namespace XE_HR_FrontEndHttpClient.HttpClients;
public interface IXE_HR_JOB_HISTORY_HttpClient
{
	Task<IEnumerable<XE_HR_JOB_HISTORY>?> GetAll();
	Task<IEnumerable<XE_HR_JOB_HISTORY>?> GetByEMPLOYEE_IDAndSTART_DATE(Int32 eMPLOYEE_ID, DateTime sTART_DATE);
	Task<IEnumerable<XE_HR_JOB_HISTORY>?> GetByDEPARTMENT_ID(Int32? dEPARTMENT_ID);
	Task<IEnumerable<XE_HR_JOB_HISTORY>?> GetByEMPLOYEE_ID(Int32 eMPLOYEE_ID);
	Task<IEnumerable<XE_HR_JOB_HISTORY>?> GetByJOB_ID(String jOB_ID);
	Task<XE_HR_JOB_HISTORY?> Create(XE_HR_JOB_HISTORY input);
	Task UpdateByEMPLOYEE_IDAndSTART_DATE(Int32 eMPLOYEE_ID, DateTime sTART_DATE, XE_HR_JOB_HISTORY input);
	Task UpdateByDEPARTMENT_ID(Int32? dEPARTMENT_ID, XE_HR_JOB_HISTORY input);
	Task UpdateByEMPLOYEE_ID(Int32 eMPLOYEE_ID, XE_HR_JOB_HISTORY input);
	Task UpdateByJOB_ID(String jOB_ID, XE_HR_JOB_HISTORY input);
	Task DeleteByEMPLOYEE_IDAndSTART_DATE(Int32 eMPLOYEE_ID, DateTime sTART_DATE);
	Task DeleteByDEPARTMENT_ID(Int32? dEPARTMENT_ID);
	Task DeleteByEMPLOYEE_ID(Int32 eMPLOYEE_ID);
	Task DeleteByJOB_ID(String jOB_ID);
}
