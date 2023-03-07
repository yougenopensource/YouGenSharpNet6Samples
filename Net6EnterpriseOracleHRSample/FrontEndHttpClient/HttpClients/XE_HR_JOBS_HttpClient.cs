/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202605 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using XE_HR_Common.IndirectReferenceTransformerModels;
namespace XE_HR_FrontEndHttpClient.HttpClients;
public class XE_HR_JOBS_HttpClient : HttpClientBase, IXE_HR_JOBS_HttpClient
{
	public XE_HR_JOBS_HttpClient(HttpClient httpClient) : base(httpClient)
    {            
    }
	public async Task<IEnumerable<XE_HR_JOBS_IR>?> GetByBestMatchedQueryPattern(XE_HR_JOBS_IR input)
	{
		if (input == null) return null;
		IEnumerable<XE_HR_JOBS_IR>? retData;
		if (input.JOB_ID_HasBeenChanged) retData = await GetByJOB_ID(input.JOB_ID ?? String.Empty);
		else retData = await GetAll();
		return retData == null ? null : retData.Where(x => WhereAllFilledFields(x, input));
	}
	private static Boolean WhereAllFilledFields(XE_HR_JOBS_IR record, XE_HR_JOBS_IR filter)
	{
		 // unencrypted properties only
		return			(!filter.JOB_TITLE_HasBeenChanged || record.JOB_TITLE == filter.JOB_TITLE);
	}
	public async Task<IEnumerable<XE_HR_JOBS_IR>?> GetAll()
	{
		var result = await _httpClient.GetAsync(_httpClient.BaseAddress!.ToString() + "XE_HR_JOBS/GetAll");
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_JOBS_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<XE_HR_JOBS_IR>?> GetByJOB_ID(String jOB_ID)
	{
		var uri = GetUriForParamsJOB_ID("XE_HR_JOBS/GetByJOB_ID", jOB_ID);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_JOBS_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<XE_HR_JOBS_IR?> Create(XE_HR_JOBS_IR input)
	{
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PostAsync(_httpClient.BaseAddress!.ToString() + "XE_HR_JOBS/Create", new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<XE_HR_JOBS_IR?>(content, _jsonSerializationSettings);
	}
	public async Task UpdateByEncodedPrimaryKey(String? encodedPrimaryKey, XE_HR_JOBS_IR updateModel)
	{
		if (encodedPrimaryKey == null || updateModel == null) return;
		var inputSplits = encodedPrimaryKey.Split((Char)27);
		await UpdateByJOB_ID(inputSplits[0], updateModel);
	}
	public async Task UpdateByJOB_ID(String jOB_ID, XE_HR_JOBS_IR input)
	{
		var uri = GetUriForParamsJOB_ID("XE_HR_JOBS/UpdateByJOB_ID", jOB_ID);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByEncodedPrimaryKey(String? input)
	{
		if (input == null) return;
		var inputSplits = input.Split((Char)27);
		await DeleteByJOB_ID(inputSplits[0]);
	}
	public async Task DeleteByJOB_ID(String jOB_ID)
	{
		var uri = GetUriForParamsJOB_ID("XE_HR_JOBS/DeleteByJOB_ID", jOB_ID);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	private String GetUriForParamsJOB_ID(String path, String jOB_ID)
	{
		var query = new Dictionary<String,String>();
		query["jOB_ID"] = jOB_ID;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
}
