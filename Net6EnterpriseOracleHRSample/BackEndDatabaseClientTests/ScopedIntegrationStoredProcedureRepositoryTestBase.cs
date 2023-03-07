/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202605 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XE_HR_BackEndDatabaseClient;
using XE_HR_BackEndCommon.Configuration;
namespace XE_HR_BackEndDatabaseClientTests.ScopedIntegrationTests;
using System.Data;
using Oracle.ManagedDataAccess.Types;
using Oracle.ManagedDataAccess.Client;
public class ScopedIntegrationStoredProcedureRepositoryTestBase
{
	protected CustomAppSettings? _customAppSettings;
	protected IDbConnection? _dbConnection;
	[TestInitialize()]
    public virtual void Init()
    {
		_customAppSettings = JsonConvert.DeserializeObject<CustomAppSettings>(File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "appSettings.Test.json")));
		_dbConnection = new OracleConnection(_customAppSettings!.DbConnection!);
	}
}
