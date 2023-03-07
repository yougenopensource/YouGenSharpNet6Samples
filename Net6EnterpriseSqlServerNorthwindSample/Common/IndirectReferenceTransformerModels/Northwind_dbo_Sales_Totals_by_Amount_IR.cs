/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
// For reads only
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace Northwind_Common.IndirectReferenceTransformerModels;
/// <summary>
/// Sql Entity Description: Indirect Referenced Model Description: N/A
/// </summary>
public class Northwind_dbo_Sales_Totals_by_Amount_IR
{
	public Northwind_dbo_Sales_Totals_by_Amount_IR() 
	{
	} 
	public Northwind_dbo_Sales_Totals_by_Amount_IR(
		Decimal? saleAmount_,
		String? orderID_IR_,
		String? companyName_,
		DateTime? shippedDate_
	)
	{
		_saleAmount = saleAmount_;
		SaleAmount_OriginalValue = saleAmount_;
		_orderID_IR = orderID_IR_;
		OrderID_IR_OriginalValue = orderID_IR_;
		_companyName = companyName_;
		CompanyName_OriginalValue = companyName_;
		_shippedDate = shippedDate_;
		ShippedDate_OriginalValue = shippedDate_;
	}
	[JsonConstructor]
	public Northwind_dbo_Sales_Totals_by_Amount_IR(
		Decimal? SaleAmount,
		Decimal? SaleAmount_OriginalValue,
		Boolean SaleAmount_HasBeenChanged,
		String? OrderID_IR,
		String? OrderID_IR_OriginalValue,
		Boolean OrderID_IR_HasBeenChanged,
		String? CompanyName,
		String? CompanyName_OriginalValue,
		Boolean CompanyName_HasBeenChanged,
		DateTime? ShippedDate,
		DateTime? ShippedDate_OriginalValue,
		Boolean ShippedDate_HasBeenChanged
	)
	{
		this.SaleAmount = SaleAmount;
		this.SaleAmount_OriginalValue = SaleAmount_OriginalValue;
		this.SaleAmount_HasBeenChanged = SaleAmount_HasBeenChanged;
		this.OrderID_IR = OrderID_IR;
		this.OrderID_IR_OriginalValue = OrderID_IR_OriginalValue;
		this.OrderID_IR_HasBeenChanged = OrderID_IR_HasBeenChanged;
		this.CompanyName = CompanyName;
		this.CompanyName_OriginalValue = CompanyName_OriginalValue;
		this.CompanyName_HasBeenChanged = CompanyName_HasBeenChanged;
		this.ShippedDate = ShippedDate;
		this.ShippedDate_OriginalValue = ShippedDate_OriginalValue;
		this.ShippedDate_HasBeenChanged = ShippedDate_HasBeenChanged;
	}
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public Decimal? SaleAmount
	{
		get => _saleAmount;
		set
		{
			_saleAmount = value;
			SaleAmount_HasBeenChanged = _saleAmount == SaleAmount_OriginalValue ? false : true;
		}
	}
	private Decimal? _saleAmount;
	public Decimal? SaleAmount_OriginalValue { get; private set; }
	public Boolean SaleAmount_HasBeenChanged { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? OrderID_IR
	{
		get => _orderID_IR;
		set
		{
			_orderID_IR = value;
			OrderID_IR_HasBeenChanged = _orderID_IR == OrderID_IR_OriginalValue ? false : true;
		}
	}
	private String? _orderID_IR;
	public String? OrderID_IR_OriginalValue { get; private set; }
	public Boolean OrderID_IR_HasBeenChanged { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? CompanyName
	{
		get => _companyName;
		set
		{
			_companyName = value;
			CompanyName_HasBeenChanged = _companyName == CompanyName_OriginalValue ? false : true;
		}
	}
	private String? _companyName;
	public String? CompanyName_OriginalValue { get; private set; }
	public Boolean CompanyName_HasBeenChanged { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public DateTime? ShippedDate
	{
		get => _shippedDate;
		set
		{
			_shippedDate = value;
			ShippedDate_HasBeenChanged = _shippedDate == ShippedDate_OriginalValue ? false : true;
		}
	}
	private DateTime? _shippedDate;
	public DateTime? ShippedDate_OriginalValue { get; private set; }
	public Boolean ShippedDate_HasBeenChanged { get; private set; }
}
