/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195656 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Standard Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndDatabaseClient.Repositories;
public interface INorthwind_dbo_Customers_Repository : IGenericTableRepository<Northwind_dbo_Customers>
{
	Task<IEnumerable<Northwind_dbo_Customers>?> GetByCity(String? city_);
	Task<IEnumerable<Northwind_dbo_Customers>?> GetByCompanyName(String companyName_);
	Task<IEnumerable<Northwind_dbo_Customers>?> GetByCustomerID(String customerID_);
	Task<IEnumerable<Northwind_dbo_Customers>?> GetByPostalCode(String? postalCode_);
	Task<IEnumerable<Northwind_dbo_Customers>?> GetByRegion(String? region_);
	Task UpdateByCity(String? city_, Northwind_dbo_Customers entity);
	Task UpdateByCompanyName(String companyName_, Northwind_dbo_Customers entity);
	Task UpdateByCustomerID(String customerID_, Northwind_dbo_Customers entity);
	Task UpdateByPostalCode(String? postalCode_, Northwind_dbo_Customers entity);
	Task UpdateByRegion(String? region_, Northwind_dbo_Customers entity);
	Task DeleteByCity(String? city_);
	Task DeleteByCompanyName(String companyName_);
	Task DeleteByCustomerID(String customerID_);
	Task DeleteByPostalCode(String? postalCode_);
	Task DeleteByRegion(String? region_);
}
