/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Newtonsoft.Json;
using Northwind_FrontEndHttpClient;
using Northwind_FrontEndHttpClient.HttpClients;
namespace Northwind_FrontEndHttpClientTests;
public class HttpClientTestBase
{
	protected String? _baseAddress;
    protected HttpClient? _httpClient;
	[TestInitialize()]
    public virtual void Init()
    {
		_baseAddress = "https://localhost:52112";
		_httpClient = new HttpClient { BaseAddress = new Uri(_baseAddress) };		
	}
}