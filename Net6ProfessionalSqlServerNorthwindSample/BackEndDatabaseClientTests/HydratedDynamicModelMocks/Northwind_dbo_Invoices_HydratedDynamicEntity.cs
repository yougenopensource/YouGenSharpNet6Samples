/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Tynamix.ObjectFiller;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndDatabaseClientTests.HydratedDynamicEntities;
public partial class Northwind_HydratedDynamicEntities  : Northwind_HydratedDynamicEntitiesBase
{
	protected Filler<Northwind_dbo_Invoices> _Northwind_dbo_Invoices_Filler = new Filler<Northwind_dbo_Invoices>();
	protected FillerSetup? _Northwind_dbo_Invoices_FillerSetup;
	public FillerSetup GetNorthwind_dbo_Invoices_FillerSetup(Boolean onlyFillExplicitlyNamedProperties)
	{
		if (_Northwind_dbo_Invoices_FillerSetup != null)
			return _Northwind_dbo_Invoices_FillerSetup;
		_Northwind_dbo_Invoices_FillerSetup = _Northwind_dbo_Invoices_Filler.Setup(onlyFillExplicitlyNamedProperties)
		.OnProperty(x => x.ShipName).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(40)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.ShipAddress).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(60)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.ShipCity).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(15)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.ShipRegion).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(15)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.ShipPostalCode).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(10)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.ShipCountry).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(15)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.CustomerID).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(5)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.CustomerName).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(40)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.Address).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(60)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.City).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(15)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.Region).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(15)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.PostalCode).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(10)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.Country).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(15)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.Salesperson).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(31)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.OrderID).Use(() => Random.Shared.Next(Int32.MinValue, Int32.MaxValue))
		.OnProperty(x => x.OrderDate).Use(() => _seedDateTime.AddDays(Random.Shared.Next(_range)))
		.OnProperty(x => x.RequiredDate).Use(() => _seedDateTime.AddDays(Random.Shared.Next(_range)))
		.OnProperty(x => x.ShippedDate).Use(() => _seedDateTime.AddDays(Random.Shared.Next(_range)))
		.OnProperty(x => x.ShipperName).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(40)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.ProductID).Use(() => Random.Shared.Next(Int32.MinValue, Int32.MaxValue))
		.OnProperty(x => x.ProductName).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(40)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.UnitPrice).Use(() => Convert.ToDecimal(Random.Shared.NextDouble()))
		.OnProperty(x => x.Quantity).Use(() => Convert.ToInt16(Random.Shared.Next(Int16.MinValue, Int16.MaxValue)))
		.OnProperty(x => x.Discount).Use(() => Random.Shared.NextSingle())
		.OnProperty(x => x.ExtendedPrice).Use(() => Convert.ToDecimal(Random.Shared.NextDouble()))
		.OnProperty(x => x.Freight).Use(() => Convert.ToDecimal(Random.Shared.NextDouble()))
		.Result;
		return _Northwind_dbo_Invoices_FillerSetup;
	}
	public Northwind_dbo_Invoices GetHydratedDynamicNorthwind_dbo_Invoices(Boolean onlyFillExplicitlyNamedProperties = true)
	{
		return GetHydratedDynamicIEnumerableOfNorthwind_dbo_Invoices(1, onlyFillExplicitlyNamedProperties).First();
	}
	public IEnumerable<Northwind_dbo_Invoices> GetHydratedDynamicIEnumerableOfNorthwind_dbo_Invoices(Int32 numberToCreate, 
		Boolean onlyFillExplicitlyNamedProperties = true)
	{
		_Northwind_dbo_Invoices_Filler.Setup(GetNorthwind_dbo_Invoices_FillerSetup(onlyFillExplicitlyNamedProperties));
		var retObjects = _Northwind_dbo_Invoices_Filler.Create(numberToCreate);
		return retObjects;
	}
}
