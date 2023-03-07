/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndDatabaseClient.Repositories;
public interface INorthwind_dbo_Shippers_Repository : IGenericTableRepository<Northwind_dbo_Shippers>
{
	Task<IEnumerable<Northwind_dbo_Shippers>?> GetByShipperID(Int32 shipperID_);
	Task UpdateByShipperID(Int32 shipperID_, Northwind_dbo_Shippers entity);
	Task DeleteByShipperID(Int32 shipperID_);
}
