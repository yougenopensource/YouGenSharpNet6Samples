/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202507 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using XE_HR_BackEndSqlEntities.Entities;
namespace XE_HR_BackEndDatabaseClientTests.HydratedStaticEntities;
public partial class XE_HR_HydratedStaticEntities 
{
	public XE_HR_DEPARTMENTS GetHydratedStaticXE_HR_DEPARTMENTS(Boolean fillPrimaryKey = false)
	{
		var retObj = new XE_HR_DEPARTMENTS();
		retObj.DEPARTMENT_ID = (fillPrimaryKey ? Convert.ToInt32(1) : 0);
		retObj.DEPARTMENT_NAME = "6wEpEnPfxpKqswAVR gqLNUTsYynVj";
		retObj.MANAGER_ID = Convert.ToInt32(1);
		retObj.LOCATION_ID = Convert.ToInt32(1);
		// Foreign key entities
		retObj.DEPT_LOC_FK_Ref = GetHydratedStaticXE_HR_LOCATIONS();
		retObj.DEPT_MGR_FK_Ref = GetHydratedStaticXE_HR_EMPLOYEES();
		return retObj;
	}
}
