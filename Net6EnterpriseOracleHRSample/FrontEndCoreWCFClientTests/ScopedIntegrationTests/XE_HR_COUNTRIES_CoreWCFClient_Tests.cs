/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202605 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ServiceModel;
using System.ServiceModel.Channels;
using XE_HR_Common.IndirectReferenceTransformerModels;
using XE_HR_FrontEndCoreWCFClient.CoreWCFClients;
using XE_HR_FrontEndCoreWCFClientTests;
using XE_HR_CommonTests.HydratedDynamicIndirectReferenceTransformerModels;
using XE_HR_CommonTests.HydratedStaticIndirectReferenceTransformerModels;
namespace XE_HR_FrontEndCoreWCFClientTests.ScopedIntegrationTests;
[TestClass()]
public class XE_HR_COUNTRIES_WCFClient_Tests : CoreWCFServiceClientTestBase
{    
	protected IXE_HR_COUNTRIES_Service? _serviceClient;    
    protected EndpointAddress? _endpointAddress; 
	private XE_HR_HydratedDynamicIndirectReferenceTransformerModels? _dynamicIRModels;
	private XE_HR_HydratedStaticIndirectReferenceTransformerModels? _staticIRModels;
	[TestInitialize()]
    public override void Init()
    {
        base.Init();
		_dynamicIRModels = new XE_HR_HydratedDynamicIndirectReferenceTransformerModels();
		_staticIRModels = new XE_HR_HydratedStaticIndirectReferenceTransformerModels();
        _endpointAddress = new EndpointAddress(_baseAddress! + "/XE_HR_COUNTRIES_Service");
        _serviceClient = new XE_HR_COUNTRIES_ServiceClient(_binding!, _endpointAddress!);
    }
	[TestMethod()]
	public async Task GetAllTest()
	{
		// When
		var retData = await _serviceClient!.GetAllAsync();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task CreateDynamicTest()
	{
		// Given
		var input = (XE_HR_COUNTRIES_IR)(object)_dynamicIRModels!.GetHydratedDynamicXE_HR_COUNTRIES_IR();
		// When
		var retData = await _serviceClient!.CreateAsync(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task CreateStaticTest()
	{
		// Given
		var input = (XE_HR_COUNTRIES_IR)(object)_staticIRModels!.GetHydratedStaticXE_HR_COUNTRIES_IR();
		// When
		var retData = await _serviceClient!.CreateAsync(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByCOUNTRY_IDDynamicTest()
	{
		// Given
		var input = (XE_HR_COUNTRIES_IR)(object)_dynamicIRModels!.GetHydratedDynamicXE_HR_COUNTRIES_IR();
		// When
		var retData = await _serviceClient!.GetByCOUNTRY_IDAsync(input.COUNTRY_ID ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByCOUNTRY_IDStaticTest()
	{
		// Given
		var input = (XE_HR_COUNTRIES_IR)(object)_staticIRModels!.GetHydratedStaticXE_HR_COUNTRIES_IR();
		// When
		var retData = await _serviceClient!.GetByCOUNTRY_IDAsync(input.COUNTRY_ID ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByCOUNTRY_IDDynamicTest()
	{
		// Given
		var input = (XE_HR_COUNTRIES_IR)(object)_dynamicIRModels!.GetHydratedDynamicXE_HR_COUNTRIES_IR();
		var input2 = (XE_HR_COUNTRIES_IR)(object)_dynamicIRModels!.GetHydratedDynamicXE_HR_COUNTRIES_IR();
		// When
		await _serviceClient!.UpdateByCOUNTRY_IDAsync(input.COUNTRY_ID ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByCOUNTRY_IDStaticTest()
	{
		// Given
		var input = (XE_HR_COUNTRIES_IR)(object)_staticIRModels!.GetHydratedStaticXE_HR_COUNTRIES_IR();
		// When
		await _serviceClient!.UpdateByCOUNTRY_IDAsync(input.COUNTRY_ID ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByCOUNTRY_IDDynamicTest()
	{
		// Given
		var input = (XE_HR_COUNTRIES_IR)(object)_dynamicIRModels!.GetHydratedDynamicXE_HR_COUNTRIES_IR();
		// When
		await _serviceClient!.DeleteByCOUNTRY_IDAsync(input.COUNTRY_ID ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByCOUNTRY_IDStaticTest()
	{
		// Given
		var input = (XE_HR_COUNTRIES_IR)(object)_staticIRModels!.GetHydratedStaticXE_HR_COUNTRIES_IR();
		// When
		await _serviceClient!.DeleteByCOUNTRY_IDAsync(input.COUNTRY_ID ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
}
