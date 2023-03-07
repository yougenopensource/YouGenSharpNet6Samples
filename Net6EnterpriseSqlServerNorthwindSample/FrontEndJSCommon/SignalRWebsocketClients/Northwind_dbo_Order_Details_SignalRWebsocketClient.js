/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
const url_Northwind_dbo_Order_Details = baseUrlSignalR_Northwind + '/Northwind_dbo_Order_Details_Hub';
const connection_Northwind_dbo_Order_Details = new signalR.HubConnectionBuilder()
	.withUrl(url_Northwind_dbo_Order_Details)
	.configureLogging(signalR.LogLevel.Information)
	.build();
async function Start_connection_Northwind_dbo_Order_Details() {
	try {
		await connection_Northwind_dbo_Order_Details.start();
		console.log('SignalR Connected to url:  ' + url_Northwind_dbo_Order_Details);
	} catch (error) {
		console.log(error);
		setTimeout(start_connection_Northwind_dbo_Order_Details(), 5000);
	}
}
async function Stop_connection_Northwind_dbo_Order_Details() {
	try {
		await connection_Northwind_dbo_Order_Details.stop();
		console.log('SignalR Disconnected from url:  ' + url_Northwind_dbo_Order_Details);
	} catch (error) {
		console.log(error);
	}
}
async function Northwind_dbo_Order_Details_IR_GetAll() {
	try {
		let response = await connection_Northwind_dbo_Order_Details.invoke('GetAll');
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Order_Details_IR_GetByOrderIDAndProductID(OrderID_IR,ProductID_IR) {
	try {
		let response = await connection_Northwind_dbo_Order_Details.invoke('GetByOrderIDAndProductID',OrderID_IR,ProductID_IR);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Order_Details_IR_GetByOrderID(OrderID_IR) {
	try {
		let response = await connection_Northwind_dbo_Order_Details.invoke('GetByOrderID',OrderID_IR);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Order_Details_IR_GetByProductID(ProductID_IR) {
	try {
		let response = await connection_Northwind_dbo_Order_Details.invoke('GetByProductID',ProductID_IR);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Order_Details_IR_Create(input) {
	try {
		let response = await connection_Northwind_dbo_Order_Details.invoke('Create',input);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Order_Details_IR_UpdateByOrderIDAndProductID(OrderID_IR,ProductID_IR,input) {
	try {
		await connection_Northwind_dbo_Order_Details.invoke('UpdateByOrderIDAndProductID',OrderID_IR,ProductID_IR,input);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Order_Details_IR_UpdateByOrderID(OrderID_IR,input) {
	try {
		await connection_Northwind_dbo_Order_Details.invoke('UpdateByOrderID',OrderID_IR,input);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Order_Details_IR_UpdateByProductID(ProductID_IR,input) {
	try {
		await connection_Northwind_dbo_Order_Details.invoke('UpdateByProductID',ProductID_IR,input);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Order_Details_IR_DeleteByOrderIDAndProductID(OrderID_IR,ProductID_IR) {
	try {
		await connection_Northwind_dbo_Order_Details.invoke('DeleteByOrderIDAndProductID',OrderID_IR,ProductID_IR);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Order_Details_IR_DeleteByOrderID(OrderID_IR) {
	try {
		await connection_Northwind_dbo_Order_Details.invoke('DeleteByOrderID',OrderID_IR);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Order_Details_IR_DeleteByProductID(ProductID_IR) {
	try {
		await connection_Northwind_dbo_Order_Details.invoke('DeleteByProductID',ProductID_IR);
	} catch (error) {
		// console.log(error);
	}
}
