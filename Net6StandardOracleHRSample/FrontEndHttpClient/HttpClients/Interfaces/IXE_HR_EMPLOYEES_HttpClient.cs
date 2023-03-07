/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202431 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Standard Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using XE_HR_BackEndSqlEntities.Entities;
namespace XE_HR_FrontEndHttpClient.HttpClients;
public interface IXE_HR_EMPLOYEES_HttpClient
{
	Task<IEnumerable<XE_HR_EMPLOYEES>?> GetAll();
	Task<IEnumerable<XE_HR_EMPLOYEES>?> GetByFIRST_NAMEAndLAST_NAME(String? fIRST_NAME, String lAST_NAME);
	Task<IEnumerable<XE_HR_EMPLOYEES>?> GetByDEPARTMENT_ID(Int32? dEPARTMENT_ID);
	Task<IEnumerable<XE_HR_EMPLOYEES>?> GetByEMAIL(String eMAIL);
	Task<IEnumerable<XE_HR_EMPLOYEES>?> GetByEMPLOYEE_ID(Int32 eMPLOYEE_ID);
	Task<IEnumerable<XE_HR_EMPLOYEES>?> GetByJOB_ID(String jOB_ID);
	Task<IEnumerable<XE_HR_EMPLOYEES>?> GetByMANAGER_ID(Int32? mANAGER_ID);
	Task<XE_HR_EMPLOYEES?> Create(XE_HR_EMPLOYEES input);
	Task UpdateByFIRST_NAMEAndLAST_NAME(String? fIRST_NAME, String lAST_NAME, XE_HR_EMPLOYEES input);
	Task UpdateByDEPARTMENT_ID(Int32? dEPARTMENT_ID, XE_HR_EMPLOYEES input);
	Task UpdateByEMAIL(String eMAIL, XE_HR_EMPLOYEES input);
	Task UpdateByEMPLOYEE_ID(Int32 eMPLOYEE_ID, XE_HR_EMPLOYEES input);
	Task UpdateByJOB_ID(String jOB_ID, XE_HR_EMPLOYEES input);
	Task UpdateByMANAGER_ID(Int32? mANAGER_ID, XE_HR_EMPLOYEES input);
	Task DeleteByFIRST_NAMEAndLAST_NAME(String? fIRST_NAME, String lAST_NAME);
	Task DeleteByDEPARTMENT_ID(Int32? dEPARTMENT_ID);
	Task DeleteByEMAIL(String eMAIL);
	Task DeleteByEMPLOYEE_ID(Int32 eMPLOYEE_ID);
	Task DeleteByJOB_ID(String jOB_ID);
	Task DeleteByMANAGER_ID(Int32? mANAGER_ID);
}
