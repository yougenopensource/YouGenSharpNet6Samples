/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Northwind_Common.IndirectReferenceTransformerModels;
using Northwind_FrontEndHttpClient.HttpClients;
using Northwind_FrontEndHttpClientTests;
using Northwind_CommonTests.HydratedDynamicIndirectReferenceTransformerModels;
using Northwind_CommonTests.HydratedStaticIndirectReferenceTransformerModels;
namespace Northwind_FrontEndHttpClientTests.ScopedIntegrationTests;
[TestClass()]
public class Northwind_dbo_Region_HttpClient_Tests : HttpClientTestBase
{
	protected INorthwind_dbo_Region_HttpClient? _specificHttpClient;
	private Northwind_HydratedDynamicIndirectReferenceTransformerModels? _dynamicIRModels;
	private Northwind_HydratedStaticIndirectReferenceTransformerModels? _staticIRModels;
	[TestInitialize()]
    public override void Init()
    {
        base.Init();
		_dynamicIRModels = new Northwind_HydratedDynamicIndirectReferenceTransformerModels();
		_staticIRModels = new Northwind_HydratedStaticIndirectReferenceTransformerModels();
        _specificHttpClient = new Northwind_dbo_Region_HttpClient(_httpClient!);
    }
	[TestMethod()]
	public async Task GetAllTest()
	{
		// When
		var retData = await _specificHttpClient!.GetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task CreateDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Region_IR();
		// When
		var retData = await _specificHttpClient!.Create(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task CreateStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Region_IR();
		// When
		var retData = await _specificHttpClient!.Create(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByRegionIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Region_IR();
		// When
		var retData = await _specificHttpClient!.GetByRegionID(input.RegionID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByRegionIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Region_IR();
		// When
		var retData = await _specificHttpClient!.GetByRegionID(input.RegionID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByRegionIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Region_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Region_IR();
		// When
		await _specificHttpClient!.UpdateByRegionID(input.RegionID_IR ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByRegionIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Region_IR();
		// When
		await _specificHttpClient!.UpdateByRegionID(input.RegionID_IR ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByRegionIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Region_IR();
		// When
		await _specificHttpClient!.DeleteByRegionID(input.RegionID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByRegionIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Region_IR();
		// When
		await _specificHttpClient!.DeleteByRegionID(input.RegionID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
}
