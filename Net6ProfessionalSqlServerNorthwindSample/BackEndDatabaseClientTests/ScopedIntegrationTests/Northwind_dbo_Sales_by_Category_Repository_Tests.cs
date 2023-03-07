/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Northwind_BackEndDatabaseClient.Repositories;
namespace Northwind_BackEndDatabaseClientTests.ScopedIntegrationTests;
[TestClass()]
public class Northwind_dbo_Sales_by_Category_Repository_Tests : ScopedIntegrationRepositoryTestBase
{
    private Mock<ILogger<Northwind_dbo_Sales_by_Category_Repository>>? _logger;
	private INorthwind_dbo_Sales_by_Category_Repository? _repository;
	[TestInitialize()]
    public override void Init()
    {
        base.Init();
        _logger = new Mock<ILogger<Northwind_dbo_Sales_by_Category_Repository>>();		
        _repository = new Northwind_dbo_Sales_by_Category_Repository(_logger!.Object, _context!);
    }
	[TestMethod()]
	public async Task GetAllTest()
	{
		// When
		var retData = await _repository!.GetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
}
