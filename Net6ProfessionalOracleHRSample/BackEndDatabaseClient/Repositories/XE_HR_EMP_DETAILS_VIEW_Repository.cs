/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202507 on behalf of: ****
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
using XE_HR_BackEndSqlEntities.Entities;
namespace XE_HR_BackEndDatabaseClient.Repositories;
public class XE_HR_EMP_DETAILS_VIEW_Repository : GenericRepository<XE_HR_EMP_DETAILS_VIEW>, IXE_HR_EMP_DETAILS_VIEW_Repository
{
    private readonly ILogger<XE_HR_EMP_DETAILS_VIEW_Repository> _logger;    
    public XE_HR_EMP_DETAILS_VIEW_Repository
    (
        ILogger<XE_HR_EMP_DETAILS_VIEW_Repository> logger
        ,XE_HR_Context dbContext
    ) : base(dbContext)
    {
        _logger = logger;
    }
}
