/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202605 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
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
using XE_HR_BackEndSqlEntities.Entities;
using XE_HR_BackEndDatabaseClient.Repositories;
using XE_HR_BackEndDatabaseClientTests.HydratedStaticEntities;
using XE_HR_BackEndDatabaseClientTests.HydratedDynamicEntities;
namespace XE_HR_BackEndDatabaseClientTests.ScopedIntegrationTests;
[TestClass()]
public class XE_HR_DEPARTMENTS_Repository_Tests : ScopedIntegrationRepositoryTestBase
{
    private Mock<ILogger<XE_HR_DEPARTMENTS_Repository>>? _logger;
	private IXE_HR_DEPARTMENTS_Repository? _repository;
    private XE_HR_HydratedStaticEntities? _staticEntities;      
    private XE_HR_HydratedDynamicEntities? _dynamicEntities;      
	[TestInitialize()]
    public override void Init()
    {
        base.Init();
        _logger = new Mock<ILogger<XE_HR_DEPARTMENTS_Repository>>();		
        _repository = new XE_HR_DEPARTMENTS_Repository(_logger!.Object, _context!);
        _staticEntities = new XE_HR_HydratedStaticEntities();      
        _dynamicEntities = new XE_HR_HydratedDynamicEntities();        
    }
	private async Task<XE_HR_DEPARTMENTS?> StaticCreate()
	{
		var staticEntity = _staticEntities!.GetHydratedStaticXE_HR_DEPARTMENTS();
		return await _repository!.Create(staticEntity);
	}
	private async Task<XE_HR_DEPARTMENTS?> DynamicCreate()
	{
		var dynamicEntity = _dynamicEntities!.GetHydratedDynamicXE_HR_DEPARTMENTS();
		return await _repository!.Create(dynamicEntity);
	}
	private async Task<IEnumerable<XE_HR_DEPARTMENTS>?> GetAll()
	{
		await StaticCreate();
		await DynamicCreate();
		return await _repository!.GetAll();
	}
	[TestMethod()]
	public async Task GetAllTest()
	{
		// When
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task StaticGetByDEPARTMENT_IDTest()
	{
		// Given
		var staticEntity = await StaticCreate();
		// When
		var retData = await _repository!.GetByDEPARTMENT_ID(staticEntity!.DEPARTMENT_ID);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicGetByDEPARTMENT_IDTest()
	{
		// Given
		var dynamicEntity = await DynamicCreate();
		// When
		var retData = await _repository!.GetByDEPARTMENT_ID(dynamicEntity!.DEPARTMENT_ID);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task StaticGetByLOCATION_IDTest()
	{
		// Given
		var staticEntity = await StaticCreate();
		// When
		var retData = await _repository!.GetByLOCATION_ID(staticEntity!.LOCATION_ID);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicGetByLOCATION_IDTest()
	{
		// Given
		var dynamicEntity = await DynamicCreate();
		// When
		var retData = await _repository!.GetByLOCATION_ID(dynamicEntity!.LOCATION_ID);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task StaticCreateTest()
	{
		// When
		var staticEntity = await StaticCreate();
		// Then
		Assert.IsTrue(staticEntity != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicCreateTest()
	{
		// When
		var dynamicEntity = await DynamicCreate();
		// Then
		Assert.IsTrue(dynamicEntity != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task StaticUpdateByDEPARTMENT_IDTest()
	{
		// Given
		var staticEntity = await StaticCreate();
		// When
		// Optionally Modify Values
		await _repository!.UpdateByDEPARTMENT_ID(staticEntity!.DEPARTMENT_ID, staticEntity);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicUpdateByDEPARTMENT_IDTest()
	{
		// Given
		var dynamicEntity = await DynamicCreate();
		// When
		// Optionally Modify Values
		await _repository!.UpdateByDEPARTMENT_ID(dynamicEntity!.DEPARTMENT_ID, dynamicEntity);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task StaticUpdateByLOCATION_IDTest()
	{
		// Given
		var staticEntity = await StaticCreate();
		// When
		// Optionally Modify Values
		await _repository!.UpdateByLOCATION_ID(staticEntity!.LOCATION_ID, staticEntity);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicUpdateByLOCATION_IDTest()
	{
		// Given
		var dynamicEntity = await DynamicCreate();
		// When
		// Optionally Modify Values
		await _repository!.UpdateByLOCATION_ID(dynamicEntity!.LOCATION_ID, dynamicEntity);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task StaticDeleteByDEPARTMENT_IDTest()
	{
		// Given
		var staticEntity = await StaticCreate();
		// When
		await _repository!.DeleteByDEPARTMENT_ID(staticEntity!.DEPARTMENT_ID);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicDeleteByDEPARTMENT_IDTest()
	{
		// Given
		var dynamicEntity = await DynamicCreate();
		// When
		await _repository!.DeleteByDEPARTMENT_ID(dynamicEntity!.DEPARTMENT_ID);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task StaticDeleteByLOCATION_IDTest()
	{
		// Given
		var staticEntity = await StaticCreate();
		// When
		await _repository!.DeleteByLOCATION_ID(staticEntity!.LOCATION_ID);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicDeleteByLOCATION_IDTest()
	{
		// Given
		var dynamicEntity = await DynamicCreate();
		// When
		await _repository!.DeleteByLOCATION_ID(dynamicEntity!.LOCATION_ID);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
}
