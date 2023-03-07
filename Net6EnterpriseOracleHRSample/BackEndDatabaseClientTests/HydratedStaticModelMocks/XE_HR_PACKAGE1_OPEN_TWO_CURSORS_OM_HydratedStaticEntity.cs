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
	public XE_HR_PACKAGE1_OPEN_TWO_CURSORS_OM GetHydratedStaticXE_HR_PACKAGE1_OPEN_TWO_CURSORS_OM(Boolean fillPrimaryKey = false)
	{
		var retObj = new XE_HR_PACKAGE1_OPEN_TWO_CURSORS_OM();
		retObj.Query1_Results!.ToList().Add(new XE_HR_PACKAGE1_OPEN_TWO_CURSORS_OM_Query1());
		retObj.Query2_Results!.ToList().Add(new XE_HR_PACKAGE1_OPEN_TWO_CURSORS_OM_Query2());
		retObj.Query1_Results!.First()!.EMPLOYEE_ID = Convert.ToDecimal(1);
		retObj.Query1_Results!.First()!.FIRST_NAME = "WnFDJkmaC5iCJZQypwIM";
		retObj.Query1_Results!.First()!.LAST_NAME = "6ERcxm EKeatZXOZ2zYN4MBd7";
		retObj.Query1_Results!.First()!.EMAIL = "N1sha556diHWVNv6X9PiLRN9D";
		retObj.Query1_Results!.First()!.PHONE_NUMBER = "3Z44eekMm0WDbZ7GoRUc";
		retObj.Query1_Results!.First()!.HIRE_DATE = "BrUrS2I";
		retObj.Query1_Results!.First()!.JOB_ID = "XbbA5eCHdS";
		retObj.Query1_Results!.First()!.SALARY = (0.9887961565143026M);
		retObj.Query1_Results!.First()!.COMMISSION_PCT = (0.3266214779813489M);
		retObj.Query1_Results!.First()!.MANAGER_ID = Convert.ToDecimal(1);
		retObj.Query1_Results!.First()!.DEPARTMENT_ID = Convert.ToDecimal(1);
		retObj.Query2_Results!.First()!.DEPARTMENT_ID = Convert.ToDecimal(1);
		retObj.Query2_Results!.First()!.DEPARTMENT_NAME = "8nHCaAv05pEqET5uOhsJjhgz4OW2mu";
		retObj.Query2_Results!.First()!.MANAGER_ID = Convert.ToDecimal(1);
		retObj.Query2_Results!.First()!.LOCATION_ID = Convert.ToDecimal(1);
		return retObj;
	}
}
