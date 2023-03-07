/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.SignalR.Client;
using Northwind_Common.IndirectReferenceTransformerModels;
namespace Northwind_FrontEndSignalRWebsocketClient.SignalRWebsocketClients;
public class Northwind_dbo_Orders_SignalRWebsocketClient : SignalRWebsocketClientBase, INorthwind_dbo_Orders_SignalRWebsocketClient, IAsyncDisposable
{
	public Northwind_dbo_Orders_SignalRWebsocketClient(String hubUrl) : base(hubUrl)
    {
    }
	public async Task<IEnumerable<Northwind_dbo_Orders_IR>?> GetByBestMatchedQueryPattern(Northwind_dbo_Orders_IR input)
	{
		if (input == null) return null;
		IEnumerable<Northwind_dbo_Orders_IR>? retData;
		if (input.CustomerID_HasBeenChanged) retData = await GetByCustomerID(input.CustomerID);
		else if (input.EmployeeID_IR_HasBeenChanged) retData = await GetByEmployeeID(input.EmployeeID_IR);
		else if (input.OrderDate_HasBeenChanged) retData = await GetByOrderDate(input.OrderDate);
		else if (input.OrderID_IR_HasBeenChanged) retData = await GetByOrderID(input.OrderID_IR ?? default);
		else if (input.ShippedDate_HasBeenChanged) retData = await GetByShippedDate(input.ShippedDate);
		else if (input.ShipVia_IR_HasBeenChanged) retData = await GetByShipVia(input.ShipVia_IR);
		else if (input.ShipPostalCode_HasBeenChanged) retData = await GetByShipPostalCode(input.ShipPostalCode);
		else retData = await GetAll();
		return retData == null ? null : retData.Where(x => WhereAllFilledFields(x, input));
	}
	private static Boolean WhereAllFilledFields(Northwind_dbo_Orders_IR record, Northwind_dbo_Orders_IR filter)
	{
		 // unencrypted properties only
		return			(!filter.OrderDate_HasBeenChanged || record.OrderDate == filter.OrderDate) &&
			(!filter.RequiredDate_HasBeenChanged || record.RequiredDate == filter.RequiredDate) &&
			(!filter.ShippedDate_HasBeenChanged || record.ShippedDate == filter.ShippedDate) &&
			(!filter.ShipName_HasBeenChanged || record.ShipName == filter.ShipName) &&
			(!filter.ShipAddress_HasBeenChanged || record.ShipAddress == filter.ShipAddress) &&
			(!filter.ShipCity_HasBeenChanged || record.ShipCity == filter.ShipCity) &&
			(!filter.ShipRegion_HasBeenChanged || record.ShipRegion == filter.ShipRegion) &&
			(!filter.ShipPostalCode_HasBeenChanged || record.ShipPostalCode == filter.ShipPostalCode) &&
			(!filter.ShipCountry_HasBeenChanged || record.ShipCountry == filter.ShipCountry);
	}
	public async Task<IEnumerable<Northwind_dbo_Orders_IR>?> GetAll()
	{
		return await _hubConnection.InvokeAsync<IEnumerable<Northwind_dbo_Orders_IR>?>("GetAll");
	}
	public async Task<IEnumerable<Northwind_dbo_Orders_IR>?> GetByCustomerID(String? customerID)
	{
		return await _hubConnection.InvokeAsync<IEnumerable<Northwind_dbo_Orders_IR>?>("GetByCustomerID", customerID);
	}
	public async Task<IEnumerable<Northwind_dbo_Orders_IR>?> GetByEmployeeID(String? employeeID_IR)
	{
		return await _hubConnection.InvokeAsync<IEnumerable<Northwind_dbo_Orders_IR>?>("GetByEmployeeID", employeeID_IR);
	}
	public async Task<IEnumerable<Northwind_dbo_Orders_IR>?> GetByOrderDate(DateTime? orderDate)
	{
		return await _hubConnection.InvokeAsync<IEnumerable<Northwind_dbo_Orders_IR>?>("GetByOrderDate", orderDate);
	}
	public async Task<IEnumerable<Northwind_dbo_Orders_IR>?> GetByOrderID(String? orderID_IR)
	{
		return await _hubConnection.InvokeAsync<IEnumerable<Northwind_dbo_Orders_IR>?>("GetByOrderID", orderID_IR);
	}
	public async Task<IEnumerable<Northwind_dbo_Orders_IR>?> GetByShippedDate(DateTime? shippedDate)
	{
		return await _hubConnection.InvokeAsync<IEnumerable<Northwind_dbo_Orders_IR>?>("GetByShippedDate", shippedDate);
	}
	public async Task<IEnumerable<Northwind_dbo_Orders_IR>?> GetByShipVia(String? shipVia_IR)
	{
		return await _hubConnection.InvokeAsync<IEnumerable<Northwind_dbo_Orders_IR>?>("GetByShipVia", shipVia_IR);
	}
	public async Task<IEnumerable<Northwind_dbo_Orders_IR>?> GetByShipPostalCode(String? shipPostalCode)
	{
		return await _hubConnection.InvokeAsync<IEnumerable<Northwind_dbo_Orders_IR>?>("GetByShipPostalCode", shipPostalCode);
	}
	public async Task<Northwind_dbo_Orders_IR?> Create(Northwind_dbo_Orders_IR input)
	{
		return await _hubConnection.InvokeAsync<Northwind_dbo_Orders_IR?>("Create", input);
	}
	public async Task UpdateByEncodedPrimaryKey(String? encodedPrimaryKey, Northwind_dbo_Orders_IR updateModel)
	{
		if (encodedPrimaryKey == null || updateModel == null) return;
		var inputSplits = encodedPrimaryKey.Split((Char)27);
		await UpdateByOrderID(inputSplits[0], updateModel);
	}
	public async Task UpdateByCustomerID(String? customerID, Northwind_dbo_Orders_IR input)
	{
		await _hubConnection.InvokeAsync("UpdateByCustomerID", customerID, input);
	}
	public async Task UpdateByEmployeeID(String? employeeID_IR, Northwind_dbo_Orders_IR input)
	{
		await _hubConnection.InvokeAsync("UpdateByEmployeeID", employeeID_IR, input);
	}
	public async Task UpdateByOrderDate(DateTime? orderDate, Northwind_dbo_Orders_IR input)
	{
		await _hubConnection.InvokeAsync("UpdateByOrderDate", orderDate, input);
	}
	public async Task UpdateByOrderID(String? orderID_IR, Northwind_dbo_Orders_IR input)
	{
		await _hubConnection.InvokeAsync("UpdateByOrderID", orderID_IR, input);
	}
	public async Task UpdateByShippedDate(DateTime? shippedDate, Northwind_dbo_Orders_IR input)
	{
		await _hubConnection.InvokeAsync("UpdateByShippedDate", shippedDate, input);
	}
	public async Task UpdateByShipVia(String? shipVia_IR, Northwind_dbo_Orders_IR input)
	{
		await _hubConnection.InvokeAsync("UpdateByShipVia", shipVia_IR, input);
	}
	public async Task UpdateByShipPostalCode(String? shipPostalCode, Northwind_dbo_Orders_IR input)
	{
		await _hubConnection.InvokeAsync("UpdateByShipPostalCode", shipPostalCode, input);
	}
	public async Task DeleteByEncodedPrimaryKey(String? input)
	{
		if (input == null) return;
		var inputSplits = input.Split((Char)27);
		await DeleteByOrderID(inputSplits[0]);
	}
	public async Task DeleteByCustomerID(String? customerID)
	{
		await _hubConnection.InvokeAsync("DeleteByCustomerID", customerID);
	}
	public async Task DeleteByEmployeeID(String? employeeID_IR)
	{
		await _hubConnection.InvokeAsync("DeleteByEmployeeID", employeeID_IR);
	}
	public async Task DeleteByOrderDate(DateTime? orderDate)
	{
		await _hubConnection.InvokeAsync("DeleteByOrderDate", orderDate);
	}
	public async Task DeleteByOrderID(String? orderID_IR)
	{
		await _hubConnection.InvokeAsync("DeleteByOrderID", orderID_IR);
	}
	public async Task DeleteByShippedDate(DateTime? shippedDate)
	{
		await _hubConnection.InvokeAsync("DeleteByShippedDate", shippedDate);
	}
	public async Task DeleteByShipVia(String? shipVia_IR)
	{
		await _hubConnection.InvokeAsync("DeleteByShipVia", shipVia_IR);
	}
	public async Task DeleteByShipPostalCode(String? shipPostalCode)
	{
		await _hubConnection.InvokeAsync("DeleteByShipPostalCode", shipPostalCode);
	}
    public async Task InitializeAsync()
    {
        await base.EstablishConnection();
    }
    public Boolean GetStatus()
    {
        return base.Initiated;
    }
    public async ValueTask DisposeAsync()
    {
        await base.TerminateConnection();
        GC.SuppressFinalize(this);
    }
}
