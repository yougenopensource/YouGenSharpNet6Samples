/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202605 on behalf of: ****
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
namespace XE_HR_Common.IndirectReferenceTransformerModels;
/// <summary>
/// Sql Entity Description: Model Description: Stored Procedure Output Model Query 2
/// </summary>
public class XE_HR_PACKAGE1_OPEN_TWO_CURSORS_OM_Query2_IR
{
	public XE_HR_PACKAGE1_OPEN_TWO_CURSORS_OM_Query2_IR() 
	{
	} 
	public XE_HR_PACKAGE1_OPEN_TWO_CURSORS_OM_Query2_IR(
		String? dEPARTMENT_ID_IR_,
		String dEPARTMENT_NAME_,
		String? mANAGER_ID_IR_,
		String? lOCATION_ID_IR_
	)
	{
		DEPARTMENT_ID_IR = dEPARTMENT_ID_IR_;
		DEPARTMENT_NAME = dEPARTMENT_NAME_;
		MANAGER_ID_IR = mANAGER_ID_IR_;
		LOCATION_ID_IR = lOCATION_ID_IR_;
	}
	[JsonConstructor]
	public XE_HR_PACKAGE1_OPEN_TWO_CURSORS_OM_Query2_IR(
		String? DEPARTMENT_ID_IR,
		String? DEPARTMENT_ID_IR_OriginalValue,
		Boolean DEPARTMENT_ID_IR_HasBeenChanged,
		String? DEPARTMENT_NAME,
		String? DEPARTMENT_NAME_OriginalValue,
		Boolean DEPARTMENT_NAME_HasBeenChanged,
		String? MANAGER_ID_IR,
		String? MANAGER_ID_IR_OriginalValue,
		Boolean MANAGER_ID_IR_HasBeenChanged,
		String? LOCATION_ID_IR,
		String? LOCATION_ID_IR_OriginalValue,
		Boolean LOCATION_ID_IR_HasBeenChanged
	)
	{
		this.DEPARTMENT_ID_IR = DEPARTMENT_ID_IR;
		this.DEPARTMENT_ID_IR_OriginalValue = DEPARTMENT_ID_IR_OriginalValue;
		this.DEPARTMENT_ID_IR_HasBeenChanged = DEPARTMENT_ID_IR_HasBeenChanged;
		this.DEPARTMENT_NAME = DEPARTMENT_NAME;
		this.DEPARTMENT_NAME_OriginalValue = DEPARTMENT_NAME_OriginalValue;
		this.DEPARTMENT_NAME_HasBeenChanged = DEPARTMENT_NAME_HasBeenChanged;
		this.MANAGER_ID_IR = MANAGER_ID_IR;
		this.MANAGER_ID_IR_OriginalValue = MANAGER_ID_IR_OriginalValue;
		this.MANAGER_ID_IR_HasBeenChanged = MANAGER_ID_IR_HasBeenChanged;
		this.LOCATION_ID_IR = LOCATION_ID_IR;
		this.LOCATION_ID_IR_OriginalValue = LOCATION_ID_IR_OriginalValue;
		this.LOCATION_ID_IR_HasBeenChanged = LOCATION_ID_IR_HasBeenChanged;
	}
	public String? DEPARTMENT_ID_IR
	{
		get => _dEPARTMENT_ID_IR;
		set
		{
			_dEPARTMENT_ID_IR = value;
			DEPARTMENT_ID_IR_HasBeenChanged = _dEPARTMENT_ID_IR == DEPARTMENT_ID_IR_OriginalValue ? false : true;
		}
	}
	private String? _dEPARTMENT_ID_IR;
	public String? DEPARTMENT_ID_IR_OriginalValue { get; private set; }
	public Boolean DEPARTMENT_ID_IR_HasBeenChanged { get; private set; }
	public String? DEPARTMENT_NAME
	{
		get => _dEPARTMENT_NAME;
		set
		{
			_dEPARTMENT_NAME = value;
			DEPARTMENT_NAME_HasBeenChanged = _dEPARTMENT_NAME == DEPARTMENT_NAME_OriginalValue ? false : true;
		}
	}
	private String? _dEPARTMENT_NAME;
	public String? DEPARTMENT_NAME_OriginalValue { get; private set; }
	public Boolean DEPARTMENT_NAME_HasBeenChanged { get; private set; }
	public String? MANAGER_ID_IR
	{
		get => _mANAGER_ID_IR;
		set
		{
			_mANAGER_ID_IR = value;
			MANAGER_ID_IR_HasBeenChanged = _mANAGER_ID_IR == MANAGER_ID_IR_OriginalValue ? false : true;
		}
	}
	private String? _mANAGER_ID_IR;
	public String? MANAGER_ID_IR_OriginalValue { get; private set; }
	public Boolean MANAGER_ID_IR_HasBeenChanged { get; private set; }
	public String? LOCATION_ID_IR
	{
		get => _lOCATION_ID_IR;
		set
		{
			_lOCATION_ID_IR = value;
			LOCATION_ID_IR_HasBeenChanged = _lOCATION_ID_IR == LOCATION_ID_IR_OriginalValue ? false : true;
		}
	}
	private String? _lOCATION_ID_IR;
	public String? LOCATION_ID_IR_OriginalValue { get; private set; }
	public Boolean LOCATION_ID_IR_HasBeenChanged { get; private set; }
}
