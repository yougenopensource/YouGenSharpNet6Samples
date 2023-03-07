/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307201813 on behalf of: ****
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
using XE_HR_BackEndSqlEntities.Entities;
namespace XE_HR_FrontEndHttpClient.HttpClients;
public class XE_HR_REGIONS_HttpClient : HttpClientBase, IXE_HR_REGIONS_HttpClient
{
	public XE_HR_REGIONS_HttpClient(HttpClient httpClient) : base(httpClient)
    {            
    }
	public async Task<IEnumerable<XE_HR_REGIONS>?> GetAll()
	{
		var result = await _httpClient.GetAsync(_httpClient.BaseAddress!.ToString() + "XE_HR_REGIONS/GetAll");
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_REGIONS>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<XE_HR_REGIONS>?> GetByREGION_ID(Int32 rEGION_ID)
	{
		var uri = GetUriForParamsREGION_ID("XE_HR_REGIONS/GetByREGION_ID", rEGION_ID);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_REGIONS>?>(content, _jsonSerializationSettings);
	}
	public async Task<XE_HR_REGIONS?> Create(XE_HR_REGIONS input)
	{
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PostAsync(_httpClient.BaseAddress!.ToString() + "XE_HR_REGIONS/Create", new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<XE_HR_REGIONS?>(content, _jsonSerializationSettings);
	}
	public async Task UpdateByEncodedPrimaryKey(String? encodedPrimaryKey, XE_HR_REGIONS updateModel)
	{
		if (encodedPrimaryKey == null || updateModel == null) return;
		var inputSplits = encodedPrimaryKey.Split((Char)27);
		await UpdateByREGION_ID(Convert.ToInt32(inputSplits[0]), updateModel);
	}
	public async Task UpdateByREGION_ID(Int32 rEGION_ID, XE_HR_REGIONS input)
	{
		var uri = GetUriForParamsREGION_ID("XE_HR_REGIONS/UpdateByREGION_ID", rEGION_ID);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByEncodedPrimaryKey(String? input)
	{
		if (input == null) return;
		var inputSplits = input.Split((Char)27);
		await DeleteByREGION_ID(Convert.ToInt32(inputSplits[0]));
	}
	public async Task DeleteByREGION_ID(Int32 rEGION_ID)
	{
		var uri = GetUriForParamsREGION_ID("XE_HR_REGIONS/DeleteByREGION_ID", rEGION_ID);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	private String GetUriForParamsREGION_ID(String path, Int32 rEGION_ID)
	{
		var query = new Dictionary<String,String>();
		query["rEGION_ID"] = rEGION_ID.ToString();
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
}
