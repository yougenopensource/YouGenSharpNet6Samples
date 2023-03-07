/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Northwind_Common.IndirectReferenceTransformerModels;
namespace Northwind_FrontEndHttpClient.HttpClients;
public class Northwind_dbo_Region_HttpClient : HttpClientBase, INorthwind_dbo_Region_HttpClient
{
	public Northwind_dbo_Region_HttpClient(HttpClient httpClient) : base(httpClient)
    {            
    }
	public async Task<IEnumerable<Northwind_dbo_Region_IR>?> GetByBestMatchedQueryPattern(Northwind_dbo_Region_IR input)
	{
		if (input == null) return null;
		IEnumerable<Northwind_dbo_Region_IR>? retData;
		if (input.RegionID_IR_HasBeenChanged) retData = await GetByRegionID(input.RegionID_IR ?? default);
		else retData = await GetAll();
		return retData == null ? null : retData.Where(x => WhereAllFilledFields(x, input));
	}
	private static Boolean WhereAllFilledFields(Northwind_dbo_Region_IR record, Northwind_dbo_Region_IR filter)
	{
		 // unencrypted properties only
		return			(!filter.RegionDescription_HasBeenChanged || record.RegionDescription == filter.RegionDescription);
	}
	public async Task<IEnumerable<Northwind_dbo_Region_IR>?> GetAll()
	{
		var result = await _httpClient.GetAsync(_httpClient.BaseAddress!.ToString() + "Northwind_dbo_Region/GetAll");
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Region_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<Northwind_dbo_Region_IR>?> GetByRegionID(String? regionID_IR)
	{
		var uri = GetUriForParamsRegionID("Northwind_dbo_Region/GetByRegionID", regionID_IR);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Region_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<Northwind_dbo_Region_IR?> Create(Northwind_dbo_Region_IR input)
	{
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PostAsync(_httpClient.BaseAddress!.ToString() + "Northwind_dbo_Region/Create", new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<Northwind_dbo_Region_IR?>(content, _jsonSerializationSettings);
	}
	public async Task UpdateByEncodedPrimaryKey(String? encodedPrimaryKey, Northwind_dbo_Region_IR updateModel)
	{
		if (encodedPrimaryKey == null || updateModel == null) return;
		var inputSplits = encodedPrimaryKey.Split((Char)27);
		await UpdateByRegionID(inputSplits[0], updateModel);
	}
	public async Task UpdateByRegionID(String? regionID_IR, Northwind_dbo_Region_IR input)
	{
		var uri = GetUriForParamsRegionID("Northwind_dbo_Region/UpdateByRegionID", regionID_IR);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByEncodedPrimaryKey(String? input)
	{
		if (input == null) return;
		var inputSplits = input.Split((Char)27);
		await DeleteByRegionID(inputSplits[0]);
	}
	public async Task DeleteByRegionID(String? regionID_IR)
	{
		var uri = GetUriForParamsRegionID("Northwind_dbo_Region/DeleteByRegionID", regionID_IR);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	private String GetUriForParamsRegionID(String path, String? regionID_IR)
	{
		var query = new Dictionary<String,String>();
		query["regionID_IR"] = regionID_IR ?? String.Empty;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
}
