/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
const url_Northwind_dbo_Categories = baseUrlSignalR_Northwind + '/Northwind_dbo_Categories_Hub';
const connection_Northwind_dbo_Categories = new signalR.HubConnectionBuilder()
	.withUrl(url_Northwind_dbo_Categories)
	.configureLogging(signalR.LogLevel.Information)
	.build();
async function Start_connection_Northwind_dbo_Categories() {
	try {
		await connection_Northwind_dbo_Categories.start();
		console.log('SignalR Connected to url:  ' + url_Northwind_dbo_Categories);
	} catch (error) {
		console.log(error);
		setTimeout(start_connection_Northwind_dbo_Categories(), 5000);
	}
}
async function Stop_connection_Northwind_dbo_Categories() {
	try {
		await connection_Northwind_dbo_Categories.stop();
		console.log('SignalR Disconnected from url:  ' + url_Northwind_dbo_Categories);
	} catch (error) {
		console.log(error);
	}
}
async function Northwind_dbo_Categories_IR_GetAll() {
	try {
		let response = await connection_Northwind_dbo_Categories.invoke('GetAll');
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Categories_IR_GetByCategoryName(CategoryName) {
	try {
		let response = await connection_Northwind_dbo_Categories.invoke('GetByCategoryName',CategoryName);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Categories_IR_GetByCategoryID(CategoryID_IR) {
	try {
		let response = await connection_Northwind_dbo_Categories.invoke('GetByCategoryID',CategoryID_IR);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Categories_IR_Create(input) {
	try {
		let response = await connection_Northwind_dbo_Categories.invoke('Create',input);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Categories_IR_UpdateByCategoryName(CategoryName,input) {
	try {
		await connection_Northwind_dbo_Categories.invoke('UpdateByCategoryName',CategoryName,input);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Categories_IR_UpdateByCategoryID(CategoryID_IR,input) {
	try {
		await connection_Northwind_dbo_Categories.invoke('UpdateByCategoryID',CategoryID_IR,input);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Categories_IR_DeleteByCategoryName(CategoryName) {
	try {
		await connection_Northwind_dbo_Categories.invoke('DeleteByCategoryName',CategoryName);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Categories_IR_DeleteByCategoryID(CategoryID_IR) {
	try {
		await connection_Northwind_dbo_Categories.invoke('DeleteByCategoryID',CategoryID_IR);
	} catch (error) {
		// console.log(error);
	}
}
