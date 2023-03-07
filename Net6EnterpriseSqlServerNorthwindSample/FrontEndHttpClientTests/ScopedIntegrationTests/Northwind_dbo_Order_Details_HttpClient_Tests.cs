/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
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
public class Northwind_dbo_Order_Details_HttpClient_Tests : HttpClientTestBase
{
	protected INorthwind_dbo_Order_Details_HttpClient? _specificHttpClient;
	private Northwind_HydratedDynamicIndirectReferenceTransformerModels? _dynamicIRModels;
	private Northwind_HydratedStaticIndirectReferenceTransformerModels? _staticIRModels;
	[TestInitialize()]
    public override void Init()
    {
        base.Init();
		_dynamicIRModels = new Northwind_HydratedDynamicIndirectReferenceTransformerModels();
		_staticIRModels = new Northwind_HydratedStaticIndirectReferenceTransformerModels();
        _specificHttpClient = new Northwind_dbo_Order_Details_HttpClient(_httpClient!);
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
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Order_Details_IR();
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
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Order_Details_IR();
		// When
		var retData = await _specificHttpClient!.Create(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByOrderIDAndProductIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Order_Details_IR();
		// When
		var retData = await _specificHttpClient!.GetByOrderIDAndProductID(input.OrderID_IR ?? String.Empty, input.ProductID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByOrderIDAndProductIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Order_Details_IR();
		// When
		var retData = await _specificHttpClient!.GetByOrderIDAndProductID(input.OrderID_IR ?? String.Empty, input.ProductID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByOrderIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Order_Details_IR();
		// When
		var retData = await _specificHttpClient!.GetByOrderID(input.OrderID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByOrderIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Order_Details_IR();
		// When
		var retData = await _specificHttpClient!.GetByOrderID(input.OrderID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByProductIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Order_Details_IR();
		// When
		var retData = await _specificHttpClient!.GetByProductID(input.ProductID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByProductIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Order_Details_IR();
		// When
		var retData = await _specificHttpClient!.GetByProductID(input.ProductID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByOrderIDAndProductIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Order_Details_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Order_Details_IR();
		// When
		await _specificHttpClient!.UpdateByOrderIDAndProductID(input.OrderID_IR ?? String.Empty, input.ProductID_IR ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByOrderIDAndProductIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Order_Details_IR();
		// When
		await _specificHttpClient!.UpdateByOrderIDAndProductID(input.OrderID_IR ?? String.Empty, input.ProductID_IR ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByOrderIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Order_Details_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Order_Details_IR();
		// When
		await _specificHttpClient!.UpdateByOrderID(input.OrderID_IR ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByOrderIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Order_Details_IR();
		// When
		await _specificHttpClient!.UpdateByOrderID(input.OrderID_IR ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByProductIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Order_Details_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Order_Details_IR();
		// When
		await _specificHttpClient!.UpdateByProductID(input.ProductID_IR ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByProductIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Order_Details_IR();
		// When
		await _specificHttpClient!.UpdateByProductID(input.ProductID_IR ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByOrderIDAndProductIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Order_Details_IR();
		// When
		await _specificHttpClient!.DeleteByOrderIDAndProductID(input.OrderID_IR ?? String.Empty, input.ProductID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByOrderIDAndProductIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Order_Details_IR();
		// When
		await _specificHttpClient!.DeleteByOrderIDAndProductID(input.OrderID_IR ?? String.Empty, input.ProductID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByOrderIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Order_Details_IR();
		// When
		await _specificHttpClient!.DeleteByOrderID(input.OrderID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByOrderIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Order_Details_IR();
		// When
		await _specificHttpClient!.DeleteByOrderID(input.OrderID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByProductIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Order_Details_IR();
		// When
		await _specificHttpClient!.DeleteByProductID(input.ProductID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByProductIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Order_Details_IR();
		// When
		await _specificHttpClient!.DeleteByProductID(input.ProductID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
}
