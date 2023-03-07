/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195656 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Standard Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Z.EntityFramework.Plus;
using Northwind_BackEndDatabaseClient;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndDatabaseClient.Repositories;
public class Northwind_dbo_CustomerDemographics_Repository : GenericTableRepository<Northwind_dbo_CustomerDemographics>, INorthwind_dbo_CustomerDemographics_Repository
{
    private readonly ILogger<Northwind_dbo_CustomerDemographics_Repository> _logger;    
    public Northwind_dbo_CustomerDemographics_Repository
    (
        ILogger<Northwind_dbo_CustomerDemographics_Repository> logger
        ,Northwind_Context dbContext
    ) : base(dbContext)
    {
        _logger = logger;
    }
	public async Task<IEnumerable<Northwind_dbo_CustomerDemographics>?> GetByCustomerTypeID(String customerTypeID_)
	{
		return await _dbContext.Northwind_dbo_CustomerDemographics!
			.Where(x => x.CustomerTypeID == customerTypeID_)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task UpdateByCustomerTypeID(String customerTypeID_, Northwind_dbo_CustomerDemographics entity)
	{
		await _dbContext.Northwind_dbo_CustomerDemographics!
			.Where(x => x.CustomerTypeID == customerTypeID_)
			.UpdateFromQueryAsync(x => new Northwind_dbo_CustomerDemographics(){ CustomerDesc = entity.CustomerDesc });
	}
	public async Task DeleteByCustomerTypeID(String customerTypeID_)
	{
		await _dbContext.Northwind_dbo_CustomerDemographics!
			.Where(x => x.CustomerTypeID == customerTypeID_)
			.DeleteFromQueryAsync();
	}
}
