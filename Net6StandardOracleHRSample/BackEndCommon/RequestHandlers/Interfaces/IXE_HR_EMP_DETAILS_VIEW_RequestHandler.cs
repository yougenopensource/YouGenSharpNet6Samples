/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202431 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Standard Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using XE_HR_BackEndDatabaseClient.Repositories;
using XE_HR_BackEndSqlEntities.Entities;
namespace XE_HR_BackEndCommon.RequestHandlers;
public interface IXE_HR_EMP_DETAILS_VIEW_RequestHandler
{
	//Main Handlers
	Task<IEnumerable<XE_HR_EMP_DETAILS_VIEW>?> HandleGetAll();
}
