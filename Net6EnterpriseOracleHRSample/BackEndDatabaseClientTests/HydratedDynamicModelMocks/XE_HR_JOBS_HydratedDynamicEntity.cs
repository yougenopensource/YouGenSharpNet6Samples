/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202605 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Tynamix.ObjectFiller;
using XE_HR_BackEndSqlEntities.Entities;
namespace XE_HR_BackEndDatabaseClientTests.HydratedDynamicEntities;
public partial class XE_HR_HydratedDynamicEntities  : XE_HR_HydratedDynamicEntitiesBase
{
	protected Filler<XE_HR_JOBS> _XE_HR_JOBS_Filler = new Filler<XE_HR_JOBS>();
	protected FillerSetup? _XE_HR_JOBS_FillerSetup;
	public FillerSetup GetXE_HR_JOBS_FillerSetup(Boolean onlyFillExplicitlyNamedProperties, 
		Boolean fillPrimaryKey = false)
	{
		if (_XE_HR_JOBS_FillerSetup != null)
			return _XE_HR_JOBS_FillerSetup;
		_XE_HR_JOBS_FillerSetup = _XE_HR_JOBS_Filler.Setup(onlyFillExplicitlyNamedProperties)
		.OnProperty(x => x.JOB_ID).Use(() => (fillPrimaryKey ? new String(Enumerable.Repeat(_chars, Convert.ToInt32(10)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()) : String.Empty))
		.OnProperty(x => x.JOB_TITLE).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(35)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.MIN_SALARY).Use(() => Random.Shared.Next(Int32.MinValue, Int32.MaxValue))
		.OnProperty(x => x.MAX_SALARY).Use(() => Random.Shared.Next(Int32.MinValue, Int32.MaxValue))
		// Entities that reference this entity by foreign key
		.OnProperty(x => x.EMP_JOB_FK_RefBy).IgnoreIt()
		.OnProperty(x => x.JHIST_JOB_FK_RefBy).IgnoreIt()
		.Result;
		return _XE_HR_JOBS_FillerSetup;
	}
	public XE_HR_JOBS GetHydratedDynamicXE_HR_JOBS(Boolean onlyFillExplicitlyNamedProperties = true, 
		Boolean fillPrimaryKey = false,	
		Boolean fillInnerForeignKeys = false, 
		Boolean fillInnerPrimaryKeyReferencedBy = false)
	{
		return GetHydratedDynamicIEnumerableOfXE_HR_JOBS(1,
			onlyFillExplicitlyNamedProperties, 
			fillPrimaryKey, 
			fillInnerForeignKeys, 
			fillInnerPrimaryKeyReferencedBy).First();
	}
	public IEnumerable<XE_HR_JOBS> GetHydratedDynamicIEnumerableOfXE_HR_JOBS(Int32 numberToCreate, 
		Boolean onlyFillExplicitlyNamedProperties = true, 
		Boolean fillPrimaryKey = false, 
		Boolean fillInnerForeignKeys = false, 
		Boolean fillInnerPrimaryKeyReferencedBy = false)
	{
		_XE_HR_JOBS_Filler.Setup(GetXE_HR_JOBS_FillerSetup(onlyFillExplicitlyNamedProperties, fillPrimaryKey));
		var retObjects = _XE_HR_JOBS_Filler.Create(numberToCreate);
		if (fillInnerForeignKeys) FillInnerForeignKeys(retObjects);
        if (fillInnerPrimaryKeyReferencedBy) FillInnerPrimaryKeyReferencedBy(retObjects);
		return retObjects;
	}
	private void FillInnerForeignKeys(IEnumerable<XE_HR_JOBS> entities)
	{
		foreach (var entity in entities)
		{
		}
	}
	private void FillInnerPrimaryKeyReferencedBy(IEnumerable<XE_HR_JOBS> entities)
	{
		foreach (var entity in entities)
		{
			// entity.EMP_JOB_FK_RefBy!.Add(GetHydratedDynamicXE_HR_EMPLOYEES());
			// entity.JHIST_JOB_FK_RefBy!.Add(GetHydratedDynamicXE_HR_JOB_HISTORY());
		}
	}
}
