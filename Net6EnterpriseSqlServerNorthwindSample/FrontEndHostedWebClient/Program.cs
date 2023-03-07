/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Northwind_FrontEndMudBlazorWebassembly;
using Northwind_FrontEndMudBlazorWebassembly.Services;
using Northwind_FrontEndHttpClient.HttpClients;
using Northwind_FrontEndSignalRWebsocketClient.SignalRWebsocketClients;
using Northwind_Common.Validators;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using MudBlazor.Services;
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
// Http client properties
var httpClientBaseAddress = new Uri("https://localhost:58924");
var acceptHeaderName = "Accept";
var acceptHeaderValue = "application/json";
// Websocket client
var websocketBaseAddress = "https://localhost:52114";
// Register Services
builder.Services.AddMudServices();
builder.Services.AddSingleton(new NavigationStateSingleton());
// Http clients
// Tables
builder.Services.AddHttpClient<Northwind_dbo_Categories_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_CustomerCustomerDemo_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_CustomerDemographics_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_Customers_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_Employees_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_EmployeeTerritories_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_Order_Details_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_Orders_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_Products_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_Region_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_Shippers_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_Suppliers_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_Territories_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
// Views
builder.Services.AddHttpClient<Northwind_dbo_Alphabetical_list_of_products_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_Category_Sales_for_1997_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_Current_Product_List_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_Customer_and_Suppliers_by_City_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_Invoices_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_Order_Details_Extended_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_Order_Subtotals_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_Orders_Qry_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_Product_Sales_for_1997_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_Products_Above_Average_Price_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_Products_by_Category_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_Quarterly_Orders_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_Sales_by_Category_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_Sales_Totals_by_Amount_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_Summary_of_Sales_by_Quarter_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_Summary_of_Sales_by_Year_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
// Procedures
builder.Services.AddHttpClient<Northwind_dbo_CustOrderHist_StoredProcedure_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_CustOrdersDetail_StoredProcedure_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_CustOrdersOrders_StoredProcedure_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_Employee_Sales_by_Country_StoredProcedure_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_ProductsAndCategories_StoredProcedure_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_Sales_by_Year_StoredProcedure_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_SalesByCategory_StoredProcedure_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
builder.Services.AddHttpClient<Northwind_dbo_Ten_Most_Expensive_Products_StoredProcedure_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
// Websocket clients
// Tables
builder.Services.AddSingleton(new Northwind_dbo_Categories_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_Categories_Hub"));
builder.Services.AddScoped<Northwind_dbo_Categories_IR_FluentValidator_Create>();
builder.Services.AddScoped<Northwind_dbo_Categories_IR_FluentValidator_Read>();
builder.Services.AddScoped<Northwind_dbo_Categories_IR_FluentValidator_Update>();
builder.Services.AddScoped<Northwind_dbo_Categories_IR_FluentValidator_Delete>();
builder.Services.AddSingleton(new Northwind_dbo_CustomerCustomerDemo_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_CustomerCustomerDemo_Hub"));
builder.Services.AddScoped<Northwind_dbo_CustomerCustomerDemo_IR_FluentValidator_Create>();
builder.Services.AddScoped<Northwind_dbo_CustomerCustomerDemo_IR_FluentValidator_Read>();
builder.Services.AddScoped<Northwind_dbo_CustomerCustomerDemo_IR_FluentValidator_Update>();
builder.Services.AddScoped<Northwind_dbo_CustomerCustomerDemo_IR_FluentValidator_Delete>();
builder.Services.AddSingleton(new Northwind_dbo_CustomerDemographics_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_CustomerDemographics_Hub"));
builder.Services.AddScoped<Northwind_dbo_CustomerDemographics_IR_FluentValidator_Create>();
builder.Services.AddScoped<Northwind_dbo_CustomerDemographics_IR_FluentValidator_Read>();
builder.Services.AddScoped<Northwind_dbo_CustomerDemographics_IR_FluentValidator_Update>();
builder.Services.AddScoped<Northwind_dbo_CustomerDemographics_IR_FluentValidator_Delete>();
builder.Services.AddSingleton(new Northwind_dbo_Customers_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_Customers_Hub"));
builder.Services.AddScoped<Northwind_dbo_Customers_IR_FluentValidator_Create>();
builder.Services.AddScoped<Northwind_dbo_Customers_IR_FluentValidator_Read>();
builder.Services.AddScoped<Northwind_dbo_Customers_IR_FluentValidator_Update>();
builder.Services.AddScoped<Northwind_dbo_Customers_IR_FluentValidator_Delete>();
builder.Services.AddSingleton(new Northwind_dbo_Employees_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_Employees_Hub"));
builder.Services.AddScoped<Northwind_dbo_Employees_IR_FluentValidator_Create>();
builder.Services.AddScoped<Northwind_dbo_Employees_IR_FluentValidator_Read>();
builder.Services.AddScoped<Northwind_dbo_Employees_IR_FluentValidator_Update>();
builder.Services.AddScoped<Northwind_dbo_Employees_IR_FluentValidator_Delete>();
builder.Services.AddSingleton(new Northwind_dbo_EmployeeTerritories_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_EmployeeTerritories_Hub"));
builder.Services.AddScoped<Northwind_dbo_EmployeeTerritories_IR_FluentValidator_Create>();
builder.Services.AddScoped<Northwind_dbo_EmployeeTerritories_IR_FluentValidator_Read>();
builder.Services.AddScoped<Northwind_dbo_EmployeeTerritories_IR_FluentValidator_Update>();
builder.Services.AddScoped<Northwind_dbo_EmployeeTerritories_IR_FluentValidator_Delete>();
builder.Services.AddSingleton(new Northwind_dbo_Order_Details_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_Order_Details_Hub"));
builder.Services.AddScoped<Northwind_dbo_Order_Details_IR_FluentValidator_Create>();
builder.Services.AddScoped<Northwind_dbo_Order_Details_IR_FluentValidator_Read>();
builder.Services.AddScoped<Northwind_dbo_Order_Details_IR_FluentValidator_Update>();
builder.Services.AddScoped<Northwind_dbo_Order_Details_IR_FluentValidator_Delete>();
builder.Services.AddSingleton(new Northwind_dbo_Orders_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_Orders_Hub"));
builder.Services.AddScoped<Northwind_dbo_Orders_IR_FluentValidator_Create>();
builder.Services.AddScoped<Northwind_dbo_Orders_IR_FluentValidator_Read>();
builder.Services.AddScoped<Northwind_dbo_Orders_IR_FluentValidator_Update>();
builder.Services.AddScoped<Northwind_dbo_Orders_IR_FluentValidator_Delete>();
builder.Services.AddSingleton(new Northwind_dbo_Products_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_Products_Hub"));
builder.Services.AddScoped<Northwind_dbo_Products_IR_FluentValidator_Create>();
builder.Services.AddScoped<Northwind_dbo_Products_IR_FluentValidator_Read>();
builder.Services.AddScoped<Northwind_dbo_Products_IR_FluentValidator_Update>();
builder.Services.AddScoped<Northwind_dbo_Products_IR_FluentValidator_Delete>();
builder.Services.AddSingleton(new Northwind_dbo_Region_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_Region_Hub"));
builder.Services.AddScoped<Northwind_dbo_Region_IR_FluentValidator_Create>();
builder.Services.AddScoped<Northwind_dbo_Region_IR_FluentValidator_Read>();
builder.Services.AddScoped<Northwind_dbo_Region_IR_FluentValidator_Update>();
builder.Services.AddScoped<Northwind_dbo_Region_IR_FluentValidator_Delete>();
builder.Services.AddSingleton(new Northwind_dbo_Shippers_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_Shippers_Hub"));
builder.Services.AddScoped<Northwind_dbo_Shippers_IR_FluentValidator_Create>();
builder.Services.AddScoped<Northwind_dbo_Shippers_IR_FluentValidator_Read>();
builder.Services.AddScoped<Northwind_dbo_Shippers_IR_FluentValidator_Update>();
builder.Services.AddScoped<Northwind_dbo_Shippers_IR_FluentValidator_Delete>();
builder.Services.AddSingleton(new Northwind_dbo_Suppliers_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_Suppliers_Hub"));
builder.Services.AddScoped<Northwind_dbo_Suppliers_IR_FluentValidator_Create>();
builder.Services.AddScoped<Northwind_dbo_Suppliers_IR_FluentValidator_Read>();
builder.Services.AddScoped<Northwind_dbo_Suppliers_IR_FluentValidator_Update>();
builder.Services.AddScoped<Northwind_dbo_Suppliers_IR_FluentValidator_Delete>();
builder.Services.AddSingleton(new Northwind_dbo_Territories_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_Territories_Hub"));
builder.Services.AddScoped<Northwind_dbo_Territories_IR_FluentValidator_Create>();
builder.Services.AddScoped<Northwind_dbo_Territories_IR_FluentValidator_Read>();
builder.Services.AddScoped<Northwind_dbo_Territories_IR_FluentValidator_Update>();
builder.Services.AddScoped<Northwind_dbo_Territories_IR_FluentValidator_Delete>();
// Views
builder.Services.AddSingleton(new Northwind_dbo_Alphabetical_list_of_products_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_Alphabetical_list_of_products_Hub"));
builder.Services.AddScoped<Northwind_dbo_Alphabetical_list_of_products_IR_FluentValidator>();
builder.Services.AddSingleton(new Northwind_dbo_Category_Sales_for_1997_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_Category_Sales_for_1997_Hub"));
builder.Services.AddScoped<Northwind_dbo_Category_Sales_for_1997_IR_FluentValidator>();
builder.Services.AddSingleton(new Northwind_dbo_Current_Product_List_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_Current_Product_List_Hub"));
builder.Services.AddScoped<Northwind_dbo_Current_Product_List_IR_FluentValidator>();
builder.Services.AddSingleton(new Northwind_dbo_Customer_and_Suppliers_by_City_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_Customer_and_Suppliers_by_City_Hub"));
builder.Services.AddScoped<Northwind_dbo_Customer_and_Suppliers_by_City_IR_FluentValidator>();
builder.Services.AddSingleton(new Northwind_dbo_Invoices_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_Invoices_Hub"));
builder.Services.AddScoped<Northwind_dbo_Invoices_IR_FluentValidator>();
builder.Services.AddSingleton(new Northwind_dbo_Order_Details_Extended_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_Order_Details_Extended_Hub"));
builder.Services.AddScoped<Northwind_dbo_Order_Details_Extended_IR_FluentValidator>();
builder.Services.AddSingleton(new Northwind_dbo_Order_Subtotals_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_Order_Subtotals_Hub"));
builder.Services.AddScoped<Northwind_dbo_Order_Subtotals_IR_FluentValidator>();
builder.Services.AddSingleton(new Northwind_dbo_Orders_Qry_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_Orders_Qry_Hub"));
builder.Services.AddScoped<Northwind_dbo_Orders_Qry_IR_FluentValidator>();
builder.Services.AddSingleton(new Northwind_dbo_Product_Sales_for_1997_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_Product_Sales_for_1997_Hub"));
builder.Services.AddScoped<Northwind_dbo_Product_Sales_for_1997_IR_FluentValidator>();
builder.Services.AddSingleton(new Northwind_dbo_Products_Above_Average_Price_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_Products_Above_Average_Price_Hub"));
builder.Services.AddScoped<Northwind_dbo_Products_Above_Average_Price_IR_FluentValidator>();
builder.Services.AddSingleton(new Northwind_dbo_Products_by_Category_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_Products_by_Category_Hub"));
builder.Services.AddScoped<Northwind_dbo_Products_by_Category_IR_FluentValidator>();
builder.Services.AddSingleton(new Northwind_dbo_Quarterly_Orders_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_Quarterly_Orders_Hub"));
builder.Services.AddScoped<Northwind_dbo_Quarterly_Orders_IR_FluentValidator>();
builder.Services.AddSingleton(new Northwind_dbo_Sales_by_Category_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_Sales_by_Category_Hub"));
builder.Services.AddScoped<Northwind_dbo_Sales_by_Category_IR_FluentValidator>();
builder.Services.AddSingleton(new Northwind_dbo_Sales_Totals_by_Amount_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_Sales_Totals_by_Amount_Hub"));
builder.Services.AddScoped<Northwind_dbo_Sales_Totals_by_Amount_IR_FluentValidator>();
builder.Services.AddSingleton(new Northwind_dbo_Summary_of_Sales_by_Quarter_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_Summary_of_Sales_by_Quarter_Hub"));
builder.Services.AddScoped<Northwind_dbo_Summary_of_Sales_by_Quarter_IR_FluentValidator>();
builder.Services.AddSingleton(new Northwind_dbo_Summary_of_Sales_by_Year_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_Summary_of_Sales_by_Year_Hub"));
builder.Services.AddScoped<Northwind_dbo_Summary_of_Sales_by_Year_IR_FluentValidator>();
// Procedures
builder.Services.AddSingleton(new Northwind_dbo_CustOrderHist_StoredProcedure_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_CustOrderHist_StoredProcedure_Hub"));
builder.Services.AddScoped<Northwind_dbo_CustOrderHist_IM_IR_FluentValidator>();
builder.Services.AddSingleton(new Northwind_dbo_CustOrdersDetail_StoredProcedure_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_CustOrdersDetail_StoredProcedure_Hub"));
builder.Services.AddScoped<Northwind_dbo_CustOrdersDetail_IM_IR_FluentValidator>();
builder.Services.AddSingleton(new Northwind_dbo_CustOrdersOrders_StoredProcedure_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_CustOrdersOrders_StoredProcedure_Hub"));
builder.Services.AddScoped<Northwind_dbo_CustOrdersOrders_IM_IR_FluentValidator>();
builder.Services.AddSingleton(new Northwind_dbo_Employee_Sales_by_Country_StoredProcedure_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_Employee_Sales_by_Country_StoredProcedure_Hub"));
builder.Services.AddScoped<Northwind_dbo_Employee_Sales_by_Country_IM_IR_FluentValidator>();
builder.Services.AddSingleton(new Northwind_dbo_ProductsAndCategories_StoredProcedure_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_ProductsAndCategories_StoredProcedure_Hub"));
builder.Services.AddSingleton(new Northwind_dbo_Sales_by_Year_StoredProcedure_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_Sales_by_Year_StoredProcedure_Hub"));
builder.Services.AddScoped<Northwind_dbo_Sales_by_Year_IM_IR_FluentValidator>();
builder.Services.AddSingleton(new Northwind_dbo_SalesByCategory_StoredProcedure_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_SalesByCategory_StoredProcedure_Hub"));
builder.Services.AddScoped<Northwind_dbo_SalesByCategory_IM_IR_FluentValidator>();
builder.Services.AddSingleton(new Northwind_dbo_Ten_Most_Expensive_Products_StoredProcedure_SignalRWebsocketClient(websocketBaseAddress + "/Northwind_dbo_Ten_Most_Expensive_Products_StoredProcedure_Hub"));
await builder.Build().RunAsync();
