/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
const url_Northwind_dbo_EmployeeTerritories = baseUrlSignalR_Northwind + '/Northwind_dbo_EmployeeTerritories_Hub';
const connection_Northwind_dbo_EmployeeTerritories = new signalR.HubConnectionBuilder()
	.withUrl(url_Northwind_dbo_EmployeeTerritories)
	.configureLogging(signalR.LogLevel.Information)
	.build();
async function Start_connection_Northwind_dbo_EmployeeTerritories() {
	try {
		await connection_Northwind_dbo_EmployeeTerritories.start();
		console.log('SignalR Connected to url:  ' + url_Northwind_dbo_EmployeeTerritories);
	} catch (error) {
		console.log(error);
		setTimeout(start_connection_Northwind_dbo_EmployeeTerritories(), 5000);
	}
}
async function Stop_connection_Northwind_dbo_EmployeeTerritories() {
	try {
		await connection_Northwind_dbo_EmployeeTerritories.stop();
		console.log('SignalR Disconnected from url:  ' + url_Northwind_dbo_EmployeeTerritories);
	} catch (error) {
		console.log(error);
	}
}
async function Northwind_dbo_EmployeeTerritories_IR_GetAll() {
	try {
		let response = await connection_Northwind_dbo_EmployeeTerritories.invoke('GetAll');
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_EmployeeTerritories_IR_GetByEmployeeIDAndTerritoryID(EmployeeID_IR,TerritoryID) {
	try {
		let response = await connection_Northwind_dbo_EmployeeTerritories.invoke('GetByEmployeeIDAndTerritoryID',EmployeeID_IR,TerritoryID);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_EmployeeTerritories_IR_Create(input) {
	try {
		let response = await connection_Northwind_dbo_EmployeeTerritories.invoke('Create',input);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_EmployeeTerritories_IR_UpdateByEmployeeIDAndTerritoryID(EmployeeID_IR,TerritoryID,input) {
	try {
		await connection_Northwind_dbo_EmployeeTerritories.invoke('UpdateByEmployeeIDAndTerritoryID',EmployeeID_IR,TerritoryID,input);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_EmployeeTerritories_IR_DeleteByEmployeeIDAndTerritoryID(EmployeeID_IR,TerritoryID) {
	try {
		await connection_Northwind_dbo_EmployeeTerritories.invoke('DeleteByEmployeeIDAndTerritoryID',EmployeeID_IR,TerritoryID);
	} catch (error) {
		// console.log(error);
	}
}
