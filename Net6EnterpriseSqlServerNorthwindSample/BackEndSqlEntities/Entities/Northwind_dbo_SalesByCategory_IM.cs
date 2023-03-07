/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using System.ComponentModel.DataAnnotations.Schema;
namespace Northwind_BackEndSqlEntities.Entities;
/// <summary>
/// SQL Entity Description: Model Description: Stored Procedure Input Model Parameters
/// </summary>
public class Northwind_dbo_SalesByCategory_IM 
{
	public Northwind_dbo_SalesByCategory_IM()
	{
	} 
	public Northwind_dbo_SalesByCategory_IM(
		String? categoryName_,
		String? ordYear_
	)
	{
		CategoryName = categoryName_;
		OrdYear = ordYear_;
	}
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 15 Precision: 0 Scale: 0 
	/// </summary>
	public virtual String? CategoryName { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 4 Precision: 0 Scale: 0 
	/// </summary>
	public virtual String? OrdYear { get; set; }
}
