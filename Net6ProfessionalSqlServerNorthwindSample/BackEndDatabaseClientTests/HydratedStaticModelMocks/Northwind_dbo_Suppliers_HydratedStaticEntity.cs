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
	public Northwind_dbo_Suppliers GetHydratedStaticNorthwind_dbo_Suppliers(Boolean fillPrimaryKey = false)
	{
		var retObj = new Northwind_dbo_Suppliers();
		retObj.SupplierID = (fillPrimaryKey ? Convert.ToInt32(1) : 0);
		retObj.CompanyName = "bLgd4UBj7mb6IewlUbTduu0SpsQjGCT6kPWOm 3t";
		retObj.ContactName = "9ajf4nGX4fiADzMpNa9 pkmgEbYg g";
		retObj.ContactTitle = "YNozZxNGK00bz5Vl4t5V0O6X7eM0lj";
		retObj.Address = "PXWlhqnwlPEshn7Si2vvboy1lbeWHvVwfhdGhrYpxYGqP0CmgT8epPja21iq";
		retObj.City = "Kna4HOhYmvMKGxk";
		retObj.Region = "FLvDNruAMjsT390";
		retObj.PostalCode = "GNiIlWVQuG";
		retObj.Country = "jiDqF3mWGtS6T3l";
		retObj.Phone = "OnJMCC6zMe4eMU0khL5ByKWG";
		retObj.Fax = "J7VcISiNV5rb4SYYCjq78Hsp";
		retObj.HomePage = "pHuSSxcSlg7LWb4O3LMTIanuTlrsSU1Z1nfY4fQeA1VPsDSZjUfMjyzkfIed6Kyyk OVcGezNMqpa3XWRdM9pHN4HbMPQIh7NkWM";
		return retObj;
	}
}
