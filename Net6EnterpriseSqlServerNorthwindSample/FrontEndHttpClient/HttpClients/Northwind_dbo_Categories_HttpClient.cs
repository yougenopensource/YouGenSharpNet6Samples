/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
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
using Northwind_Common.IndirectReferenceTransformerModels;
namespace Northwind_FrontEndHttpClient.HttpClients;
public class Northwind_dbo_Categories_HttpClient : HttpClientBase, INorthwind_dbo_Categories_HttpClient
{
	public Northwind_dbo_Categories_HttpClient(HttpClient httpClient) : base(httpClient)
    {            
    }
	public async Task<IEnumerable<Northwind_dbo_Categories_IR>?> GetByBestMatchedQueryPattern(Northwind_dbo_Categories_IR input)
	{
		if (input == null) return null;
		IEnumerable<Northwind_dbo_Categories_IR>? retData;
		if (input.CategoryName_HasBeenChanged) retData = await GetByCategoryName(input.CategoryName ?? String.Empty);
		else if (input.CategoryID_IR_HasBeenChanged) retData = await GetByCategoryID(input.CategoryID_IR ?? default);
		else retData = await GetAll();
		return retData == null ? null : retData.Where(x => WhereAllFilledFields(x, input));
	}
	private static Boolean WhereAllFilledFields(Northwind_dbo_Categories_IR record, Northwind_dbo_Categories_IR filter)
	{
		 // unencrypted properties only
		return			(!filter.CategoryName_HasBeenChanged || record.CategoryName == filter.CategoryName) &&
			(!filter.Description_HasBeenChanged || record.Description == filter.Description) &&
			(!filter.Picture_HasBeenChanged || record.Picture == filter.Picture);
	}
	public async Task<IEnumerable<Northwind_dbo_Categories_IR>?> GetAll()
	{
		var result = await _httpClient.GetAsync(_httpClient.BaseAddress!.ToString() + "Northwind_dbo_Categories/GetAll");
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Categories_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<Northwind_dbo_Categories_IR>?> GetByCategoryName(String categoryName)
	{
		var uri = GetUriForParamsCategoryName("Northwind_dbo_Categories/GetByCategoryName", categoryName);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Categories_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<Northwind_dbo_Categories_IR>?> GetByCategoryID(String? categoryID_IR)
	{
		var uri = GetUriForParamsCategoryID("Northwind_dbo_Categories/GetByCategoryID", categoryID_IR);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Categories_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<Northwind_dbo_Categories_IR?> Create(Northwind_dbo_Categories_IR input)
	{
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PostAsync(_httpClient.BaseAddress!.ToString() + "Northwind_dbo_Categories/Create", new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<Northwind_dbo_Categories_IR?>(content, _jsonSerializationSettings);
	}
	public async Task UpdateByEncodedPrimaryKey(String? encodedPrimaryKey, Northwind_dbo_Categories_IR updateModel)
	{
		if (encodedPrimaryKey == null || updateModel == null) return;
		var inputSplits = encodedPrimaryKey.Split((Char)27);
		await UpdateByCategoryID(inputSplits[0], updateModel);
	}
	public async Task UpdateByCategoryName(String categoryName, Northwind_dbo_Categories_IR input)
	{
		var uri = GetUriForParamsCategoryName("Northwind_dbo_Categories/UpdateByCategoryName", categoryName);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByCategoryID(String? categoryID_IR, Northwind_dbo_Categories_IR input)
	{
		var uri = GetUriForParamsCategoryID("Northwind_dbo_Categories/UpdateByCategoryID", categoryID_IR);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByEncodedPrimaryKey(String? input)
	{
		if (input == null) return;
		var inputSplits = input.Split((Char)27);
		await DeleteByCategoryID(inputSplits[0]);
	}
	public async Task DeleteByCategoryName(String categoryName)
	{
		var uri = GetUriForParamsCategoryName("Northwind_dbo_Categories/DeleteByCategoryName", categoryName);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByCategoryID(String? categoryID_IR)
	{
		var uri = GetUriForParamsCategoryID("Northwind_dbo_Categories/DeleteByCategoryID", categoryID_IR);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	private String GetUriForParamsCategoryName(String path, String categoryName)
	{
		var query = new Dictionary<String,String>();
		query["categoryName"] = categoryName;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsCategoryID(String path, String? categoryID_IR)
	{
		var query = new Dictionary<String,String>();
		query["categoryID_IR"] = categoryID_IR ?? String.Empty;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
}
