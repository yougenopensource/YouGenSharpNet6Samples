/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202507 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XE_HR_FrontEndHttpClient.HttpClients;
using XE_HR_FrontEndHttpClientTests;
namespace XE_HR_FrontEndHttpClientTests.ScopedIntegrationTests;
[TestClass()]
public class XE_HR_EMP_DETAILS_VIEW_HttpClient_Tests : HttpClientTestBase
{
	protected IXE_HR_EMP_DETAILS_VIEW_HttpClient? _specificHttpClient;
	[TestInitialize()]
    public override void Init()
    {
        base.Init();
        _specificHttpClient = new XE_HR_EMP_DETAILS_VIEW_HttpClient(_httpClient!);
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
}
