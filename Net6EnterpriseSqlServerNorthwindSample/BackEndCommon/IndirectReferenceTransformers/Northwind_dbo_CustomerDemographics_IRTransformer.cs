/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Northwind_BackEndSqlEntities.Entities;
using Northwind_BackEndCommon.Services;
using Northwind_Common.IndirectReferenceTransformerModels;
namespace Northwind_BackEndCommon.IndirectReferenceTransformers;
public partial class IRTransformers : IIRTransformers
{
	public Northwind_dbo_CustomerDemographics_IR ToIndirectModel(Northwind_dbo_CustomerDemographics input, Boolean isSecondaryLookup = false)
	{
		var retData = new Northwind_dbo_CustomerDemographics_IR(
			customerTypeID_ : input.CustomerTypeID,
			customerDesc_ : input.CustomerDesc
			);
		if (!isSecondaryLookup && input.FK_CustomerCustomerDemo_RefBy!.Any()) retData.FK_CustomerCustomerDemo_RefBy_IR = input.FK_CustomerCustomerDemo_RefBy!.Select(x => ToIndirectModel(x, true)).ToList()!;
			retData.PrimaryKeyHashedForUniqueObjectComparison = _encryptionDecryptionService!.CreateHash(retData.CustomerTypeID);
		return retData;
	}
	public Northwind_dbo_CustomerDemographics ToEntity(Northwind_dbo_CustomerDemographics_IR input, Boolean isSecondaryLookup = false)
	{
		var retData = new Northwind_dbo_CustomerDemographics(		
			customerTypeID_ : input.CustomerTypeID ?? String.Empty,
			customerDesc_ : input.CustomerDesc
			);
		return retData;
	}
}
