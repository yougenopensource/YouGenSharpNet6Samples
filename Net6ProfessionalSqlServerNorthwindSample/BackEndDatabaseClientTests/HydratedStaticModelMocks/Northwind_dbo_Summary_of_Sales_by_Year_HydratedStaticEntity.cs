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
	public Northwind_dbo_Summary_of_Sales_by_Year GetHydratedStaticNorthwind_dbo_Summary_of_Sales_by_Year(Boolean fillPrimaryKey = false)
	{
		var retObj = new Northwind_dbo_Summary_of_Sales_by_Year();
		retObj.ShippedDate = DateTime.Parse("1/12/2017 12:00:00 AM");
		retObj.OrderID = (-645562966);
		retObj.Subtotal = (0.39395069124752147M);
		return retObj;
	}
}
