/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Serialization;
using Northwind_FrontEndSignalRWebsocketClient;
using Northwind_FrontEndSignalRWebsocketClient.SignalRWebsocketClients;
namespace Northwind_FrontEndSignalRWebsocketClientTests;
public class SignalRWebsocketClientTestBase
{
    protected String? _hubUriBase;
	[TestInitialize()]
    public virtual async Task Init()
    {
		_hubUriBase = "https://localhost:53181";       
	}
}