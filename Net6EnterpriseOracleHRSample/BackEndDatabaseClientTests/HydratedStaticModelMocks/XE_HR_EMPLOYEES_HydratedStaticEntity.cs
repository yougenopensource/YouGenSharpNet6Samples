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
	public XE_HR_EMPLOYEES GetHydratedStaticXE_HR_EMPLOYEES(Boolean fillPrimaryKey = false)
	{
		var retObj = new XE_HR_EMPLOYEES();
		retObj.EMPLOYEE_ID = (fillPrimaryKey ? Convert.ToInt32(1) : 0);
		retObj.FIRST_NAME = "DcocA5sp1bxxyosk38WF";
		retObj.LAST_NAME = "62SjHr3sIxtYEe6tt44E6YRuu";
		retObj.EMAIL = "r3Pv3KdZGd3kooGnrQgPuki0v";
		retObj.PHONE_NUMBER = "US069RBYmfO8LXfQOmHz";
		retObj.HIRE_DATE = DateTime.Parse("6/11/1997 12:00:00 AM");
		retObj.JOB_ID = "T9Z2cObwnn";
		retObj.SALARY = (0.6371415616073197M);
		retObj.COMMISSION_PCT = (0.7396125958455944M);
		retObj.MANAGER_ID = Convert.ToInt32(1);
		retObj.DEPARTMENT_ID = Convert.ToInt32(1);
		// Foreign key entities
		retObj.EMP_DEPT_FK_Ref = GetHydratedStaticXE_HR_DEPARTMENTS();
		retObj.EMP_JOB_FK_Ref = GetHydratedStaticXE_HR_JOBS();
		retObj.EMP_MANAGER_FK_Ref = GetHydratedStaticXE_HR_EMPLOYEES();
		return retObj;
	}
}
