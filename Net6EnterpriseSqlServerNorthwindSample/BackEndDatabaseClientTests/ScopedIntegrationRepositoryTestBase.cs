/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
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
using Northwind_BackEndDatabaseClient;
using Northwind_BackEndCommon.Configuration;
namespace Northwind_BackEndDatabaseClientTests.ScopedIntegrationTests;
public class ScopedIntegrationRepositoryTestBase
{
	protected Northwind_Context? _context;
	protected CustomAppSettings? _customAppSettings;
	[TestInitialize()]
    public virtual void Init()
    {
		var useInMemoryDb = false;
		if (useInMemoryDb)
		{
			var options = new DbContextOptionsBuilder<Northwind_Context>()
			     .UseInMemoryDatabase("Northwind",
			         opt => opt.UseHierarchyId())
			     .Options;
			_context = new Northwind_Context(options);
		}
		else
		{
			_customAppSettings = JsonConvert.DeserializeObject<CustomAppSettings>(File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "appSettings.Test.json")));
			var options = new DbContextOptionsBuilder<Northwind_Context>()
			     .UseSqlServer(_customAppSettings!.DbConnection!,
			         opt => opt.UseHierarchyId())
			     .Options;
			_context = new Northwind_Context(options);
		}
	}
}
