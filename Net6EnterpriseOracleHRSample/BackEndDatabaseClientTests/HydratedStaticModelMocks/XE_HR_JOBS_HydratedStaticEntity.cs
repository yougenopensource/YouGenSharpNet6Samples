/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202605 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using XE_HR_BackEndSqlEntities.Entities;
namespace XE_HR_BackEndDatabaseClientTests.HydratedStaticEntities;
public partial class XE_HR_HydratedStaticEntities 
{
	public XE_HR_JOBS GetHydratedStaticXE_HR_JOBS(Boolean fillPrimaryKey = false)
	{
		var retObj = new XE_HR_JOBS();
		retObj.JOB_ID = (fillPrimaryKey ? "ee7b72nEhi" : String.Empty);
		retObj.JOB_TITLE = "HfLmXSFebHOmJJuyjMtoZj65l2Ku4o5drep";
		retObj.MIN_SALARY = (-2026078460);
		retObj.MAX_SALARY = (-2082644645);
		return retObj;
	}
}
