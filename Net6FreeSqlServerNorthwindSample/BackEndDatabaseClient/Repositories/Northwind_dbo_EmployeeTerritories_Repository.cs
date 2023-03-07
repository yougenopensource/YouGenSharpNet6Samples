/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195435 on behalf of: ****
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
using Northwind_BackEndDatabaseClient;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndDatabaseClient.Repositories;
public class Northwind_dbo_EmployeeTerritories_Repository : GenericTableRepository<Northwind_dbo_EmployeeTerritories>, INorthwind_dbo_EmployeeTerritories_Repository
{
    private readonly ILogger<Northwind_dbo_EmployeeTerritories_Repository> _logger;    
    public Northwind_dbo_EmployeeTerritories_Repository
    (
        ILogger<Northwind_dbo_EmployeeTerritories_Repository> logger
        ,Northwind_Context dbContext
    ) : base(dbContext)
    {
        _logger = logger;
    }
	public async Task<IEnumerable<Northwind_dbo_EmployeeTerritories>?> GetByEmployeeIDAndTerritoryID(Int32 employeeID_, String territoryID_)
	{
		return await _dbContext.Northwind_dbo_EmployeeTerritories!
			.Where(x => x.EmployeeID == employeeID_ && x.TerritoryID == territoryID_)
			.Include(x => x.FK_EmployeeTerritories_Employees_Ref)
			.Include(x => x.FK_EmployeeTerritories_Territories_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task UpdateByEmployeeIDAndTerritoryID(Int32 employeeID_, String territoryID_, Northwind_dbo_EmployeeTerritories entity)
	{
		await _dbContext.Northwind_dbo_EmployeeTerritories!
			.Where(x => x.EmployeeID == employeeID_ && x.TerritoryID == territoryID_)
			.UpdateFromQueryAsync(x => new Northwind_dbo_EmployeeTerritories(){  });
	}
	public async Task DeleteByEmployeeIDAndTerritoryID(Int32 employeeID_, String territoryID_)
	{
		await _dbContext.Northwind_dbo_EmployeeTerritories!
			.Where(x => x.EmployeeID == employeeID_ && x.TerritoryID == territoryID_)
			.DeleteFromQueryAsync();
	}
}
