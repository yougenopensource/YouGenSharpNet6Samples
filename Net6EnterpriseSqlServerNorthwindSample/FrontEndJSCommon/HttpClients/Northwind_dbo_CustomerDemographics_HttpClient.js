/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
const controllerRoute = '/Northwind_dbo_CustomerDemographics';
async function Northwind_dbo_CustomerDemographics_IR_GetAll() {
	let config = {};
	config.baseURL = baseUrl_Northwind + controllerRoute;
	config.url = 'GetAll';
	config.method = 'get';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_CustomerDemographics_IR_GetByCustomerTypeID(CustomerTypeID) {
	let config = {};
	config.baseURL = baseUrl_Northwind + controllerRoute;
	config.url = 'GetByCustomerTypeID?' + GetUriForParamsForCustomerTypeID(CustomerTypeID);
	config.method = 'get';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_CustomerDemographics_IR_Create(input) {
	let config = {};
	config.baseURL = baseUrl_Northwind + controllerRoute;
	config.url = 'Create';
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
async function Northwind_dbo_CustomerDemographics_IR_UpdateByCustomerTypeID(CustomerTypeID,input) {
	let config = {};
	config.baseURL = baseUrl_Northwind + controllerRoute;
	config.url = 'UpdateByCustomerTypeID?' + GetUriForParamsForCustomerTypeID(CustomerTypeID);
	config.method = 'put';
	config.data = input;
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_CustomerDemographics_IR_DeleteByCustomerTypeID(CustomerTypeID) {
	let config = {};
	config.baseURL = baseUrl_Northwind + controllerRoute;
	config.url = 'DeleteByCustomerTypeID?' + GetUriForParamsForCustomerTypeID(CustomerTypeID);
	config.method = 'delete';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
function GetUriForParamsForCustomerTypeID(CustomerTypeID) {
	const urlParams = new URLSearchParams({
		"CustomerTypeID": CustomerTypeID
	});
	return urlParams.toString();
}