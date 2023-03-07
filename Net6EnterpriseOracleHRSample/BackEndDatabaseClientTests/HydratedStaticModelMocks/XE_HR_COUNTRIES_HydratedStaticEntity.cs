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
	public XE_HR_COUNTRIES GetHydratedStaticXE_HR_COUNTRIES(Boolean fillPrimaryKey = false)
	{
		var retObj = new XE_HR_COUNTRIES();
		retObj.COUNTRY_ID = (fillPrimaryKey ? "jH" : String.Empty);
		retObj.COUNTRY_NAME = "e1vj4xWDcJeiG2 ZzPJqHaFCCrZ1VbBNasyx Jt4";
		retObj.REGION_ID = Convert.ToInt32(1);
		// Foreign key entities
		retObj.COUNTR_REG_FK_Ref = GetHydratedStaticXE_HR_REGIONS();
		return retObj;
	}
}
