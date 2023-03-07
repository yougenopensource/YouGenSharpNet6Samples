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
/// SQL Entity Description: Stored Procedure Input Model Parameters
/// </summary>
public class XE_HR_PACKAGE1_PARAMOUTCURSORS_IM
{
	public XE_HR_PACKAGE1_PARAMOUTCURSORS_IM()
	{
	}
	public XE_HR_PACKAGE1_PARAMOUTCURSORS_IM(
		Int32? vAR_INPUT_,
		DateTime? vAR_DATE_INPUT_
	)
	{
		VAR_INPUT = vAR_INPUT_;
		VAR_DATE_INPUT = vAR_DATE_INPUT_;
	}
	/// <summary>
	/// SQL Data Type: NUMBER Chars: 0 Scale: 38 
	/// </summary>
	public virtual Int32? VAR_INPUT { get; set; }
	/// <summary>
	/// SQL Data Type: DATE Chars: 0 
	/// </summary>
	public virtual DateTime? VAR_DATE_INPUT { get; set; }
}