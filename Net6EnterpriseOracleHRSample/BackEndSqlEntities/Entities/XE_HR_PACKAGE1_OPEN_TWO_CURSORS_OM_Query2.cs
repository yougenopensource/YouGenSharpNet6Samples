/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202605 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
namespace XE_HR_BackEndSqlEntities.Entities;
	/// <summary>
	/// SQL Entity Description: Stored Procedure Output Query Model
	/// </summary>
public class XE_HR_PACKAGE1_OPEN_TWO_CURSORS_OM_Query2
{
	public XE_HR_PACKAGE1_OPEN_TWO_CURSORS_OM_Query2()
	{
	}
	public XE_HR_PACKAGE1_OPEN_TWO_CURSORS_OM_Query2(
		Decimal dEPARTMENT_ID_,
		String dEPARTMENT_NAME_,
		Decimal? mANAGER_ID_,
		Decimal? lOCATION_ID_
	)
	{
		DEPARTMENT_ID = dEPARTMENT_ID_;
		DEPARTMENT_NAME = dEPARTMENT_NAME_;
		MANAGER_ID = mANAGER_ID_;
		LOCATION_ID = lOCATION_ID_;
	}
	/// <summary>
	/// SQL Data Type: NUMBER Chars: 22 Precision: 4 
	/// </summary>
	public virtual Decimal DEPARTMENT_ID { get; set; }
	/// <summary>
	/// SQL Data Type: VARCHAR2 Chars: 30 
	/// </summary>
	public virtual String DEPARTMENT_NAME { get; set; } = null!;
	/// <summary>
	/// SQL Data Type: NUMBER Chars: 22 Precision: 6 
	/// </summary>
	public virtual Decimal? MANAGER_ID { get; set; }
	/// <summary>
	/// SQL Data Type: NUMBER Chars: 22 Precision: 4 
	/// </summary>
	public virtual Decimal? LOCATION_ID { get; set; }
}
