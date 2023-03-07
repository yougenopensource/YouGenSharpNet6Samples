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
	public Northwind_dbo_Products_by_Category_IR ToIndirectModel(Northwind_dbo_Products_by_Category input)
	{
		var retData = new Northwind_dbo_Products_by_Category_IR(
			categoryName_ : input.CategoryName,
			productName_ : input.ProductName,
			quantityPerUnit_ : input.QuantityPerUnit,
			unitsInStock_ : input.UnitsInStock,
			discontinued_ : input.Discontinued
			);
		return retData;
	}
	public Northwind_dbo_Products_by_Category ToEntity(Northwind_dbo_Products_by_Category_IR input)
	{
		var retData = new Northwind_dbo_Products_by_Category(		
			categoryName_ : input.CategoryName ?? String.Empty,
			productName_ : input.ProductName ?? String.Empty,
			quantityPerUnit_ : input.QuantityPerUnit,
			unitsInStock_ : input.UnitsInStock,
			discontinued_ : input.Discontinued ?? default
			);
		return retData;
	}
}
