/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307201813 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Free Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use for evaluation purposes only. ****
**** This comment block must not be removed. ****
 */
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Z.EntityFramework.Plus;
using XE_HR_BackEndDatabaseClient;
using XE_HR_BackEndSqlEntities.Entities;
namespace XE_HR_BackEndDatabaseClient.Repositories;
public class XE_HR_JOB_HISTORY_Repository : GenericTableRepository<XE_HR_JOB_HISTORY>, IXE_HR_JOB_HISTORY_Repository
{
    private readonly ILogger<XE_HR_JOB_HISTORY_Repository> _logger;    
    public XE_HR_JOB_HISTORY_Repository
    (
        ILogger<XE_HR_JOB_HISTORY_Repository> logger
        ,XE_HR_Context dbContext
    ) : base(dbContext)
    {
        _logger = logger;
    }
	public async Task<IEnumerable<XE_HR_JOB_HISTORY>?> GetByEMPLOYEE_IDAndSTART_DATE(Int32 eMPLOYEE_ID_, DateTime sTART_DATE_)
	{
		return await _dbContext.XE_HR_JOB_HISTORY!
			.Where(x => x.EMPLOYEE_ID == eMPLOYEE_ID_ && x.START_DATE == sTART_DATE_)
			.Include(x => x.JHIST_DEPT_FK_Ref)
			.Include(x => x.JHIST_EMP_FK_Ref)
			.Include(x => x.JHIST_JOB_FK_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task<IEnumerable<XE_HR_JOB_HISTORY>?> GetByDEPARTMENT_ID(Int32? dEPARTMENT_ID_)
	{
		return await _dbContext.XE_HR_JOB_HISTORY!
			.Where(x => x.DEPARTMENT_ID == dEPARTMENT_ID_)
			.Include(x => x.JHIST_DEPT_FK_Ref)
			.Include(x => x.JHIST_EMP_FK_Ref)
			.Include(x => x.JHIST_JOB_FK_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task<IEnumerable<XE_HR_JOB_HISTORY>?> GetByEMPLOYEE_ID(Int32 eMPLOYEE_ID_)
	{
		return await _dbContext.XE_HR_JOB_HISTORY!
			.Where(x => x.EMPLOYEE_ID == eMPLOYEE_ID_)
			.Include(x => x.JHIST_DEPT_FK_Ref)
			.Include(x => x.JHIST_EMP_FK_Ref)
			.Include(x => x.JHIST_JOB_FK_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task<IEnumerable<XE_HR_JOB_HISTORY>?> GetByJOB_ID(String jOB_ID_)
	{
		return await _dbContext.XE_HR_JOB_HISTORY!
			.Where(x => x.JOB_ID == jOB_ID_)
			.Include(x => x.JHIST_DEPT_FK_Ref)
			.Include(x => x.JHIST_EMP_FK_Ref)
			.Include(x => x.JHIST_JOB_FK_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task UpdateByEMPLOYEE_IDAndSTART_DATE(Int32 eMPLOYEE_ID_, DateTime sTART_DATE_, XE_HR_JOB_HISTORY entity)
	{
		await _dbContext.XE_HR_JOB_HISTORY!
			.Where(x => x.EMPLOYEE_ID == eMPLOYEE_ID_ && x.START_DATE == sTART_DATE_)
			.UpdateFromQueryAsync(x => new XE_HR_JOB_HISTORY(){ END_DATE = entity.END_DATE, JOB_ID = entity.JOB_ID, DEPARTMENT_ID = entity.DEPARTMENT_ID });
	}
	public async Task UpdateByDEPARTMENT_ID(Int32? dEPARTMENT_ID_, XE_HR_JOB_HISTORY entity)
	{
		await _dbContext.XE_HR_JOB_HISTORY!
			.Where(x => x.DEPARTMENT_ID == dEPARTMENT_ID_)
			.UpdateFromQueryAsync(x => new XE_HR_JOB_HISTORY(){ END_DATE = entity.END_DATE, JOB_ID = entity.JOB_ID, DEPARTMENT_ID = entity.DEPARTMENT_ID });
	}
	public async Task UpdateByEMPLOYEE_ID(Int32 eMPLOYEE_ID_, XE_HR_JOB_HISTORY entity)
	{
		await _dbContext.XE_HR_JOB_HISTORY!
			.Where(x => x.EMPLOYEE_ID == eMPLOYEE_ID_)
			.UpdateFromQueryAsync(x => new XE_HR_JOB_HISTORY(){ END_DATE = entity.END_DATE, JOB_ID = entity.JOB_ID, DEPARTMENT_ID = entity.DEPARTMENT_ID });
	}
	public async Task UpdateByJOB_ID(String jOB_ID_, XE_HR_JOB_HISTORY entity)
	{
		await _dbContext.XE_HR_JOB_HISTORY!
			.Where(x => x.JOB_ID == jOB_ID_)
			.UpdateFromQueryAsync(x => new XE_HR_JOB_HISTORY(){ END_DATE = entity.END_DATE, JOB_ID = entity.JOB_ID, DEPARTMENT_ID = entity.DEPARTMENT_ID });
	}
	public async Task DeleteByEMPLOYEE_IDAndSTART_DATE(Int32 eMPLOYEE_ID_, DateTime sTART_DATE_)
	{
		await _dbContext.XE_HR_JOB_HISTORY!
			.Where(x => x.EMPLOYEE_ID == eMPLOYEE_ID_ && x.START_DATE == sTART_DATE_)
			.DeleteFromQueryAsync();
	}
	public async Task DeleteByDEPARTMENT_ID(Int32? dEPARTMENT_ID_)
	{
		await _dbContext.XE_HR_JOB_HISTORY!
			.Where(x => x.DEPARTMENT_ID == dEPARTMENT_ID_)
			.DeleteFromQueryAsync();
	}
	public async Task DeleteByEMPLOYEE_ID(Int32 eMPLOYEE_ID_)
	{
		await _dbContext.XE_HR_JOB_HISTORY!
			.Where(x => x.EMPLOYEE_ID == eMPLOYEE_ID_)
			.DeleteFromQueryAsync();
	}
	public async Task DeleteByJOB_ID(String jOB_ID_)
	{
		await _dbContext.XE_HR_JOB_HISTORY!
			.Where(x => x.JOB_ID == jOB_ID_)
			.DeleteFromQueryAsync();
	}
}
