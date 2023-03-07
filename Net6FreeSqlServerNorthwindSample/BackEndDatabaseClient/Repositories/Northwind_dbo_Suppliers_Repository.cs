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
public class Northwind_dbo_Suppliers_Repository : GenericTableRepository<Northwind_dbo_Suppliers>, INorthwind_dbo_Suppliers_Repository
{
    private readonly ILogger<Northwind_dbo_Suppliers_Repository> _logger;    
    public Northwind_dbo_Suppliers_Repository
    (
        ILogger<Northwind_dbo_Suppliers_Repository> logger
        ,Northwind_Context dbContext
    ) : base(dbContext)
    {
        _logger = logger;
    }
	public async Task<IEnumerable<Northwind_dbo_Suppliers>?> GetByCompanyName(String companyName_)
	{
		return await _dbContext.Northwind_dbo_Suppliers!
			.Where(x => x.CompanyName == companyName_)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task<IEnumerable<Northwind_dbo_Suppliers>?> GetBySupplierID(Int32 supplierID_)
	{
		return await _dbContext.Northwind_dbo_Suppliers!
			.Where(x => x.SupplierID == supplierID_)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task<IEnumerable<Northwind_dbo_Suppliers>?> GetByPostalCode(String? postalCode_)
	{
		return await _dbContext.Northwind_dbo_Suppliers!
			.Where(x => x.PostalCode == postalCode_)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task UpdateByCompanyName(String companyName_, Northwind_dbo_Suppliers entity)
	{
		await _dbContext.Northwind_dbo_Suppliers!
			.Where(x => x.CompanyName == companyName_)
			.UpdateFromQueryAsync(x => new Northwind_dbo_Suppliers(){ CompanyName = entity.CompanyName, ContactName = entity.ContactName, ContactTitle = entity.ContactTitle, Address = entity.Address, City = entity.City, Region = entity.Region, PostalCode = entity.PostalCode, Country = entity.Country, Phone = entity.Phone, Fax = entity.Fax, HomePage = entity.HomePage });
	}
	public async Task UpdateBySupplierID(Int32 supplierID_, Northwind_dbo_Suppliers entity)
	{
		await _dbContext.Northwind_dbo_Suppliers!
			.Where(x => x.SupplierID == supplierID_)
			.UpdateFromQueryAsync(x => new Northwind_dbo_Suppliers(){ CompanyName = entity.CompanyName, ContactName = entity.ContactName, ContactTitle = entity.ContactTitle, Address = entity.Address, City = entity.City, Region = entity.Region, PostalCode = entity.PostalCode, Country = entity.Country, Phone = entity.Phone, Fax = entity.Fax, HomePage = entity.HomePage });
	}
	public async Task UpdateByPostalCode(String? postalCode_, Northwind_dbo_Suppliers entity)
	{
		await _dbContext.Northwind_dbo_Suppliers!
			.Where(x => x.PostalCode == postalCode_)
			.UpdateFromQueryAsync(x => new Northwind_dbo_Suppliers(){ CompanyName = entity.CompanyName, ContactName = entity.ContactName, ContactTitle = entity.ContactTitle, Address = entity.Address, City = entity.City, Region = entity.Region, PostalCode = entity.PostalCode, Country = entity.Country, Phone = entity.Phone, Fax = entity.Fax, HomePage = entity.HomePage });
	}
	public async Task DeleteByCompanyName(String companyName_)
	{
		await _dbContext.Northwind_dbo_Suppliers!
			.Where(x => x.CompanyName == companyName_)
			.DeleteFromQueryAsync();
	}
	public async Task DeleteBySupplierID(Int32 supplierID_)
	{
		await _dbContext.Northwind_dbo_Suppliers!
			.Where(x => x.SupplierID == supplierID_)
			.DeleteFromQueryAsync();
	}
	public async Task DeleteByPostalCode(String? postalCode_)
	{
		await _dbContext.Northwind_dbo_Suppliers!
			.Where(x => x.PostalCode == postalCode_)
			.DeleteFromQueryAsync();
	}
}
