/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
function getHydratedDynamicNorthwind_dbo_Orders(fillPrimaryKey = false) {
	let retObj = new Northwind_dbo_Orders_IR();
	retObj.OrderID_IR = (fillPrimaryKey ? encrypt(1) : null);
	retObj.CustomerID = generateString(5);
	retObj.EmployeeID_IR = encrypt(1);
	retObj.OrderDate = generateDateTime();
	retObj.RequiredDate = generateDateTime();
	retObj.ShippedDate = generateDateTime();
	retObj.ShipVia_IR = encrypt(1);
	retObj.Freight = generateDecimal(19,4);
	retObj.ShipName = generateString(40);
	retObj.ShipAddress = generateString(60);
	retObj.ShipCity = generateString(15);
	retObj.ShipRegion = generateString(15);
	retObj.ShipPostalCode = generateString(10);
	retObj.ShipCountry = generateString(15);
	// Foreign key entities
	retObj.FK_Orders_Customers_Ref_IR = getHydratedDynamicNorthwind_dbo_Customers_IR();
	retObj.FK_Orders_Employees_Ref_IR = getHydratedDynamicNorthwind_dbo_Employees_IR();
	retObj.FK_Orders_Shippers_Ref_IR = getHydratedDynamicNorthwind_dbo_Shippers_IR();
	return retObj;
}
