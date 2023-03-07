/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307201813 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Free Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use for evaluation purposes only. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using XE_HR_BackEndSqlEntities.Entities;
namespace XE_HR_BackEndDatabaseClient.Repositories;
public interface IXE_HR_DEPARTMENTS_Repository : IGenericTableRepository<XE_HR_DEPARTMENTS>
{
	Task<IEnumerable<XE_HR_DEPARTMENTS>?> GetByDEPARTMENT_ID(Int32 dEPARTMENT_ID_);
	Task<IEnumerable<XE_HR_DEPARTMENTS>?> GetByLOCATION_ID(Int32? lOCATION_ID_);
	Task UpdateByDEPARTMENT_ID(Int32 dEPARTMENT_ID_, XE_HR_DEPARTMENTS entity);
	Task UpdateByLOCATION_ID(Int32? lOCATION_ID_, XE_HR_DEPARTMENTS entity);
	Task DeleteByDEPARTMENT_ID(Int32 dEPARTMENT_ID_);
	Task DeleteByLOCATION_ID(Int32? lOCATION_ID_);
}
