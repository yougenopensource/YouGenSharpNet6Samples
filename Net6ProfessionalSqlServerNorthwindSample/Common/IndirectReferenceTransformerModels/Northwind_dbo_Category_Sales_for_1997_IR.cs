/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
// For reads only
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace Northwind_Common.IndirectReferenceTransformerModels;
/// <summary>
/// Sql Entity Description: Indirect Referenced Model Description: N/A
/// </summary>
public class Northwind_dbo_Category_Sales_for_1997_IR
{
	public Northwind_dbo_Category_Sales_for_1997_IR() 
	{
	} 
	public Northwind_dbo_Category_Sales_for_1997_IR(
		String? categoryName_,
		Decimal? categorySales_
	)
	{
		_categoryName = categoryName_;
		CategoryName_OriginalValue = categoryName_;
		_categorySales = categorySales_;
		CategorySales_OriginalValue = categorySales_;
	}
	[JsonConstructor]
	public Northwind_dbo_Category_Sales_for_1997_IR(
		String? CategoryName,
		String? CategoryName_OriginalValue,
		Boolean CategoryName_HasBeenChanged,
		Decimal? CategorySales,
		Decimal? CategorySales_OriginalValue,
		Boolean CategorySales_HasBeenChanged
	)
	{
		this.CategoryName = CategoryName;
		this.CategoryName_OriginalValue = CategoryName_OriginalValue;
		this.CategoryName_HasBeenChanged = CategoryName_HasBeenChanged;
		this.CategorySales = CategorySales;
		this.CategorySales_OriginalValue = CategorySales_OriginalValue;
		this.CategorySales_HasBeenChanged = CategorySales_HasBeenChanged;
	}
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? CategoryName
	{
		get => _categoryName;
		set
		{
			_categoryName = value;
			CategoryName_HasBeenChanged = _categoryName == CategoryName_OriginalValue ? false : true;
		}
	}
	private String? _categoryName;
	public String? CategoryName_OriginalValue { get; private set; }
	public Boolean CategoryName_HasBeenChanged { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public Decimal? CategorySales
	{
		get => _categorySales;
		set
		{
			_categorySales = value;
			CategorySales_HasBeenChanged = _categorySales == CategorySales_OriginalValue ? false : true;
		}
	}
	private Decimal? _categorySales;
	public Decimal? CategorySales_OriginalValue { get; private set; }
	public Boolean CategorySales_HasBeenChanged { get; private set; }
}
