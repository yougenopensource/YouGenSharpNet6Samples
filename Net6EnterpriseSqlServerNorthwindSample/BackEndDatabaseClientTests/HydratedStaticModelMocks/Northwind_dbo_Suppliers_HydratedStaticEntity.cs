/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
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
		retObj.CompanyName = "zORRscu3Ko 2et9cT97d389RO3XdOlylnAnxpw8K";
		retObj.ContactName = "d26rzOabW0pXWzYFGbku1X6iIARqey";
		retObj.ContactTitle = "L4ShpLTrDf3vW4BfCyC4Run4JhyW9n";
		retObj.Address = "UNZ08Yt4ndU2xaXVGPIYVRlRylxjZy6Qma8tfex0f2XjKNilVUTJVkH27f01";
		retObj.City = "MDeiAkEwmgNQBiO";
		retObj.Region = "EfPcJ 4EtZnu51K";
		retObj.PostalCode = "XEOyO8ozR4";
		retObj.Country = "M4IcRZMFHRAyTOb";
		retObj.Phone = "SGlh6tiAZSwAgrtrcEfrf3Dy";
		retObj.Fax = "4ZZgRD7TULcuISugBq8lyFcb";
		retObj.HomePage = "RIpNid 8BIpIYAX8oVVjRihYr2UlzGbYYK s2DGsGp9m0MNks3g5EQoMD VpNr47qiObSPqrDocYd3rSMRCp9kXBUxDKeX8Tcwbe";
		return retObj;
	}
}