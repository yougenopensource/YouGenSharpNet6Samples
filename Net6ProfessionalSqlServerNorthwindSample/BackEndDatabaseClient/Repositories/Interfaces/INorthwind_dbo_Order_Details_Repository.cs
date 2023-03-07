/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndDatabaseClient.Repositories;
public interface INorthwind_dbo_Order_Details_Repository : IGenericTableRepository<Northwind_dbo_Order_Details>
{
	Task<IEnumerable<Northwind_dbo_Order_Details>?> GetByOrderIDAndProductID(Int32 orderID_, Int32 productID_);
	Task<IEnumerable<Northwind_dbo_Order_Details>?> GetByOrderID(Int32 orderID_);
	Task<IEnumerable<Northwind_dbo_Order_Details>?> GetByProductID(Int32 productID_);
	Task UpdateByOrderIDAndProductID(Int32 orderID_, Int32 productID_, Northwind_dbo_Order_Details entity);
	Task UpdateByOrderID(Int32 orderID_, Northwind_dbo_Order_Details entity);
	Task UpdateByProductID(Int32 productID_, Northwind_dbo_Order_Details entity);
	Task DeleteByOrderIDAndProductID(Int32 orderID_, Int32 productID_);
	Task DeleteByOrderID(Int32 orderID_);
	Task DeleteByProductID(Int32 productID_);
}
