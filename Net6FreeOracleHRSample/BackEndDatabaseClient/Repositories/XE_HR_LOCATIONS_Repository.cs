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
public class XE_HR_LOCATIONS_Repository : GenericTableRepository<XE_HR_LOCATIONS>, IXE_HR_LOCATIONS_Repository
{
    private readonly ILogger<XE_HR_LOCATIONS_Repository> _logger;    
    public XE_HR_LOCATIONS_Repository
    (
        ILogger<XE_HR_LOCATIONS_Repository> logger
        ,XE_HR_Context dbContext
    ) : base(dbContext)
    {
        _logger = logger;
    }
	public async Task<IEnumerable<XE_HR_LOCATIONS>?> GetByCITY(String cITY_)
	{
		return await _dbContext.XE_HR_LOCATIONS!
			.Where(x => x.CITY == cITY_)
			.Include(x => x.LOC_C_ID_FK_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task<IEnumerable<XE_HR_LOCATIONS>?> GetByCOUNTRY_ID(String? cOUNTRY_ID_)
	{
		return await _dbContext.XE_HR_LOCATIONS!
			.Where(x => x.COUNTRY_ID == cOUNTRY_ID_)
			.Include(x => x.LOC_C_ID_FK_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task<IEnumerable<XE_HR_LOCATIONS>?> GetByLOCATION_ID(Int32 lOCATION_ID_)
	{
		return await _dbContext.XE_HR_LOCATIONS!
			.Where(x => x.LOCATION_ID == lOCATION_ID_)
			.Include(x => x.LOC_C_ID_FK_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task<IEnumerable<XE_HR_LOCATIONS>?> GetBySTATE_PROVINCE(String? sTATE_PROVINCE_)
	{
		return await _dbContext.XE_HR_LOCATIONS!
			.Where(x => x.STATE_PROVINCE == sTATE_PROVINCE_)
			.Include(x => x.LOC_C_ID_FK_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task UpdateByCITY(String cITY_, XE_HR_LOCATIONS entity)
	{
		await _dbContext.XE_HR_LOCATIONS!
			.Where(x => x.CITY == cITY_)
			.UpdateFromQueryAsync(x => new XE_HR_LOCATIONS(){ STREET_ADDRESS = entity.STREET_ADDRESS, POSTAL_CODE = entity.POSTAL_CODE, CITY = entity.CITY, STATE_PROVINCE = entity.STATE_PROVINCE, COUNTRY_ID = entity.COUNTRY_ID });
	}
	public async Task UpdateByCOUNTRY_ID(String? cOUNTRY_ID_, XE_HR_LOCATIONS entity)
	{
		await _dbContext.XE_HR_LOCATIONS!
			.Where(x => x.COUNTRY_ID == cOUNTRY_ID_)
			.UpdateFromQueryAsync(x => new XE_HR_LOCATIONS(){ STREET_ADDRESS = entity.STREET_ADDRESS, POSTAL_CODE = entity.POSTAL_CODE, CITY = entity.CITY, STATE_PROVINCE = entity.STATE_PROVINCE, COUNTRY_ID = entity.COUNTRY_ID });
	}
	public async Task UpdateByLOCATION_ID(Int32 lOCATION_ID_, XE_HR_LOCATIONS entity)
	{
		await _dbContext.XE_HR_LOCATIONS!
			.Where(x => x.LOCATION_ID == lOCATION_ID_)
			.UpdateFromQueryAsync(x => new XE_HR_LOCATIONS(){ STREET_ADDRESS = entity.STREET_ADDRESS, POSTAL_CODE = entity.POSTAL_CODE, CITY = entity.CITY, STATE_PROVINCE = entity.STATE_PROVINCE, COUNTRY_ID = entity.COUNTRY_ID });
	}
	public async Task UpdateBySTATE_PROVINCE(String? sTATE_PROVINCE_, XE_HR_LOCATIONS entity)
	{
		await _dbContext.XE_HR_LOCATIONS!
			.Where(x => x.STATE_PROVINCE == sTATE_PROVINCE_)
			.UpdateFromQueryAsync(x => new XE_HR_LOCATIONS(){ STREET_ADDRESS = entity.STREET_ADDRESS, POSTAL_CODE = entity.POSTAL_CODE, CITY = entity.CITY, STATE_PROVINCE = entity.STATE_PROVINCE, COUNTRY_ID = entity.COUNTRY_ID });
	}
	public async Task DeleteByCITY(String cITY_)
	{
		await _dbContext.XE_HR_LOCATIONS!
			.Where(x => x.CITY == cITY_)
			.DeleteFromQueryAsync();
	}
	public async Task DeleteByCOUNTRY_ID(String? cOUNTRY_ID_)
	{
		await _dbContext.XE_HR_LOCATIONS!
			.Where(x => x.COUNTRY_ID == cOUNTRY_ID_)
			.DeleteFromQueryAsync();
	}
	public async Task DeleteByLOCATION_ID(Int32 lOCATION_ID_)
	{
		await _dbContext.XE_HR_LOCATIONS!
			.Where(x => x.LOCATION_ID == lOCATION_ID_)
			.DeleteFromQueryAsync();
	}
	public async Task DeleteBySTATE_PROVINCE(String? sTATE_PROVINCE_)
	{
		await _dbContext.XE_HR_LOCATIONS!
			.Where(x => x.STATE_PROVINCE == sTATE_PROVINCE_)
			.DeleteFromQueryAsync();
	}
}
