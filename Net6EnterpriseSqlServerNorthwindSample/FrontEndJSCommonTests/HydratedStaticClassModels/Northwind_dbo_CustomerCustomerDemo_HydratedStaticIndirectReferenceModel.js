/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
function getHydratedStaticNorthwind_dbo_CustomerCustomerDemo(fillPrimaryKey = false) {
	let retObj = new Northwind_dbo_CustomerCustomerDemo_IR();
	retObj.CustomerID = (fillPrimaryKey ? 'ekNgu' : null);
	retObj.CustomerTypeID = (fillPrimaryKey ? 'huBPzHftvh' : null);
	// Foreign key entities
	retObj.FK_CustomerCustomerDemo_Ref_IR = getHydratedStaticNorthwind_dbo_CustomerDemographics_IR();
	retObj.FK_CustomerCustomerDemo_Customers_Ref_IR = getHydratedStaticNorthwind_dbo_Customers_IR();
	return retObj;
}
