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
/// Sql Entity Description: Indirect Referenced Model Description: N/A
/// </summary>
public class Northwind_dbo_Territories_IR
{
	public Northwind_dbo_Territories_IR() 
	{
	} 
	public Northwind_dbo_Territories_IR(
		String? territoryID_,
		String? territoryDescription_,
		String? regionID_IR_
	)
	{
		_territoryID = territoryID_;
		TerritoryID_OriginalValue = territoryID_;
		_territoryDescription = territoryDescription_;
		TerritoryDescription_OriginalValue = territoryDescription_;
		_regionID_IR = regionID_IR_;
		RegionID_IR_OriginalValue = regionID_IR_;
		PrimaryKeyEncryptedForUpdateDeleteIdentification = territoryID_;
	}
	[JsonConstructor]
	public Northwind_dbo_Territories_IR(
		String TerritoryID,
		String TerritoryID_OriginalValue,
		Boolean TerritoryID_HasBeenChanged,
		String TerritoryDescription,
		String TerritoryDescription_OriginalValue,
		Boolean TerritoryDescription_HasBeenChanged,
		String? RegionID_IR,
		String? RegionID_IR_OriginalValue,
		Boolean RegionID_IR_HasBeenChanged,
		String? PrimaryKeyEncryptedForUpdateDeleteIdentification,
		String? PrimaryKeyHashedForUniqueObjectComparison
	)
	{
		this.TerritoryID = TerritoryID;
		this.TerritoryID_OriginalValue = TerritoryID_OriginalValue;
		this.TerritoryID_HasBeenChanged = TerritoryID_HasBeenChanged;
		this.TerritoryDescription = TerritoryDescription;
		this.TerritoryDescription_OriginalValue = TerritoryDescription_OriginalValue;
		this.TerritoryDescription_HasBeenChanged = TerritoryDescription_HasBeenChanged;
		this.RegionID_IR = RegionID_IR;
		this.RegionID_IR_OriginalValue = RegionID_IR_OriginalValue;
		this.RegionID_IR_HasBeenChanged = RegionID_IR_HasBeenChanged;
		this.PrimaryKeyEncryptedForUpdateDeleteIdentification = PrimaryKeyEncryptedForUpdateDeleteIdentification;
		this.PrimaryKeyHashedForUniqueObjectComparison = PrimaryKeyHashedForUniqueObjectComparison;
	}
	/// <summary>
	/// SQL Column Description: Primary key encrypted value for update and delete identification purposes
	/// </summary>
	public String? PrimaryKeyEncryptedForUpdateDeleteIdentification { get; set; }
	/// <summary>
	/// SQL Column Description: Primary key hashed value for uniue object comparison purposes
	/// </summary>
	public String? PrimaryKeyHashedForUniqueObjectComparison { get; set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? TerritoryID
	{
		get => _territoryID;
		set
		{
			_territoryID = value;
			TerritoryID_HasBeenChanged = _territoryID == TerritoryID_OriginalValue ? false : true;
		}
	}
	private String? _territoryID;
	public String? TerritoryID_OriginalValue  { get; private set; }
	public Boolean TerritoryID_HasBeenChanged  { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? TerritoryDescription
	{
		get => _territoryDescription;
		set
		{
			_territoryDescription = value;
			TerritoryDescription_HasBeenChanged = _territoryDescription == TerritoryDescription_OriginalValue ? false : true;
		}
	}
	private String? _territoryDescription;
	public String? TerritoryDescription_OriginalValue  { get; private set; }
	public Boolean TerritoryDescription_HasBeenChanged  { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? RegionID_IR
	{
		get => _regionID_IR;
		set
		{
			_regionID_IR = value;
			RegionID_IR_HasBeenChanged = _regionID_IR == RegionID_IR_OriginalValue ? false : true;
		}
	}
	private String? _regionID_IR;
	public String? RegionID_IR_OriginalValue { get; private set; }
	public Boolean RegionID_IR_HasBeenChanged { get; private set; }
	// Foreign key entities
	public virtual Northwind_dbo_Region_IR? FK_Territories_Region_Ref_IR { get; set; }
	/// <summary>
	/// Entities that reference this entity by foreign key
	/// </summary>
	/// <example>null</example>
	public virtual ICollection<Northwind_dbo_EmployeeTerritories_IR>?FK_EmployeeTerritories_Territories_RefBy_IR { get; set; } = new HashSet<Northwind_dbo_EmployeeTerritories_IR>();
	/// <summary>
	/// Foreign key entity
	/// </summary>
	/// <example>null</example>
}