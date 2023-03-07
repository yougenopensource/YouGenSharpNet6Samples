/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195435 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Free Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use for evaluation purposes only. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_FrontEndHttpClient.HttpClients;
public class Northwind_dbo_Products_by_Category_HttpClient : HttpClientBase, INorthwind_dbo_Products_by_Category_HttpClient
{
	public Northwind_dbo_Products_by_Category_HttpClient(HttpClient httpClient) : base(httpClient)
    {            
    }
	public async Task<IEnumerable<Northwind_dbo_Products_by_Category>?> GetAll()
	{
		var result = await _httpClient.GetAsync(_httpClient.BaseAddress!.ToString() + "Northwind_dbo_Products_by_Category/GetAll");
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Products_by_Category>?>(content, _jsonSerializationSettings);
	}
}
