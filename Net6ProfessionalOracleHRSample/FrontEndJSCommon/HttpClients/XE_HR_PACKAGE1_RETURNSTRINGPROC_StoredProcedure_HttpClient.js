/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202507 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
const controllerRoute = '/XE_HR_PACKAGE1_RETURNSTRINGPROC_StoredProcedure';
async function Call_XE_HR_PACKAGE1_RETURNSTRINGPROC_StoredProcedure_IR(input) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'Call_PACKAGE1_RETURNSTRINGPROC';
	config.method = 'post';
	config.data = input;
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
