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
	public Northwind_dbo_Orders_Qry_IR ToIndirectModel(Northwind_dbo_Orders_Qry input)
	{
		var retData = new Northwind_dbo_Orders_Qry_IR(
			orderID_IR_ : _encryptionDecryptionService!.EncInt32(input.OrderID),
			customerID_ : input.CustomerID,
			employeeID_IR_ : _encryptionDecryptionService!.EncInt32Nullable(input.EmployeeID),
			orderDate_ : input.OrderDate,
			requiredDate_ : input.RequiredDate,
			shippedDate_ : input.ShippedDate,
			shipVia_ : input.ShipVia,
			freight_ : input.Freight,
			shipName_ : input.ShipName,
			shipAddress_ : input.ShipAddress,
			shipCity_ : input.ShipCity,
			shipRegion_ : input.ShipRegion,
			shipPostalCode_ : input.ShipPostalCode,
			shipCountry_ : input.ShipCountry,
			companyName_ : input.CompanyName,
			address_ : input.Address,
			city_ : input.City,
			region_ : input.Region,
			postalCode_ : input.PostalCode,
			country_ : input.Country
			);
		return retData;
	}
	public Northwind_dbo_Orders_Qry ToEntity(Northwind_dbo_Orders_Qry_IR input)
	{
		var retData = new Northwind_dbo_Orders_Qry(		
			orderID_ : _encryptionDecryptionService.DecInt32(input.OrderID_IR),
			customerID_ : input.CustomerID,
			employeeID_ : _encryptionDecryptionService.DecInt32Nullable(input.EmployeeID_IR),
			orderDate_ : input.OrderDate,
			requiredDate_ : input.RequiredDate,
			shippedDate_ : input.ShippedDate,
			shipVia_ : input.ShipVia,
			freight_ : input.Freight,
			shipName_ : input.ShipName,
			shipAddress_ : input.ShipAddress,
			shipCity_ : input.ShipCity,
			shipRegion_ : input.ShipRegion,
			shipPostalCode_ : input.ShipPostalCode,
			shipCountry_ : input.ShipCountry,
			companyName_ : input.CompanyName ?? String.Empty,
			address_ : input.Address,
			city_ : input.City,
			region_ : input.Region,
			postalCode_ : input.PostalCode,
			country_ : input.Country
			);
		return retData;
	}
}
