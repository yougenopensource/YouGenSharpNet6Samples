/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Northwind_Common.IndirectReferenceTransformerModels;
using Northwind_BackEndSqlEntities.Entities;
using Northwind_BackEndCommon.Services;
namespace Northwind_CommonTests.HydratedStaticIndirectReferenceTransformerModels;
public partial class Northwind_HydratedStaticIndirectReferenceTransformerModels : Northwind_HydratedStaticIndirectReferenceTransformerModelsBase
{
	public Northwind_dbo_CustomerDemographics_IR GetHydratedStaticNorthwind_dbo_CustomerDemographics_IR(Boolean fillPrimaryKey = false)
	{
		var retObj = new Northwind_dbo_CustomerDemographics_IR();
		retObj.CustomerTypeID = (fillPrimaryKey ? "w9AUqL F8o" : String.Empty);
		retObj.CustomerDesc = "uQNlbEcIcGAf11qwxL5wViO9rVsuAj0CpQFEzyj3Y1gIYisHG4ruIUa6JXTPx0Gt5eFsQ1FKnIHGsJ3KisUCF6LWEEkQG3e7jMhP";
		return retObj;
	}
}
