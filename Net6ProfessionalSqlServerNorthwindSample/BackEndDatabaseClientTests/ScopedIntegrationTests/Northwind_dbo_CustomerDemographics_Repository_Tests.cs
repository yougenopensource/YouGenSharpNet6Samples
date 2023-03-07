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
using Northwind_BackEndSqlEntities.Entities;
using Northwind_BackEndDatabaseClient.Repositories;
using Northwind_BackEndDatabaseClientTests.HydratedStaticEntities;
using Northwind_BackEndDatabaseClientTests.HydratedDynamicEntities;
namespace Northwind_BackEndDatabaseClientTests.ScopedIntegrationTests;
[TestClass()]
public class Northwind_dbo_CustomerDemographics_Repository_Tests : ScopedIntegrationRepositoryTestBase
{
    private Mock<ILogger<Northwind_dbo_CustomerDemographics_Repository>>? _logger;
	private INorthwind_dbo_CustomerDemographics_Repository? _repository;
    private Northwind_HydratedStaticEntities? _staticEntities;      
    private Northwind_HydratedDynamicEntities? _dynamicEntities;      
	[TestInitialize()]
    public override void Init()
    {
        base.Init();
        _logger = new Mock<ILogger<Northwind_dbo_CustomerDemographics_Repository>>();		
        _repository = new Northwind_dbo_CustomerDemographics_Repository(_logger!.Object, _context!);
        _staticEntities = new Northwind_HydratedStaticEntities();      
        _dynamicEntities = new Northwind_HydratedDynamicEntities();        
    }
	private async Task<Northwind_dbo_CustomerDemographics?> StaticCreate()
	{
		var staticEntity = _staticEntities!.GetHydratedStaticNorthwind_dbo_CustomerDemographics();
		return await _repository!.Create(staticEntity);
	}
	private async Task<Northwind_dbo_CustomerDemographics?> DynamicCreate()
	{
		var dynamicEntity = _dynamicEntities!.GetHydratedDynamicNorthwind_dbo_CustomerDemographics();
		return await _repository!.Create(dynamicEntity);
	}
	private async Task<IEnumerable<Northwind_dbo_CustomerDemographics>?> GetAll()
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
	public async Task StaticGetByCustomerTypeIDTest()
	{
		// Given
		var staticEntity = await StaticCreate();
		// When
		var retData = await _repository!.GetByCustomerTypeID(staticEntity!.CustomerTypeID);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicGetByCustomerTypeIDTest()
	{
		// Given
		var dynamicEntity = await DynamicCreate();
		// When
		var retData = await _repository!.GetByCustomerTypeID(dynamicEntity!.CustomerTypeID);
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
	public async Task StaticUpdateByCustomerTypeIDTest()
	{
		// Given
		var staticEntity = await StaticCreate();
		// When
		// Optionally Modify Values
		await _repository!.UpdateByCustomerTypeID(staticEntity!.CustomerTypeID, staticEntity);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicUpdateByCustomerTypeIDTest()
	{
		// Given
		var dynamicEntity = await DynamicCreate();
		// When
		// Optionally Modify Values
		await _repository!.UpdateByCustomerTypeID(dynamicEntity!.CustomerTypeID, dynamicEntity);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task StaticDeleteByCustomerTypeIDTest()
	{
		// Given
		var staticEntity = await StaticCreate();
		// When
		await _repository!.DeleteByCustomerTypeID(staticEntity!.CustomerTypeID);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicDeleteByCustomerTypeIDTest()
	{
		// Given
		var dynamicEntity = await DynamicCreate();
		// When
		await _repository!.DeleteByCustomerTypeID(dynamicEntity!.CustomerTypeID);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
}
