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
public class Northwind_dbo_Order_Details_HttpClient : HttpClientBase, INorthwind_dbo_Order_Details_HttpClient
{
	public Northwind_dbo_Order_Details_HttpClient(HttpClient httpClient) : base(httpClient)
    {            
    }
	public async Task<IEnumerable<Northwind_dbo_Order_Details_IR>?> GetByBestMatchedQueryPattern(Northwind_dbo_Order_Details_IR input)
	{
		if (input == null) return null;
		IEnumerable<Northwind_dbo_Order_Details_IR>? retData;
		if (input.OrderID_IR_HasBeenChanged && input.ProductID_IR_HasBeenChanged) retData = await GetByOrderIDAndProductID(input.OrderID_IR ?? default, input.ProductID_IR ?? default);
		else if (input.OrderID_IR_HasBeenChanged) retData = await GetByOrderID(input.OrderID_IR ?? default);
		else if (input.ProductID_IR_HasBeenChanged) retData = await GetByProductID(input.ProductID_IR ?? default);
		else retData = await GetAll();
		return retData == null ? null : retData.Where(x => WhereAllFilledFields(x, input));
	}
	private static Boolean WhereAllFilledFields(Northwind_dbo_Order_Details_IR record, Northwind_dbo_Order_Details_IR filter)
	{
		 // unencrypted properties only
		return			(!filter.Discount_HasBeenChanged || record.Discount == filter.Discount);
	}
	public async Task<IEnumerable<Northwind_dbo_Order_Details_IR>?> GetAll()
	{
		var result = await _httpClient.GetAsync(_httpClient.BaseAddress!.ToString() + "Northwind_dbo_Order_Details/GetAll");
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Order_Details_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<Northwind_dbo_Order_Details_IR>?> GetByOrderIDAndProductID(String? orderID_IR, String? productID_IR)
	{
		var uri = GetUriForParamsOrderIDAndProductID("Northwind_dbo_Order_Details/GetByOrderIDAndProductID", orderID_IR, productID_IR);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Order_Details_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<Northwind_dbo_Order_Details_IR>?> GetByOrderID(String? orderID_IR)
	{
		var uri = GetUriForParamsOrderID("Northwind_dbo_Order_Details/GetByOrderID", orderID_IR);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Order_Details_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<Northwind_dbo_Order_Details_IR>?> GetByProductID(String? productID_IR)
	{
		var uri = GetUriForParamsProductID("Northwind_dbo_Order_Details/GetByProductID", productID_IR);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Order_Details_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<Northwind_dbo_Order_Details_IR?> Create(Northwind_dbo_Order_Details_IR input)
	{
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PostAsync(_httpClient.BaseAddress!.ToString() + "Northwind_dbo_Order_Details/Create", new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<Northwind_dbo_Order_Details_IR?>(content, _jsonSerializationSettings);
	}
	public async Task UpdateByEncodedPrimaryKey(String? encodedPrimaryKey, Northwind_dbo_Order_Details_IR updateModel)
	{
		if (encodedPrimaryKey == null || updateModel == null) return;
		var inputSplits = encodedPrimaryKey.Split((Char)27);
		await UpdateByOrderIDAndProductID(inputSplits[0], inputSplits[1], updateModel);
	}
	public async Task UpdateByOrderIDAndProductID(String? orderID_IR, String? productID_IR, Northwind_dbo_Order_Details_IR input)
	{
		var uri = GetUriForParamsOrderIDAndProductID("Northwind_dbo_Order_Details/UpdateByOrderIDAndProductID", orderID_IR, productID_IR);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByOrderID(String? orderID_IR, Northwind_dbo_Order_Details_IR input)
	{
		var uri = GetUriForParamsOrderID("Northwind_dbo_Order_Details/UpdateByOrderID", orderID_IR);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByProductID(String? productID_IR, Northwind_dbo_Order_Details_IR input)
	{
		var uri = GetUriForParamsProductID("Northwind_dbo_Order_Details/UpdateByProductID", productID_IR);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByEncodedPrimaryKey(String? input)
	{
		if (input == null) return;
		var inputSplits = input.Split((Char)27);
		await DeleteByOrderIDAndProductID(inputSplits[0], inputSplits[1]);
	}
	public async Task DeleteByOrderIDAndProductID(String? orderID_IR, String? productID_IR)
	{
		var uri = GetUriForParamsOrderIDAndProductID("Northwind_dbo_Order_Details/DeleteByOrderIDAndProductID", orderID_IR, productID_IR);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByOrderID(String? orderID_IR)
	{
		var uri = GetUriForParamsOrderID("Northwind_dbo_Order_Details/DeleteByOrderID", orderID_IR);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByProductID(String? productID_IR)
	{
		var uri = GetUriForParamsProductID("Northwind_dbo_Order_Details/DeleteByProductID", productID_IR);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	private String GetUriForParamsOrderIDAndProductID(String path, String? orderID_IR, String? productID_IR)
	{
		var query = new Dictionary<String,String>();
		query["orderID_IR"] = orderID_IR ?? String.Empty;
		query["productID_IR"] = productID_IR ?? String.Empty;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsOrderID(String path, String? orderID_IR)
	{
		var query = new Dictionary<String,String>();
		query["orderID_IR"] = orderID_IR ?? String.Empty;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsProductID(String path, String? productID_IR)
	{
		var query = new Dictionary<String,String>();
		query["productID_IR"] = productID_IR ?? String.Empty;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
}
