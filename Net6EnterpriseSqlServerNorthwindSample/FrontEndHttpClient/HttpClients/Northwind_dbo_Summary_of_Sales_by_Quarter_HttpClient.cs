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
public class Northwind_dbo_Summary_of_Sales_by_Quarter_HttpClient : HttpClientBase, INorthwind_dbo_Summary_of_Sales_by_Quarter_HttpClient
{
	public Northwind_dbo_Summary_of_Sales_by_Quarter_HttpClient(HttpClient httpClient) : base(httpClient)
    {            
    }
	public async Task<IEnumerable<Northwind_dbo_Summary_of_Sales_by_Quarter_IR>?> GetByBestMatchedQueryPattern(Northwind_dbo_Summary_of_Sales_by_Quarter_IR input)
	{
		if (input == null) return null;
		IEnumerable<Northwind_dbo_Summary_of_Sales_by_Quarter_IR>? retData;
		retData = await GetAll();
		return retData == null ? null : retData.Where(x => WhereAllFilledFields(x, input));
	}
	private static Boolean WhereAllFilledFields(Northwind_dbo_Summary_of_Sales_by_Quarter_IR record, Northwind_dbo_Summary_of_Sales_by_Quarter_IR filter)
	{
		return			(!filter.ShippedDate_HasBeenChanged || record.ShippedDate == filter.ShippedDate) &&
			(!filter.OrderID_IR_HasBeenChanged || record.OrderID_IR == filter.OrderID_IR) &&
			(!filter.Subtotal_HasBeenChanged || record.Subtotal == filter.Subtotal);
	}
	public async Task<IEnumerable<Northwind_dbo_Summary_of_Sales_by_Quarter_IR>?> GetAll()
	{
		var result = await _httpClient.GetAsync(_httpClient.BaseAddress!.ToString() + "Northwind_dbo_Summary_of_Sales_by_Quarter/GetAll");
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Summary_of_Sales_by_Quarter_IR>?>(content, _jsonSerializationSettings);
	}
}