/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202605 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Tynamix.ObjectFiller;
using XE_HR_Common.IndirectReferenceTransformerModels;
using XE_HR_BackEndSqlEntities.Entities;
using XE_HR_BackEndCommon.Services;
namespace XE_HR_CommonTests.HydratedDynamicIndirectReferenceTransformerModels;
public partial class XE_HR_HydratedDynamicIndirectReferenceTransformerModels : XE_HR_HydratedDynamicIndirectReferenceTransformerModelsBase
{
	protected Filler<XE_HR_EMP_DETAILS_VIEW_IR> _XE_HR_EMP_DETAILS_VIEW_IR_Filler = new Filler<XE_HR_EMP_DETAILS_VIEW_IR>();
	protected FillerSetup? _XE_HR_EMP_DETAILS_VIEW_IR_FillerSetup;
	public FillerSetup GetXE_HR_EMP_DETAILS_VIEW_IR_FillerSetup(Boolean onlyFillExplicitlyNamedProperties)
	{
		if (_XE_HR_EMP_DETAILS_VIEW_IR_FillerSetup != null)
			return _XE_HR_EMP_DETAILS_VIEW_IR_FillerSetup;
		_XE_HR_EMP_DETAILS_VIEW_IR_FillerSetup = _XE_HR_EMP_DETAILS_VIEW_IR_Filler.Setup(onlyFillExplicitlyNamedProperties)
		.OnProperty(x => x.EMPLOYEE_ID_IR).Use(() => _encryptionDecryptionService!.EncInt32(Convert.ToInt32(1)))
		.OnProperty(x => x.JOB_ID).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(10)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.MANAGER_ID_IR).Use(() => _encryptionDecryptionService!.EncInt32Nullable(Convert.ToInt32(1)))
		.OnProperty(x => x.DEPARTMENT_ID_IR).Use(() => _encryptionDecryptionService!.EncInt32Nullable(Convert.ToInt32(1)))
		.OnProperty(x => x.LOCATION_ID_IR).Use(() => _encryptionDecryptionService!.EncInt32Nullable(Convert.ToInt32(1)))
		.OnProperty(x => x.COUNTRY_ID).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(2)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.FIRST_NAME).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(20)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.LAST_NAME).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(25)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.SALARY).Use(() => Convert.ToDecimal(Random.Shared.NextDouble()))
		.OnProperty(x => x.COMMISSION_PCT).Use(() => Convert.ToDecimal(Random.Shared.NextDouble()))
		.OnProperty(x => x.DEPARTMENT_NAME).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(30)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.JOB_TITLE).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(35)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.CITY).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(30)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.STATE_PROVINCE).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(25)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.COUNTRY_NAME).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(40)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.REGION_NAME).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(25)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.Result;
		return _XE_HR_EMP_DETAILS_VIEW_IR_FillerSetup;
	}
	public XE_HR_EMP_DETAILS_VIEW_IR GetHydratedDynamicXE_HR_EMP_DETAILS_VIEW_IR(Boolean onlyFillExplicitlyNamedProperties = true)
	{
		return GetHydratedDynamicIEnumerableOfXE_HR_EMP_DETAILS_VIEW_IR(1, onlyFillExplicitlyNamedProperties).First();
	}
	public IEnumerable<XE_HR_EMP_DETAILS_VIEW_IR> GetHydratedDynamicIEnumerableOfXE_HR_EMP_DETAILS_VIEW_IR(Int32 numberToCreate, 
		Boolean onlyFillExplicitlyNamedProperties = true)
	{
		_XE_HR_EMP_DETAILS_VIEW_IR_Filler.Setup(GetXE_HR_EMP_DETAILS_VIEW_IR_FillerSetup(onlyFillExplicitlyNamedProperties));
		var retObjects =  _XE_HR_EMP_DETAILS_VIEW_IR_Filler.Create(numberToCreate);
		return retObjects;
	}
}
