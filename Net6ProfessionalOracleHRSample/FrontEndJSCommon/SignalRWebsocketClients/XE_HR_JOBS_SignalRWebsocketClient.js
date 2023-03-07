/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202507 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
const url_XE_HR_JOBS = baseUrlSignalR_XE_HR + '/XE_HR_JOBS_Hub';
const connection_XE_HR_JOBS = new signalR.HubConnectionBuilder()
	.withUrl(url_XE_HR_JOBS)
	.configureLogging(signalR.LogLevel.Information)
	.build();
async function Start_connection_XE_HR_JOBS() {
	try {
		await connection_XE_HR_JOBS.start();
		console.log('SignalR Connected to url:  ' + url_XE_HR_JOBS);
	} catch (error) {
		console.log(error);
		setTimeout(start_connection_XE_HR_JOBS(), 5000);
	}
}
async function Stop_connection_XE_HR_JOBS() {
	try {
		await connection_XE_HR_JOBS.stop();
		console.log('SignalR Disconnected from url:  ' + url_XE_HR_JOBS);
	} catch (error) {
		console.log(error);
	}
}
async function XE_HR_JOBS_IR_GetAll() {
	try {
		let response = await connection_XE_HR_JOBS.invoke('GetAll');
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_JOBS_IR_GetByJOB_ID(JOB_ID) {
	try {
		let response = await connection_XE_HR_JOBS.invoke('GetByJOB_ID',JOB_ID);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_JOBS_IR_Create(input) {
	try {
		let response = await connection_XE_HR_JOBS.invoke('Create',input);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_JOBS_IR_UpdateByJOB_ID(JOB_ID,input) {
	try {
		await connection_XE_HR_JOBS.invoke('UpdateByJOB_ID',JOB_ID,input);
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_JOBS_IR_DeleteByJOB_ID(JOB_ID) {
	try {
		await connection_XE_HR_JOBS.invoke('DeleteByJOB_ID',JOB_ID);
	} catch (error) {
		// console.log(error);
	}
}
