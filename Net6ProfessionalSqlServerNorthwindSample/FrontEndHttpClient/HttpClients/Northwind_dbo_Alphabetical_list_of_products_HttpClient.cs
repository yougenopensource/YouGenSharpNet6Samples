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
public class Northwind_dbo_Alphabetical_list_of_products_HttpClient : HttpClientBase, INorthwind_dbo_Alphabetical_list_of_products_HttpClient
{
	public Northwind_dbo_Alphabetical_list_of_products_HttpClient(HttpClient httpClient) : base(httpClient)
    {            
    }
	public async Task<IEnumerable<Northwind_dbo_Alphabetical_list_of_products_IR>?> GetByBestMatchedQueryPattern(Northwind_dbo_Alphabetical_list_of_products_IR input)
	{
		if (input == null) return null;
		IEnumerable<Northwind_dbo_Alphabetical_list_of_products_IR>? retData;
		retData = await GetAll();
		return retData == null ? null : retData.Where(x => WhereAllFilledFields(x, input));
	}
	private static Boolean WhereAllFilledFields(Northwind_dbo_Alphabetical_list_of_products_IR record, Northwind_dbo_Alphabetical_list_of_products_IR filter)
	{
		return			(!filter.ProductID_IR_HasBeenChanged || record.ProductID_IR == filter.ProductID_IR) &&
			(!filter.ProductName_HasBeenChanged || record.ProductName == filter.ProductName) &&
			(!filter.SupplierID_IR_HasBeenChanged || record.SupplierID_IR == filter.SupplierID_IR) &&
			(!filter.CategoryID_IR_HasBeenChanged || record.CategoryID_IR == filter.CategoryID_IR) &&
			(!filter.QuantityPerUnit_HasBeenChanged || record.QuantityPerUnit == filter.QuantityPerUnit) &&
			(!filter.UnitPrice_HasBeenChanged || record.UnitPrice == filter.UnitPrice) &&
			(!filter.UnitsInStock_HasBeenChanged || record.UnitsInStock == filter.UnitsInStock) &&
			(!filter.UnitsOnOrder_HasBeenChanged || record.UnitsOnOrder == filter.UnitsOnOrder) &&
			(!filter.ReorderLevel_HasBeenChanged || record.ReorderLevel == filter.ReorderLevel) &&
			(!filter.Discontinued_HasBeenChanged || record.Discontinued == filter.Discontinued) &&
			(!filter.CategoryName_HasBeenChanged || record.CategoryName == filter.CategoryName);
	}
	public async Task<IEnumerable<Northwind_dbo_Alphabetical_list_of_products_IR>?> GetAll()
	{
		var result = await _httpClient.GetAsync(_httpClient.BaseAddress!.ToString() + "Northwind_dbo_Alphabetical_list_of_products/GetAll");
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Alphabetical_list_of_products_IR>?>(content, _jsonSerializationSettings);
	}
}
