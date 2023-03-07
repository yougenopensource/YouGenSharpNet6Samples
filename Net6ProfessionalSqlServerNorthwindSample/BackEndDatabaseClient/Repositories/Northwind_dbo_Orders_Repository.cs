/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Z.EntityFramework.Plus;
using Northwind_BackEndDatabaseClient;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndDatabaseClient.Repositories;
public class Northwind_dbo_Orders_Repository : GenericTableRepository<Northwind_dbo_Orders>, INorthwind_dbo_Orders_Repository
{
    private readonly ILogger<Northwind_dbo_Orders_Repository> _logger;    
    public Northwind_dbo_Orders_Repository
    (
        ILogger<Northwind_dbo_Orders_Repository> logger
        ,Northwind_Context dbContext
    ) : base(dbContext)
    {
        _logger = logger;
    }
	public async Task<IEnumerable<Northwind_dbo_Orders>?> GetByCustomerID(String? customerID_)
	{
		return await _dbContext.Northwind_dbo_Orders!
			.Where(x => x.CustomerID == customerID_)
			.Include(x => x.FK_Orders_Customers_Ref)
			.Include(x => x.FK_Orders_Employees_Ref)
			.Include(x => x.FK_Orders_Shippers_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task<IEnumerable<Northwind_dbo_Orders>?> GetByEmployeeID(Int32? employeeID_)
	{
		return await _dbContext.Northwind_dbo_Orders!
			.Where(x => x.EmployeeID == employeeID_)
			.Include(x => x.FK_Orders_Customers_Ref)
			.Include(x => x.FK_Orders_Employees_Ref)
			.Include(x => x.FK_Orders_Shippers_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task<IEnumerable<Northwind_dbo_Orders>?> GetByOrderDate(DateTime? orderDate_)
	{
		return await _dbContext.Northwind_dbo_Orders!
			.Where(x => x.OrderDate == orderDate_)
			.Include(x => x.FK_Orders_Customers_Ref)
			.Include(x => x.FK_Orders_Employees_Ref)
			.Include(x => x.FK_Orders_Shippers_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task<IEnumerable<Northwind_dbo_Orders>?> GetByOrderID(Int32 orderID_)
	{
		return await _dbContext.Northwind_dbo_Orders!
			.Where(x => x.OrderID == orderID_)
			.Include(x => x.FK_Orders_Customers_Ref)
			.Include(x => x.FK_Orders_Employees_Ref)
			.Include(x => x.FK_Orders_Shippers_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task<IEnumerable<Northwind_dbo_Orders>?> GetByShippedDate(DateTime? shippedDate_)
	{
		return await _dbContext.Northwind_dbo_Orders!
			.Where(x => x.ShippedDate == shippedDate_)
			.Include(x => x.FK_Orders_Customers_Ref)
			.Include(x => x.FK_Orders_Employees_Ref)
			.Include(x => x.FK_Orders_Shippers_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task<IEnumerable<Northwind_dbo_Orders>?> GetByShipVia(Int32? shipVia_)
	{
		return await _dbContext.Northwind_dbo_Orders!
			.Where(x => x.ShipVia == shipVia_)
			.Include(x => x.FK_Orders_Customers_Ref)
			.Include(x => x.FK_Orders_Employees_Ref)
			.Include(x => x.FK_Orders_Shippers_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task<IEnumerable<Northwind_dbo_Orders>?> GetByShipPostalCode(String? shipPostalCode_)
	{
		return await _dbContext.Northwind_dbo_Orders!
			.Where(x => x.ShipPostalCode == shipPostalCode_)
			.Include(x => x.FK_Orders_Customers_Ref)
			.Include(x => x.FK_Orders_Employees_Ref)
			.Include(x => x.FK_Orders_Shippers_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task UpdateByCustomerID(String? customerID_, Northwind_dbo_Orders entity)
	{
		await _dbContext.Northwind_dbo_Orders!
			.Where(x => x.CustomerID == customerID_)
			.UpdateFromQueryAsync(x => new Northwind_dbo_Orders(){ CustomerID = entity.CustomerID, EmployeeID = entity.EmployeeID, OrderDate = entity.OrderDate, RequiredDate = entity.RequiredDate, ShippedDate = entity.ShippedDate, ShipVia = entity.ShipVia, Freight = entity.Freight, ShipName = entity.ShipName, ShipAddress = entity.ShipAddress, ShipCity = entity.ShipCity, ShipRegion = entity.ShipRegion, ShipPostalCode = entity.ShipPostalCode, ShipCountry = entity.ShipCountry });
	}
	public async Task UpdateByEmployeeID(Int32? employeeID_, Northwind_dbo_Orders entity)
	{
		await _dbContext.Northwind_dbo_Orders!
			.Where(x => x.EmployeeID == employeeID_)
			.UpdateFromQueryAsync(x => new Northwind_dbo_Orders(){ CustomerID = entity.CustomerID, EmployeeID = entity.EmployeeID, OrderDate = entity.OrderDate, RequiredDate = entity.RequiredDate, ShippedDate = entity.ShippedDate, ShipVia = entity.ShipVia, Freight = entity.Freight, ShipName = entity.ShipName, ShipAddress = entity.ShipAddress, ShipCity = entity.ShipCity, ShipRegion = entity.ShipRegion, ShipPostalCode = entity.ShipPostalCode, ShipCountry = entity.ShipCountry });
	}
	public async Task UpdateByOrderDate(DateTime? orderDate_, Northwind_dbo_Orders entity)
	{
		await _dbContext.Northwind_dbo_Orders!
			.Where(x => x.OrderDate == orderDate_)
			.UpdateFromQueryAsync(x => new Northwind_dbo_Orders(){ CustomerID = entity.CustomerID, EmployeeID = entity.EmployeeID, OrderDate = entity.OrderDate, RequiredDate = entity.RequiredDate, ShippedDate = entity.ShippedDate, ShipVia = entity.ShipVia, Freight = entity.Freight, ShipName = entity.ShipName, ShipAddress = entity.ShipAddress, ShipCity = entity.ShipCity, ShipRegion = entity.ShipRegion, ShipPostalCode = entity.ShipPostalCode, ShipCountry = entity.ShipCountry });
	}
	public async Task UpdateByOrderID(Int32 orderID_, Northwind_dbo_Orders entity)
	{
		await _dbContext.Northwind_dbo_Orders!
			.Where(x => x.OrderID == orderID_)
			.UpdateFromQueryAsync(x => new Northwind_dbo_Orders(){ CustomerID = entity.CustomerID, EmployeeID = entity.EmployeeID, OrderDate = entity.OrderDate, RequiredDate = entity.RequiredDate, ShippedDate = entity.ShippedDate, ShipVia = entity.ShipVia, Freight = entity.Freight, ShipName = entity.ShipName, ShipAddress = entity.ShipAddress, ShipCity = entity.ShipCity, ShipRegion = entity.ShipRegion, ShipPostalCode = entity.ShipPostalCode, ShipCountry = entity.ShipCountry });
	}
	public async Task UpdateByShippedDate(DateTime? shippedDate_, Northwind_dbo_Orders entity)
	{
		await _dbContext.Northwind_dbo_Orders!
			.Where(x => x.ShippedDate == shippedDate_)
			.UpdateFromQueryAsync(x => new Northwind_dbo_Orders(){ CustomerID = entity.CustomerID, EmployeeID = entity.EmployeeID, OrderDate = entity.OrderDate, RequiredDate = entity.RequiredDate, ShippedDate = entity.ShippedDate, ShipVia = entity.ShipVia, Freight = entity.Freight, ShipName = entity.ShipName, ShipAddress = entity.ShipAddress, ShipCity = entity.ShipCity, ShipRegion = entity.ShipRegion, ShipPostalCode = entity.ShipPostalCode, ShipCountry = entity.ShipCountry });
	}
	public async Task UpdateByShipVia(Int32? shipVia_, Northwind_dbo_Orders entity)
	{
		await _dbContext.Northwind_dbo_Orders!
			.Where(x => x.ShipVia == shipVia_)
			.UpdateFromQueryAsync(x => new Northwind_dbo_Orders(){ CustomerID = entity.CustomerID, EmployeeID = entity.EmployeeID, OrderDate = entity.OrderDate, RequiredDate = entity.RequiredDate, ShippedDate = entity.ShippedDate, ShipVia = entity.ShipVia, Freight = entity.Freight, ShipName = entity.ShipName, ShipAddress = entity.ShipAddress, ShipCity = entity.ShipCity, ShipRegion = entity.ShipRegion, ShipPostalCode = entity.ShipPostalCode, ShipCountry = entity.ShipCountry });
	}
	public async Task UpdateByShipPostalCode(String? shipPostalCode_, Northwind_dbo_Orders entity)
	{
		await _dbContext.Northwind_dbo_Orders!
			.Where(x => x.ShipPostalCode == shipPostalCode_)
			.UpdateFromQueryAsync(x => new Northwind_dbo_Orders(){ CustomerID = entity.CustomerID, EmployeeID = entity.EmployeeID, OrderDate = entity.OrderDate, RequiredDate = entity.RequiredDate, ShippedDate = entity.ShippedDate, ShipVia = entity.ShipVia, Freight = entity.Freight, ShipName = entity.ShipName, ShipAddress = entity.ShipAddress, ShipCity = entity.ShipCity, ShipRegion = entity.ShipRegion, ShipPostalCode = entity.ShipPostalCode, ShipCountry = entity.ShipCountry });
	}
	public async Task DeleteByCustomerID(String? customerID_)
	{
		await _dbContext.Northwind_dbo_Orders!
			.Where(x => x.CustomerID == customerID_)
			.DeleteFromQueryAsync();
	}
	public async Task DeleteByEmployeeID(Int32? employeeID_)
	{
		await _dbContext.Northwind_dbo_Orders!
			.Where(x => x.EmployeeID == employeeID_)
			.DeleteFromQueryAsync();
	}
	public async Task DeleteByOrderDate(DateTime? orderDate_)
	{
		await _dbContext.Northwind_dbo_Orders!
			.Where(x => x.OrderDate == orderDate_)
			.DeleteFromQueryAsync();
	}
	public async Task DeleteByOrderID(Int32 orderID_)
	{
		await _dbContext.Northwind_dbo_Orders!
			.Where(x => x.OrderID == orderID_)
			.DeleteFromQueryAsync();
	}
	public async Task DeleteByShippedDate(DateTime? shippedDate_)
	{
		await _dbContext.Northwind_dbo_Orders!
			.Where(x => x.ShippedDate == shippedDate_)
			.DeleteFromQueryAsync();
	}
	public async Task DeleteByShipVia(Int32? shipVia_)
	{
		await _dbContext.Northwind_dbo_Orders!
			.Where(x => x.ShipVia == shipVia_)
			.DeleteFromQueryAsync();
	}
	public async Task DeleteByShipPostalCode(String? shipPostalCode_)
	{
		await _dbContext.Northwind_dbo_Orders!
			.Where(x => x.ShipPostalCode == shipPostalCode_)
			.DeleteFromQueryAsync();
	}
}
