/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202605 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
const url_XE_HR_LOCATIONS = baseUrlSignalR_XE_HR + '/XE_HR_LOCATIONS_Hub';
const connection_XE_HR_LOCATIONS = new signalR.HubConnectionBuilder()
	.withUrl(url_XE_HR_LOCATIONS)
	.configureLogging(signalR.LogLevel.Information)
	.build();
async function Start_connection_XE_HR_LOCATIONS() {
	try {
		await connection_XE_HR_LOCATIONS.start();
		console.log('SignalR Connected to url:  ' + url_XE_HR_LOCATIONS);
	} catch (error) {
		console.log(error);
		setTimeout(start_connection_XE_HR_LOCATIONS(), 5000);
	}
}
async function Stop_connection_XE_HR_LOCATIONS() {
	try {
		await connection_XE_HR_LOCATIONS.stop();
		console.log('SignalR Disconnected from url:  ' + url_XE_HR_LOCATIONS);
	} catch (error) {
		console.log(error);
	}
}
async function XE_HR_LOCATIONS_IR_GetAll() {
	try {
		let response = await connection_XE_HR_LOCATIONS.invoke('GetAll');
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_LOCATIONS_IR_GetByCITY(CITY) {
	try {
		let response = await connection_XE_HR_LOCATIONS.invoke('GetByCITY',CITY);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_LOCATIONS_IR_GetByCOUNTRY_ID(COUNTRY_ID) {
	try {
		let response = await connection_XE_HR_LOCATIONS.invoke('GetByCOUNTRY_ID',COUNTRY_ID);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_LOCATIONS_IR_GetByLOCATION_ID(LOCATION_ID_IR) {
	try {
		let response = await connection_XE_HR_LOCATIONS.invoke('GetByLOCATION_ID',LOCATION_ID_IR);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_LOCATIONS_IR_GetBySTATE_PROVINCE(STATE_PROVINCE) {
	try {
		let response = await connection_XE_HR_LOCATIONS.invoke('GetBySTATE_PROVINCE',STATE_PROVINCE);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_LOCATIONS_IR_Create(input) {
	try {
		let response = await connection_XE_HR_LOCATIONS.invoke('Create',input);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_LOCATIONS_IR_UpdateByCITY(CITY,input) {
	try {
		await connection_XE_HR_LOCATIONS.invoke('UpdateByCITY',CITY,input);
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_LOCATIONS_IR_UpdateByCOUNTRY_ID(COUNTRY_ID,input) {
	try {
		await connection_XE_HR_LOCATIONS.invoke('UpdateByCOUNTRY_ID',COUNTRY_ID,input);
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_LOCATIONS_IR_UpdateByLOCATION_ID(LOCATION_ID_IR,input) {
	try {
		await connection_XE_HR_LOCATIONS.invoke('UpdateByLOCATION_ID',LOCATION_ID_IR,input);
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_LOCATIONS_IR_UpdateBySTATE_PROVINCE(STATE_PROVINCE,input) {
	try {
		await connection_XE_HR_LOCATIONS.invoke('UpdateBySTATE_PROVINCE',STATE_PROVINCE,input);
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_LOCATIONS_IR_DeleteByCITY(CITY) {
	try {
		await connection_XE_HR_LOCATIONS.invoke('DeleteByCITY',CITY);
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_LOCATIONS_IR_DeleteByCOUNTRY_ID(COUNTRY_ID) {
	try {
		await connection_XE_HR_LOCATIONS.invoke('DeleteByCOUNTRY_ID',COUNTRY_ID);
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_LOCATIONS_IR_DeleteByLOCATION_ID(LOCATION_ID_IR) {
	try {
		await connection_XE_HR_LOCATIONS.invoke('DeleteByLOCATION_ID',LOCATION_ID_IR);
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_LOCATIONS_IR_DeleteBySTATE_PROVINCE(STATE_PROVINCE) {
	try {
		await connection_XE_HR_LOCATIONS.invoke('DeleteBySTATE_PROVINCE',STATE_PROVINCE);
	} catch (error) {
		// console.log(error);
	}
}
