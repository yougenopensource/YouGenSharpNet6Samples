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
public class XE_HR_EMPLOYEES_HttpClient : HttpClientBase, IXE_HR_EMPLOYEES_HttpClient
{
	public XE_HR_EMPLOYEES_HttpClient(HttpClient httpClient) : base(httpClient)
    {            
    }
	public async Task<IEnumerable<XE_HR_EMPLOYEES>?> GetAll()
	{
		var result = await _httpClient.GetAsync(_httpClient.BaseAddress!.ToString() + "XE_HR_EMPLOYEES/GetAll");
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_EMPLOYEES>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<XE_HR_EMPLOYEES>?> GetByFIRST_NAMEAndLAST_NAME(String? fIRST_NAME, String lAST_NAME)
	{
		var uri = GetUriForParamsFIRST_NAMEAndLAST_NAME("XE_HR_EMPLOYEES/GetByFIRST_NAMEAndLAST_NAME", fIRST_NAME, lAST_NAME);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_EMPLOYEES>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<XE_HR_EMPLOYEES>?> GetByDEPARTMENT_ID(Int32? dEPARTMENT_ID)
	{
		var uri = GetUriForParamsDEPARTMENT_ID("XE_HR_EMPLOYEES/GetByDEPARTMENT_ID", dEPARTMENT_ID);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_EMPLOYEES>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<XE_HR_EMPLOYEES>?> GetByEMAIL(String eMAIL)
	{
		var uri = GetUriForParamsEMAIL("XE_HR_EMPLOYEES/GetByEMAIL", eMAIL);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_EMPLOYEES>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<XE_HR_EMPLOYEES>?> GetByEMPLOYEE_ID(Int32 eMPLOYEE_ID)
	{
		var uri = GetUriForParamsEMPLOYEE_ID("XE_HR_EMPLOYEES/GetByEMPLOYEE_ID", eMPLOYEE_ID);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_EMPLOYEES>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<XE_HR_EMPLOYEES>?> GetByJOB_ID(String jOB_ID)
	{
		var uri = GetUriForParamsJOB_ID("XE_HR_EMPLOYEES/GetByJOB_ID", jOB_ID);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_EMPLOYEES>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<XE_HR_EMPLOYEES>?> GetByMANAGER_ID(Int32? mANAGER_ID)
	{
		var uri = GetUriForParamsMANAGER_ID("XE_HR_EMPLOYEES/GetByMANAGER_ID", mANAGER_ID);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_EMPLOYEES>?>(content, _jsonSerializationSettings);
	}
	public async Task<XE_HR_EMPLOYEES?> Create(XE_HR_EMPLOYEES input)
	{
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PostAsync(_httpClient.BaseAddress!.ToString() + "XE_HR_EMPLOYEES/Create", new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<XE_HR_EMPLOYEES?>(content, _jsonSerializationSettings);
	}
	public async Task UpdateByEncodedPrimaryKey(String? encodedPrimaryKey, XE_HR_EMPLOYEES updateModel)
	{
		if (encodedPrimaryKey == null || updateModel == null) return;
		var inputSplits = encodedPrimaryKey.Split((Char)27);
		await UpdateByEMPLOYEE_ID(Convert.ToInt32(inputSplits[0]), updateModel);
	}
	public async Task UpdateByFIRST_NAMEAndLAST_NAME(String? fIRST_NAME, String lAST_NAME, XE_HR_EMPLOYEES input)
	{
		var uri = GetUriForParamsFIRST_NAMEAndLAST_NAME("XE_HR_EMPLOYEES/UpdateByFIRST_NAMEAndLAST_NAME", fIRST_NAME, lAST_NAME);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByDEPARTMENT_ID(Int32? dEPARTMENT_ID, XE_HR_EMPLOYEES input)
	{
		var uri = GetUriForParamsDEPARTMENT_ID("XE_HR_EMPLOYEES/UpdateByDEPARTMENT_ID", dEPARTMENT_ID);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByEMAIL(String eMAIL, XE_HR_EMPLOYEES input)
	{
		var uri = GetUriForParamsEMAIL("XE_HR_EMPLOYEES/UpdateByEMAIL", eMAIL);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByEMPLOYEE_ID(Int32 eMPLOYEE_ID, XE_HR_EMPLOYEES input)
	{
		var uri = GetUriForParamsEMPLOYEE_ID("XE_HR_EMPLOYEES/UpdateByEMPLOYEE_ID", eMPLOYEE_ID);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByJOB_ID(String jOB_ID, XE_HR_EMPLOYEES input)
	{
		var uri = GetUriForParamsJOB_ID("XE_HR_EMPLOYEES/UpdateByJOB_ID", jOB_ID);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByMANAGER_ID(Int32? mANAGER_ID, XE_HR_EMPLOYEES input)
	{
		var uri = GetUriForParamsMANAGER_ID("XE_HR_EMPLOYEES/UpdateByMANAGER_ID", mANAGER_ID);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByEncodedPrimaryKey(String? input)
	{
		if (input == null) return;
		var inputSplits = input.Split((Char)27);
		await DeleteByEMPLOYEE_ID(Convert.ToInt32(inputSplits[0]));
	}
	public async Task DeleteByFIRST_NAMEAndLAST_NAME(String? fIRST_NAME, String lAST_NAME)
	{
		var uri = GetUriForParamsFIRST_NAMEAndLAST_NAME("XE_HR_EMPLOYEES/DeleteByFIRST_NAMEAndLAST_NAME", fIRST_NAME, lAST_NAME);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByDEPARTMENT_ID(Int32? dEPARTMENT_ID)
	{
		var uri = GetUriForParamsDEPARTMENT_ID("XE_HR_EMPLOYEES/DeleteByDEPARTMENT_ID", dEPARTMENT_ID);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByEMAIL(String eMAIL)
	{
		var uri = GetUriForParamsEMAIL("XE_HR_EMPLOYEES/DeleteByEMAIL", eMAIL);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByEMPLOYEE_ID(Int32 eMPLOYEE_ID)
	{
		var uri = GetUriForParamsEMPLOYEE_ID("XE_HR_EMPLOYEES/DeleteByEMPLOYEE_ID", eMPLOYEE_ID);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByJOB_ID(String jOB_ID)
	{
		var uri = GetUriForParamsJOB_ID("XE_HR_EMPLOYEES/DeleteByJOB_ID", jOB_ID);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByMANAGER_ID(Int32? mANAGER_ID)
	{
		var uri = GetUriForParamsMANAGER_ID("XE_HR_EMPLOYEES/DeleteByMANAGER_ID", mANAGER_ID);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	private String GetUriForParamsFIRST_NAMEAndLAST_NAME(String path, String? fIRST_NAME, String lAST_NAME)
	{
		var query = new Dictionary<String,String>();
		query["fIRST_NAME"] = fIRST_NAME ?? String.Empty;
		query["lAST_NAME"] = lAST_NAME;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsDEPARTMENT_ID(String path, Int32? dEPARTMENT_ID)
	{
		var query = new Dictionary<String,String>();
		query["dEPARTMENT_ID"] = dEPARTMENT_ID.ToString() ?? 0.ToString();
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsEMAIL(String path, String eMAIL)
	{
		var query = new Dictionary<String,String>();
		query["eMAIL"] = eMAIL;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsEMPLOYEE_ID(String path, Int32 eMPLOYEE_ID)
	{
		var query = new Dictionary<String,String>();
		query["eMPLOYEE_ID"] = eMPLOYEE_ID.ToString();
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsJOB_ID(String path, String jOB_ID)
	{
		var query = new Dictionary<String,String>();
		query["jOB_ID"] = jOB_ID;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsMANAGER_ID(String path, Int32? mANAGER_ID)
	{
		var query = new Dictionary<String,String>();
		query["mANAGER_ID"] = mANAGER_ID.ToString() ?? 0.ToString();
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
}
