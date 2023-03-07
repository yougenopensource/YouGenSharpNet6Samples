/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202507 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XE_HR_Common.IndirectReferenceTransformerModels;
using XE_HR_FrontEndHttpClient.HttpClients;
using XE_HR_FrontEndHttpClientTests;
using XE_HR_CommonTests.HydratedDynamicIndirectReferenceTransformerModels;
using XE_HR_CommonTests.HydratedStaticIndirectReferenceTransformerModels;
namespace XE_HR_FrontEndHttpClientTests.ScopedIntegrationTests;
[TestClass()]
public class XE_HR_EMPLOYEES_HttpClient_Tests : HttpClientTestBase
{
	protected IXE_HR_EMPLOYEES_HttpClient? _specificHttpClient;
	private XE_HR_HydratedDynamicIndirectReferenceTransformerModels? _dynamicIRModels;
	private XE_HR_HydratedStaticIndirectReferenceTransformerModels? _staticIRModels;
	[TestInitialize()]
    public override void Init()
    {
        base.Init();
		_dynamicIRModels = new XE_HR_HydratedDynamicIndirectReferenceTransformerModels();
		_staticIRModels = new XE_HR_HydratedStaticIndirectReferenceTransformerModels();
        _specificHttpClient = new XE_HR_EMPLOYEES_HttpClient(_httpClient!);
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
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_EMPLOYEES_IR();
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
		var input = _staticIRModels!.GetHydratedStaticXE_HR_EMPLOYEES_IR();
		// When
		var retData = await _specificHttpClient!.Create(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByFIRST_NAMEAndLAST_NAMEDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_EMPLOYEES_IR();
		// When
		var retData = await _specificHttpClient!.GetByFIRST_NAMEAndLAST_NAME(input.FIRST_NAME, input.LAST_NAME ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByFIRST_NAMEAndLAST_NAMEStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_EMPLOYEES_IR();
		// When
		var retData = await _specificHttpClient!.GetByFIRST_NAMEAndLAST_NAME(input.FIRST_NAME, input.LAST_NAME ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByDEPARTMENT_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_EMPLOYEES_IR();
		// When
		var retData = await _specificHttpClient!.GetByDEPARTMENT_ID(input.DEPARTMENT_ID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByDEPARTMENT_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_EMPLOYEES_IR();
		// When
		var retData = await _specificHttpClient!.GetByDEPARTMENT_ID(input.DEPARTMENT_ID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByEMAILDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_EMPLOYEES_IR();
		// When
		var retData = await _specificHttpClient!.GetByEMAIL(input.EMAIL ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByEMAILStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_EMPLOYEES_IR();
		// When
		var retData = await _specificHttpClient!.GetByEMAIL(input.EMAIL ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByEMPLOYEE_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_EMPLOYEES_IR();
		// When
		var retData = await _specificHttpClient!.GetByEMPLOYEE_ID(input.EMPLOYEE_ID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByEMPLOYEE_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_EMPLOYEES_IR();
		// When
		var retData = await _specificHttpClient!.GetByEMPLOYEE_ID(input.EMPLOYEE_ID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByJOB_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_EMPLOYEES_IR();
		// When
		var retData = await _specificHttpClient!.GetByJOB_ID(input.JOB_ID ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByJOB_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_EMPLOYEES_IR();
		// When
		var retData = await _specificHttpClient!.GetByJOB_ID(input.JOB_ID ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByMANAGER_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_EMPLOYEES_IR();
		// When
		var retData = await _specificHttpClient!.GetByMANAGER_ID(input.MANAGER_ID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByMANAGER_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_EMPLOYEES_IR();
		// When
		var retData = await _specificHttpClient!.GetByMANAGER_ID(input.MANAGER_ID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByFIRST_NAMEAndLAST_NAMEDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_EMPLOYEES_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicXE_HR_EMPLOYEES_IR();
		// When
		await _specificHttpClient!.UpdateByFIRST_NAMEAndLAST_NAME(input.FIRST_NAME, input.LAST_NAME ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByFIRST_NAMEAndLAST_NAMEStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_EMPLOYEES_IR();
		// When
		await _specificHttpClient!.UpdateByFIRST_NAMEAndLAST_NAME(input.FIRST_NAME, input.LAST_NAME ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByDEPARTMENT_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_EMPLOYEES_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicXE_HR_EMPLOYEES_IR();
		// When
		await _specificHttpClient!.UpdateByDEPARTMENT_ID(input.DEPARTMENT_ID_IR ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByDEPARTMENT_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_EMPLOYEES_IR();
		// When
		await _specificHttpClient!.UpdateByDEPARTMENT_ID(input.DEPARTMENT_ID_IR ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByEMAILDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_EMPLOYEES_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicXE_HR_EMPLOYEES_IR();
		// When
		await _specificHttpClient!.UpdateByEMAIL(input.EMAIL ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByEMAILStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_EMPLOYEES_IR();
		// When
		await _specificHttpClient!.UpdateByEMAIL(input.EMAIL ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByEMPLOYEE_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_EMPLOYEES_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicXE_HR_EMPLOYEES_IR();
		// When
		await _specificHttpClient!.UpdateByEMPLOYEE_ID(input.EMPLOYEE_ID_IR ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByEMPLOYEE_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_EMPLOYEES_IR();
		// When
		await _specificHttpClient!.UpdateByEMPLOYEE_ID(input.EMPLOYEE_ID_IR ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByJOB_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_EMPLOYEES_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicXE_HR_EMPLOYEES_IR();
		// When
		await _specificHttpClient!.UpdateByJOB_ID(input.JOB_ID ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByJOB_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_EMPLOYEES_IR();
		// When
		await _specificHttpClient!.UpdateByJOB_ID(input.JOB_ID ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByMANAGER_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_EMPLOYEES_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicXE_HR_EMPLOYEES_IR();
		// When
		await _specificHttpClient!.UpdateByMANAGER_ID(input.MANAGER_ID_IR ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByMANAGER_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_EMPLOYEES_IR();
		// When
		await _specificHttpClient!.UpdateByMANAGER_ID(input.MANAGER_ID_IR ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByFIRST_NAMEAndLAST_NAMEDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_EMPLOYEES_IR();
		// When
		await _specificHttpClient!.DeleteByFIRST_NAMEAndLAST_NAME(input.FIRST_NAME, input.LAST_NAME ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByFIRST_NAMEAndLAST_NAMEStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_EMPLOYEES_IR();
		// When
		await _specificHttpClient!.DeleteByFIRST_NAMEAndLAST_NAME(input.FIRST_NAME, input.LAST_NAME ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByDEPARTMENT_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_EMPLOYEES_IR();
		// When
		await _specificHttpClient!.DeleteByDEPARTMENT_ID(input.DEPARTMENT_ID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByDEPARTMENT_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_EMPLOYEES_IR();
		// When
		await _specificHttpClient!.DeleteByDEPARTMENT_ID(input.DEPARTMENT_ID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByEMAILDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_EMPLOYEES_IR();
		// When
		await _specificHttpClient!.DeleteByEMAIL(input.EMAIL ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByEMAILStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_EMPLOYEES_IR();
		// When
		await _specificHttpClient!.DeleteByEMAIL(input.EMAIL ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByEMPLOYEE_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_EMPLOYEES_IR();
		// When
		await _specificHttpClient!.DeleteByEMPLOYEE_ID(input.EMPLOYEE_ID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByEMPLOYEE_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_EMPLOYEES_IR();
		// When
		await _specificHttpClient!.DeleteByEMPLOYEE_ID(input.EMPLOYEE_ID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByJOB_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_EMPLOYEES_IR();
		// When
		await _specificHttpClient!.DeleteByJOB_ID(input.JOB_ID ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByJOB_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_EMPLOYEES_IR();
		// When
		await _specificHttpClient!.DeleteByJOB_ID(input.JOB_ID ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByMANAGER_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_EMPLOYEES_IR();
		// When
		await _specificHttpClient!.DeleteByMANAGER_ID(input.MANAGER_ID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByMANAGER_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_EMPLOYEES_IR();
		// When
		await _specificHttpClient!.DeleteByMANAGER_ID(input.MANAGER_ID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
}
