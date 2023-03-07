/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Tynamix.ObjectFiller;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndDatabaseClientTests.HydratedDynamicEntities;
public partial class Northwind_HydratedDynamicEntities  : Northwind_HydratedDynamicEntitiesBase
{
	protected Filler<Northwind_dbo_Orders> _Northwind_dbo_Orders_Filler = new Filler<Northwind_dbo_Orders>();
	protected FillerSetup? _Northwind_dbo_Orders_FillerSetup;
	public FillerSetup GetNorthwind_dbo_Orders_FillerSetup(Boolean onlyFillExplicitlyNamedProperties, 
		Boolean fillPrimaryKey = false)
	{
		if (_Northwind_dbo_Orders_FillerSetup != null)
			return _Northwind_dbo_Orders_FillerSetup;
		_Northwind_dbo_Orders_FillerSetup = _Northwind_dbo_Orders_Filler.Setup(onlyFillExplicitlyNamedProperties)
		.OnProperty(x => x.OrderID).Use(() => (fillPrimaryKey ? Convert.ToInt32(1) : 0))
		.OnProperty(x => x.CustomerID).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(5)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.EmployeeID).Use(() => Convert.ToInt32(1))
		.OnProperty(x => x.OrderDate).Use(() => _seedDateTime.AddDays(Random.Shared.Next(_range)))
		.OnProperty(x => x.RequiredDate).Use(() => _seedDateTime.AddDays(Random.Shared.Next(_range)))
		.OnProperty(x => x.ShippedDate).Use(() => _seedDateTime.AddDays(Random.Shared.Next(_range)))
		.OnProperty(x => x.ShipVia).Use(() => Convert.ToInt32(1))
		.OnProperty(x => x.Freight).Use(() => Convert.ToDecimal(Random.Shared.NextDouble()))
		.OnProperty(x => x.ShipName).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(40)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.ShipAddress).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(60)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.ShipCity).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(15)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.ShipRegion).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(15)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.ShipPostalCode).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(10)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.ShipCountry).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(15)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		// Foreign key entities
		.OnProperty(x => x.FK_Orders_Customers_Ref).IgnoreIt()
		.OnProperty(x => x.FK_Orders_Employees_Ref).IgnoreIt()
		.OnProperty(x => x.FK_Orders_Shippers_Ref).IgnoreIt()
		// Entities that reference this entity by foreign key
		.OnProperty(x => x.FK_Order_Details_Orders_RefBy).IgnoreIt()
		.Result;
		return _Northwind_dbo_Orders_FillerSetup;
	}
	public Northwind_dbo_Orders GetHydratedDynamicNorthwind_dbo_Orders(Boolean onlyFillExplicitlyNamedProperties = true, 
		Boolean fillPrimaryKey = false,	
		Boolean fillInnerForeignKeys = false, 
		Boolean fillInnerPrimaryKeyReferencedBy = false)
	{
		return GetHydratedDynamicIEnumerableOfNorthwind_dbo_Orders(1,
			onlyFillExplicitlyNamedProperties, 
			fillPrimaryKey, 
			fillInnerForeignKeys, 
			fillInnerPrimaryKeyReferencedBy).First();
	}
	public IEnumerable<Northwind_dbo_Orders> GetHydratedDynamicIEnumerableOfNorthwind_dbo_Orders(Int32 numberToCreate, 
		Boolean onlyFillExplicitlyNamedProperties = true, 
		Boolean fillPrimaryKey = false, 
		Boolean fillInnerForeignKeys = false, 
		Boolean fillInnerPrimaryKeyReferencedBy = false)
	{
		_Northwind_dbo_Orders_Filler.Setup(GetNorthwind_dbo_Orders_FillerSetup(onlyFillExplicitlyNamedProperties, fillPrimaryKey));
		var retObjects = _Northwind_dbo_Orders_Filler.Create(numberToCreate);
		if (fillInnerForeignKeys) FillInnerForeignKeys(retObjects);
        if (fillInnerPrimaryKeyReferencedBy) FillInnerPrimaryKeyReferencedBy(retObjects);
		return retObjects;
	}
	private void FillInnerForeignKeys(IEnumerable<Northwind_dbo_Orders> entities)
	{
		foreach (var entity in entities)
		{
			entity.FK_Orders_Customers_Ref = GetHydratedDynamicNorthwind_dbo_Customers();
			entity.FK_Orders_Employees_Ref = GetHydratedDynamicNorthwind_dbo_Employees();
			entity.FK_Orders_Shippers_Ref = GetHydratedDynamicNorthwind_dbo_Shippers();
		}
	}
	private void FillInnerPrimaryKeyReferencedBy(IEnumerable<Northwind_dbo_Orders> entities)
	{
		foreach (var entity in entities)
		{
			// entity.FK_Order_Details_Orders_RefBy!.Add(GetHydratedDynamicNorthwind_dbo_Order_Details());
		}
	}
}
