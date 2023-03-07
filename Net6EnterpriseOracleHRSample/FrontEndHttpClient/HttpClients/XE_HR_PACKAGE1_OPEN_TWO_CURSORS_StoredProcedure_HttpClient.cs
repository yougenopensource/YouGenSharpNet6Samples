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
public class XE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_HttpClient : HttpClientBase, IXE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_HttpClient
{
	public XE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_HttpClient(HttpClient httpClient) : base(httpClient)
    {            
    }
	public async Task<XE_HR_PACKAGE1_OPEN_TWO_CURSORS_OM_IR?> Call_XE_HR_PACKAGE1_OPEN_TWO_CURSORS()
	{
		var result = await _httpClient.PostAsync(_httpClient.BaseAddress!.ToString() + "XE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure/Call_PACKAGE1_OPEN_TWO_CURSORS", null);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<XE_HR_PACKAGE1_OPEN_TWO_CURSORS_OM_IR?>(content, _jsonSerializationSettings);
	}
}