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
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndDatabaseClient.Repositories;
public class Northwind_dbo_Quarterly_Orders_Repository : GenericRepository<Northwind_dbo_Quarterly_Orders>, INorthwind_dbo_Quarterly_Orders_Repository
{
    private readonly ILogger<Northwind_dbo_Quarterly_Orders_Repository> _logger;    
    public Northwind_dbo_Quarterly_Orders_Repository
    (
        ILogger<Northwind_dbo_Quarterly_Orders_Repository> logger
        ,Northwind_Context dbContext
    ) : base(dbContext)
    {
        _logger = logger;
    }
}
