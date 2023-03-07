/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202507 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
namespace XE_HR_FrontEndHttpClient.HttpClients;
public class HttpClientBase
{
	protected readonly HttpClient _httpClient;
    protected readonly UriBuilder _uriBuilder;
    protected readonly DefaultContractResolver _contractResolver;
    protected readonly JsonSerializerSettings _jsonSerializationSettings;
	public HttpClientBase(HttpClient httpClient) 
	{
        _httpClient = httpClient;
        _uriBuilder = new UriBuilder();
        _uriBuilder.Host = httpClient.BaseAddress!.Host;
        _uriBuilder.Scheme = httpClient.BaseAddress!.Scheme;
        _uriBuilder.Port = httpClient.BaseAddress!.Port;
        _contractResolver = new DefaultContractResolver
        {
            NamingStrategy = new DefaultNamingStrategy()
        };
        _jsonSerializationSettings = new JsonSerializerSettings
        {
            ContractResolver = _contractResolver
        };
	} 
}
