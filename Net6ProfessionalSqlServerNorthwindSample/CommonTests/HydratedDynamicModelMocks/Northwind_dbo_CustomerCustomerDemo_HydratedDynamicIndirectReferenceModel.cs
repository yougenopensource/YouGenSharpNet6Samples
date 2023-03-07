/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Tynamix.ObjectFiller;
using Northwind_Common.IndirectReferenceTransformerModels;
using Northwind_BackEndSqlEntities.Entities;
using Northwind_BackEndCommon.Services;
namespace Northwind_CommonTests.HydratedDynamicIndirectReferenceTransformerModels;
public partial class Northwind_HydratedDynamicIndirectReferenceTransformerModels : Northwind_HydratedDynamicIndirectReferenceTransformerModelsBase
{
	protected Filler<Northwind_dbo_CustomerCustomerDemo_IR> _Northwind_dbo_CustomerCustomerDemo_IR_Filler = new Filler<Northwind_dbo_CustomerCustomerDemo_IR>();
	protected FillerSetup? _Northwind_dbo_CustomerCustomerDemo_IR_FillerSetup;
	public FillerSetup GetNorthwind_dbo_CustomerCustomerDemo_IR_FillerSetup(Boolean onlyFillExplicitlyNamedProperties, 
		Boolean fillPrimaryKey = false)
	{
		if (_Northwind_dbo_CustomerCustomerDemo_IR_FillerSetup != null)
			return _Northwind_dbo_CustomerCustomerDemo_IR_FillerSetup;
		_Northwind_dbo_CustomerCustomerDemo_IR_FillerSetup = _Northwind_dbo_CustomerCustomerDemo_IR_Filler.Setup(onlyFillExplicitlyNamedProperties)
		.OnProperty(x => x.CustomerID).Use(() => (fillPrimaryKey ? new String(Enumerable.Repeat(_chars, Convert.ToInt32(5)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()) : String.Empty))
		.OnProperty(x => x.CustomerTypeID).Use(() => (fillPrimaryKey ? new String(Enumerable.Repeat(_chars, Convert.ToInt32(10)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()) : String.Empty))
		// Foreign key entities
		.OnProperty(x => x.FK_CustomerCustomerDemo_Ref_IR).IgnoreIt()
		.OnProperty(x => x.FK_CustomerCustomerDemo_Customers_Ref_IR).IgnoreIt()
		.Result;
		return _Northwind_dbo_CustomerCustomerDemo_IR_FillerSetup;
	}
	public Northwind_dbo_CustomerCustomerDemo_IR GetHydratedDynamicNorthwind_dbo_CustomerCustomerDemo_IR(Boolean onlyFillExplicitlyNamedProperties = true, 
		Boolean fillPrimaryKey = false, 
		Boolean fillInnerForeignKeys = false, 
		Boolean fillInnerPrimaryKeyReferencedBy = false)
	{
		return GetHydratedDynamicIEnumerableOfNorthwind_dbo_CustomerCustomerDemo_IR(1, 
			onlyFillExplicitlyNamedProperties, 
			fillPrimaryKey, 
			fillInnerForeignKeys, 
			fillInnerPrimaryKeyReferencedBy).First();
	}
	public IEnumerable<Northwind_dbo_CustomerCustomerDemo_IR> GetHydratedDynamicIEnumerableOfNorthwind_dbo_CustomerCustomerDemo_IR(Int32 numberToCreate, 
		Boolean onlyFillExplicitlyNamedProperties = true, 
		Boolean fillPrimaryKey = false, 
		Boolean fillInnerForeignKeys = false, 
		Boolean fillInnerPrimaryKeyReferencedBy = false)
	{
		_Northwind_dbo_CustomerCustomerDemo_IR_Filler.Setup(GetNorthwind_dbo_CustomerCustomerDemo_IR_FillerSetup(onlyFillExplicitlyNamedProperties, fillPrimaryKey));
		var retObjects =  _Northwind_dbo_CustomerCustomerDemo_IR_Filler.Create(numberToCreate);
		if (fillInnerForeignKeys) FillInnerForeignKeys(retObjects);
        if (fillInnerPrimaryKeyReferencedBy) FillInnerPrimaryKeyReferencedBy(retObjects);
		return retObjects;
	}
	private void FillInnerForeignKeys(IEnumerable<Northwind_dbo_CustomerCustomerDemo_IR> irModels)
	{
		foreach (var irModel in irModels)
		{
			irModel.FK_CustomerCustomerDemo_Ref_IR = GetHydratedDynamicNorthwind_dbo_CustomerDemographics_IR();
			irModel.FK_CustomerCustomerDemo_Customers_Ref_IR = GetHydratedDynamicNorthwind_dbo_Customers_IR();
		}
	}
	private void FillInnerPrimaryKeyReferencedBy(IEnumerable<Northwind_dbo_CustomerCustomerDemo_IR> irModels)
	{
		foreach (var irModel in irModels)
		{
		}
	}
}
