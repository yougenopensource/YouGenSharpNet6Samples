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
/// SQL Entity Description: Table Description: N/A
/// </summary>
public class Northwind_dbo_Shippers 
{
	public Northwind_dbo_Shippers()
	{
	} 
	public Northwind_dbo_Shippers(
		Int32 shipperID_,
		String companyName_,
		String? phone_
	)
	{
		ShipperID = shipperID_;
		CompanyName = companyName_;
		Phone = phone_;
	}
	/// <summary>
	/// Identity Column
	/// Primary Key Column
	/// SQL Data Type: int Precision: 10 Scale: 0 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual Int32 ShipperID { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 40 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String CompanyName { get; set; } = null!;
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 24 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? Phone { get; set; }
	/// <summary>
	/// Entities that reference this entity by foreign key
	/// </summary>
	/// <example>null</example>
	public virtual ICollection<Northwind_dbo_Orders>?FK_Orders_Shippers_RefBy { get; set; } = new HashSet<Northwind_dbo_Orders>();
}
