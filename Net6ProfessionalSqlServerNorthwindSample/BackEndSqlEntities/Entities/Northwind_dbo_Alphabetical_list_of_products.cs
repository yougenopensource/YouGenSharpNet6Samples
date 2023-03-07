/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
// For reads only
using System.ComponentModel.DataAnnotations.Schema;
namespace Northwind_BackEndSqlEntities.Entities;
/// <summary>
/// SQL Entity Description: View Description: N/A
/// </summary>
public class Northwind_dbo_Alphabetical_list_of_products 
{
	public Northwind_dbo_Alphabetical_list_of_products()
	{
	} 
	public Northwind_dbo_Alphabetical_list_of_products(
		Int32 productID_,
		String productName_,
		Int32? supplierID_,
		Int32? categoryID_,
		String? quantityPerUnit_,
		Decimal? unitPrice_,
		Int16? unitsInStock_,
		Int16? unitsOnOrder_,
		Int16? reorderLevel_,
		Boolean discontinued_,
		String categoryName_
	)
	{
		ProductID = productID_;
		ProductName = productName_;
		SupplierID = supplierID_;
		CategoryID = categoryID_;
		QuantityPerUnit = quantityPerUnit_;
		UnitPrice = unitPrice_;
		UnitsInStock = unitsInStock_;
		UnitsOnOrder = unitsOnOrder_;
		ReorderLevel = reorderLevel_;
		Discontinued = discontinued_;
		CategoryName = categoryName_;
	}
	/// <summary>
	/// SQL Data Type: int Precision: 10 Scale: 0 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual Int32 ProductID { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 40 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String ProductName { get; set; } = null!;
	/// <summary>
	/// SQL Data Type: int Precision: 10 Scale: 0 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual Int32? SupplierID { get; set; }
	/// <summary>
	/// SQL Data Type: int Precision: 10 Scale: 0 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual Int32? CategoryID { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 20 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? QuantityPerUnit { get; set; }
	/// <summary>
	/// SQL Data Type: money Precision: 19 Scale: 4 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual Decimal? UnitPrice { get; set; }
	/// <summary>
	/// SQL Data Type: smallint Precision: 5 Scale: 0 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual Int16? UnitsInStock { get; set; }
	/// <summary>
	/// SQL Data Type: smallint Precision: 5 Scale: 0 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual Int16? UnitsOnOrder { get; set; }
	/// <summary>
	/// SQL Data Type: smallint Precision: 5 Scale: 0 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual Int16? ReorderLevel { get; set; }
	/// <summary>
	/// SQL Data Type: bit 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual Boolean Discontinued { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 15 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String CategoryName { get; set; } = null!;
}
