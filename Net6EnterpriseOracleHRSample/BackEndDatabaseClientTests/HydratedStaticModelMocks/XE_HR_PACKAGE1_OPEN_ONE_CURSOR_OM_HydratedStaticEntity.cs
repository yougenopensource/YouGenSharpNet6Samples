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
	public XE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM GetHydratedStaticXE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM(Boolean fillPrimaryKey = false)
	{
		var retObj = new XE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM();
		retObj.Query1_Results!.ToList().Add(new XE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM_Query1());
		retObj.Query1_Results!.First()!.EMPLOYEE_ID = Convert.ToDecimal(1);
		retObj.Query1_Results!.First()!.JOB_ID = "QyYG8ThVvf";
		retObj.Query1_Results!.First()!.MANAGER_ID = Convert.ToDecimal(1);
		retObj.Query1_Results!.First()!.DEPARTMENT_ID = Convert.ToDecimal(1);
		retObj.Query1_Results!.First()!.LOCATION_ID = Convert.ToDecimal(1);
		retObj.Query1_Results!.First()!.COUNTRY_ID = "VL";
		retObj.Query1_Results!.First()!.FIRST_NAME = "0j5nAFkv9jYF3BsEn2K2";
		retObj.Query1_Results!.First()!.LAST_NAME = "LZH3 1DOaxkZXl3M07vkr5Xqw";
		retObj.Query1_Results!.First()!.SALARY = (0.7846843735394287M);
		retObj.Query1_Results!.First()!.COMMISSION_PCT = (0.41421686948611314M);
		retObj.Query1_Results!.First()!.DEPARTMENT_NAME = "J7rq7izkm0sptRVR5helFafHqKIMA5";
		retObj.Query1_Results!.First()!.JOB_TITLE = "qvCB8XOHkXPJfV7jNGgcXnT n7opAbLsTus";
		retObj.Query1_Results!.First()!.CITY = "xpSCwdGlnmvk0Y50hqk QVi2bqTw6z";
		retObj.Query1_Results!.First()!.STATE_PROVINCE = "2jVly2Dyq4LZjn313zkLT6y1B";
		retObj.Query1_Results!.First()!.COUNTRY_NAME = "jg7ECSFaK0g6LvZvQCP8qn6FP9wnvM fYd0X2jRw";
		retObj.Query1_Results!.First()!.REGION_NAME = "WbV4YK9EwoshuJc8xJ5elrPYp";
		return retObj;
	}
}
