/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
class Northwind_dbo_Order_Details_IR {
	constructor(
		OrderID_IR,
		ProductID_IR,
		UnitPrice,
		Quantity,
		Discount
	)
	{
		this.OrderID_IR = OrderID_IR;
		this.ProductID_IR = ProductID_IR;
		this.UnitPrice = UnitPrice;
		this.Quantity = Quantity;
		this.Discount = Discount;
	}
	FK_Order_Details_Orders_Ref_IR;
	FK_Order_Details_Products_Ref_IR;
	OrderID_IR;
	ProductID_IR;
	UnitPrice;
	Quantity;
	Discount;
}