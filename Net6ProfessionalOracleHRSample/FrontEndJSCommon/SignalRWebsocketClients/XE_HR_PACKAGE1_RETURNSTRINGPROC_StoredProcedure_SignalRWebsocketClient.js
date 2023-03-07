/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202507 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
const url_XE_HR_PACKAGE1_RETURNSTRINGPROC_StoredProcedure = baseUrlSignalR_XE_HR + '/XE_HR_PACKAGE1_RETURNSTRINGPROC_StoredProcedure_Hub';
const connection_XE_HR_PACKAGE1_RETURNSTRINGPROC_StoredProcedure = new signalR.HubConnectionBuilder()
	.withUrl(url_XE_HR_PACKAGE1_RETURNSTRINGPROC_StoredProcedure)
	.configureLogging(signalR.LogLevel.Information)
	.build();
async function Start_connection_XE_HR_PACKAGE1_RETURNSTRINGPROC_StoredProcedure() {
	try {
		await connection_XE_HR_PACKAGE1_RETURNSTRINGPROC_StoredProcedure.start();
		console.log('SignalR Connected to url:  ' + url_XE_HR_PACKAGE1_RETURNSTRINGPROC_StoredProcedure);
	} catch (error) {
		console.log(error);
		setTimeout(start_connection_XE_HR_PACKAGE1_RETURNSTRINGPROC_StoredProcedure(), 5000);
	}
}
async function Stop_connection_XE_HR_PACKAGE1_RETURNSTRINGPROC_StoredProcedure() {
	try {
		await connection_XE_HR_PACKAGE1_RETURNSTRINGPROC_StoredProcedure.stop();
		console.log('SignalR Disconnected from url:  ' + url_XE_HR_PACKAGE1_RETURNSTRINGPROC_StoredProcedure);
	} catch (error) {
		console.log(error);
	}
}
async function Call_XE_HR_PACKAGE1_RETURNSTRINGPROC_StoredProcedure_IR,input() {
	try {
		let response = await connection_XE_HR_PACKAGE1_RETURNSTRINGPROC_StoredProcedure.invoke('Call_XE_HR_PACKAGE1_RETURNSTRINGPROC_StoredProcedure',input);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
