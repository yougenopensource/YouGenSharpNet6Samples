/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace Northwind_Common.IndirectReferenceTransformerModels;
/// <summary>
/// Sql Entity Description: Model Description: Stored Procedure Input Model
/// </summary>
public class Northwind_dbo_SalesByCategory_IM_IR
{
	public Northwind_dbo_SalesByCategory_IM_IR() 
	{
	} 
	public Northwind_dbo_SalesByCategory_IM_IR(
		String? categoryName_,
		String? ordYear_
	)
	{
		CategoryName = categoryName_;
		OrdYear = ordYear_;
	}
	[JsonConstructor]
	public Northwind_dbo_SalesByCategory_IM_IR(
		String? CategoryName,
		String? CategoryName_OriginalValue,
		Boolean CategoryName_HasBeenChanged,
		String? OrdYear,
		String? OrdYear_OriginalValue,
		Boolean OrdYear_HasBeenChanged
	)
	{
		this.CategoryName = CategoryName;
		this.CategoryName_OriginalValue = CategoryName_OriginalValue;
		this.CategoryName_HasBeenChanged = CategoryName_HasBeenChanged;
		this.OrdYear = OrdYear;
		this.OrdYear_OriginalValue = OrdYear_OriginalValue;
		this.OrdYear_HasBeenChanged = OrdYear_HasBeenChanged;
	}
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
	public String? OrdYear
	{
		get => _ordYear;
		set
		{
			_ordYear = value;
			OrdYear_HasBeenChanged = _ordYear == OrdYear_OriginalValue ? false : true;
		}
	}
	private String? _ordYear;
	public String? OrdYear_OriginalValue { get; private set; }
	public Boolean OrdYear_HasBeenChanged { get; private set; }
}
