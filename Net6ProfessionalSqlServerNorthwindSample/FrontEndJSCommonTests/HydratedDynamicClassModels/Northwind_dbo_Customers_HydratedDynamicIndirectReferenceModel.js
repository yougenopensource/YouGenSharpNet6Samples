/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
function getHydratedDynamicNorthwind_dbo_Customers(fillPrimaryKey = false) {
	let retObj = new Northwind_dbo_Customers_IR();
	retObj.CustomerID = (fillPrimaryKey ? generateString(5) : null);
	retObj.CompanyName = generateString(40);
	retObj.ContactName = generateString(30);
	retObj.ContactTitle = generateString(30);
	retObj.Address = generateString(60);
	retObj.City = generateString(15);
	retObj.Region = generateString(15);
	retObj.PostalCode = generateString(10);
	retObj.Country = generateString(15);
	retObj.Phone = generateString(24);
	retObj.Fax = generateString(24);
	return retObj;
}
