/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndDatabaseClientTests.HydratedStaticEntities;
public partial class Northwind_HydratedStaticEntities 
{
	public Northwind_dbo_CustomerDemographics GetHydratedStaticNorthwind_dbo_CustomerDemographics(Boolean fillPrimaryKey = false)
	{
		var retObj = new Northwind_dbo_CustomerDemographics();
		retObj.CustomerTypeID = (fillPrimaryKey ? "4YBEunsDtY" : String.Empty);
		retObj.CustomerDesc = "Vgw73mQaxchUjqA5xlVTad3wsG4Iqu72acRt3BtyPHdHaorciqiFiqd8ot3MsD6S51rmKP2u8jLGfAItLZJol2sMgTEuYUMnMklr";
		return retObj;
	}
}
