/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202605 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
const url_XE_HR_EMP_DETAILS_VIEW = baseUrlSignalR_XE_HR + '/XE_HR_EMP_DETAILS_VIEW_Hub';
const connection_XE_HR_EMP_DETAILS_VIEW = new signalR.HubConnectionBuilder()
	.withUrl(url_XE_HR_EMP_DETAILS_VIEW)
	.configureLogging(signalR.LogLevel.Information)
	.build();
async function Start_connection_XE_HR_EMP_DETAILS_VIEW() {
	try {
		await connection_XE_HR_EMP_DETAILS_VIEW.start();
		console.log('SignalR Connected to url:  ' + url_XE_HR_EMP_DETAILS_VIEW);
	} catch (error) {
		console.log(error);
		setTimeout(start_connection_XE_HR_EMP_DETAILS_VIEW(), 5000);
	}
}
async function Stop_connection_XE_HR_EMP_DETAILS_VIEW() {
	try {
		await connection_XE_HR_EMP_DETAILS_VIEW.stop();
		console.log('SignalR Disconnected from url:  ' + url_XE_HR_EMP_DETAILS_VIEW);
	} catch (error) {
		console.log(error);
	}
}
async function XE_HR_EMP_DETAILS_VIEW_IR_GetAll() {
	try {
		let response = await connection_XE_HR_EMP_DETAILS_VIEW.invoke('GetAll');
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
