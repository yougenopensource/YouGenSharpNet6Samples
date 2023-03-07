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
public class Northwind_dbo_Region 
{
	public Northwind_dbo_Region()
	{
	} 
	public Northwind_dbo_Region(
		Int32 regionID_,
		String regionDescription_
	)
	{
		RegionID = regionID_;
		RegionDescription = regionDescription_;
	}
	/// <summary>
	/// Primary Key Column
	/// SQL Data Type: int Precision: 10 Scale: 0 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual Int32 RegionID { get; set; }
	/// <summary>
	/// SQL Data Type: nchar Chars: 50 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String RegionDescription { get; set; } = null!;
	/// <summary>
	/// Entities that reference this entity by foreign key
	/// </summary>
	/// <example>null</example>
	public virtual ICollection<Northwind_dbo_Territories>?FK_Territories_Region_RefBy { get; set; } = new HashSet<Northwind_dbo_Territories>();
}
