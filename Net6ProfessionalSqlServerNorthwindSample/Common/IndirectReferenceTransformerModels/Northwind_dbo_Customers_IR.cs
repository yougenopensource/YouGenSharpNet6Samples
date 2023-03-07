/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace Northwind_Common.IndirectReferenceTransformerModels;
/// <summary>
/// Sql Entity Description: Indirect Referenced Model Description: N/A
/// </summary>
public class Northwind_dbo_Customers_IR
{
	public Northwind_dbo_Customers_IR() 
	{
	} 
	public Northwind_dbo_Customers_IR(
		String? customerID_,
		String? companyName_,
		String? contactName_,
		String? contactTitle_,
		String? address_,
		String? city_,
		String? region_,
		String? postalCode_,
		String? country_,
		String? phone_,
		String? fax_
	)
	{
		_customerID = customerID_;
		CustomerID_OriginalValue = customerID_;
		_companyName = companyName_;
		CompanyName_OriginalValue = companyName_;
		_contactName = contactName_;
		ContactName_OriginalValue = contactName_;
		_contactTitle = contactTitle_;
		ContactTitle_OriginalValue = contactTitle_;
		_address = address_;
		Address_OriginalValue = address_;
		_city = city_;
		City_OriginalValue = city_;
		_region = region_;
		Region_OriginalValue = region_;
		_postalCode = postalCode_;
		PostalCode_OriginalValue = postalCode_;
		_country = country_;
		Country_OriginalValue = country_;
		_phone = phone_;
		Phone_OriginalValue = phone_;
		_fax = fax_;
		Fax_OriginalValue = fax_;
		PrimaryKeyEncryptedForUpdateDeleteIdentification = customerID_;
	}
	[JsonConstructor]
	public Northwind_dbo_Customers_IR(
		String CustomerID,
		String CustomerID_OriginalValue,
		Boolean CustomerID_HasBeenChanged,
		String CompanyName,
		String CompanyName_OriginalValue,
		Boolean CompanyName_HasBeenChanged,
		String? ContactName,
		String? ContactName_OriginalValue,
		Boolean ContactName_HasBeenChanged,
		String? ContactTitle,
		String? ContactTitle_OriginalValue,
		Boolean ContactTitle_HasBeenChanged,
		String? Address,
		String? Address_OriginalValue,
		Boolean Address_HasBeenChanged,
		String? City,
		String? City_OriginalValue,
		Boolean City_HasBeenChanged,
		String? Region,
		String? Region_OriginalValue,
		Boolean Region_HasBeenChanged,
		String? PostalCode,
		String? PostalCode_OriginalValue,
		Boolean PostalCode_HasBeenChanged,
		String? Country,
		String? Country_OriginalValue,
		Boolean Country_HasBeenChanged,
		String? Phone,
		String? Phone_OriginalValue,
		Boolean Phone_HasBeenChanged,
		String? Fax,
		String? Fax_OriginalValue,
		Boolean Fax_HasBeenChanged,
		String? PrimaryKeyEncryptedForUpdateDeleteIdentification,
		String? PrimaryKeyHashedForUniqueObjectComparison
	)
	{
		this.CustomerID = CustomerID;
		this.CustomerID_OriginalValue = CustomerID_OriginalValue;
		this.CustomerID_HasBeenChanged = CustomerID_HasBeenChanged;
		this.CompanyName = CompanyName;
		this.CompanyName_OriginalValue = CompanyName_OriginalValue;
		this.CompanyName_HasBeenChanged = CompanyName_HasBeenChanged;
		this.ContactName = ContactName;
		this.ContactName_OriginalValue = ContactName_OriginalValue;
		this.ContactName_HasBeenChanged = ContactName_HasBeenChanged;
		this.ContactTitle = ContactTitle;
		this.ContactTitle_OriginalValue = ContactTitle_OriginalValue;
		this.ContactTitle_HasBeenChanged = ContactTitle_HasBeenChanged;
		this.Address = Address;
		this.Address_OriginalValue = Address_OriginalValue;
		this.Address_HasBeenChanged = Address_HasBeenChanged;
		this.City = City;
		this.City_OriginalValue = City_OriginalValue;
		this.City_HasBeenChanged = City_HasBeenChanged;
		this.Region = Region;
		this.Region_OriginalValue = Region_OriginalValue;
		this.Region_HasBeenChanged = Region_HasBeenChanged;
		this.PostalCode = PostalCode;
		this.PostalCode_OriginalValue = PostalCode_OriginalValue;
		this.PostalCode_HasBeenChanged = PostalCode_HasBeenChanged;
		this.Country = Country;
		this.Country_OriginalValue = Country_OriginalValue;
		this.Country_HasBeenChanged = Country_HasBeenChanged;
		this.Phone = Phone;
		this.Phone_OriginalValue = Phone_OriginalValue;
		this.Phone_HasBeenChanged = Phone_HasBeenChanged;
		this.Fax = Fax;
		this.Fax_OriginalValue = Fax_OriginalValue;
		this.Fax_HasBeenChanged = Fax_HasBeenChanged;
		this.PrimaryKeyEncryptedForUpdateDeleteIdentification = PrimaryKeyEncryptedForUpdateDeleteIdentification;
		this.PrimaryKeyHashedForUniqueObjectComparison = PrimaryKeyHashedForUniqueObjectComparison;
	}
	/// <summary>
	/// SQL Column Description: Primary key encrypted value for update and delete identification purposes
	/// </summary>
	public String? PrimaryKeyEncryptedForUpdateDeleteIdentification { get; set; }
	/// <summary>
	/// SQL Column Description: Primary key hashed value for uniue object comparison purposes
	/// </summary>
	public String? PrimaryKeyHashedForUniqueObjectComparison { get; set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? CustomerID
	{
		get => _customerID;
		set
		{
			_customerID = value;
			CustomerID_HasBeenChanged = _customerID == CustomerID_OriginalValue ? false : true;
		}
	}
	private String? _customerID;
	public String? CustomerID_OriginalValue  { get; private set; }
	public Boolean CustomerID_HasBeenChanged  { get; private set; }
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
	public String? CompanyName_OriginalValue  { get; private set; }
	public Boolean CompanyName_HasBeenChanged  { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? ContactName
	{
		get => _contactName;
		set
		{
			_contactName = value;
			ContactName_HasBeenChanged = _contactName == ContactName_OriginalValue ? false : true;
		}
	}
	private String? _contactName;
	public String? ContactName_OriginalValue  { get; private set; }
	public Boolean ContactName_HasBeenChanged  { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? ContactTitle
	{
		get => _contactTitle;
		set
		{
			_contactTitle = value;
			ContactTitle_HasBeenChanged = _contactTitle == ContactTitle_OriginalValue ? false : true;
		}
	}
	private String? _contactTitle;
	public String? ContactTitle_OriginalValue  { get; private set; }
	public Boolean ContactTitle_HasBeenChanged  { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? Address
	{
		get => _address;
		set
		{
			_address = value;
			Address_HasBeenChanged = _address == Address_OriginalValue ? false : true;
		}
	}
	private String? _address;
	public String? Address_OriginalValue  { get; private set; }
	public Boolean Address_HasBeenChanged  { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? City
	{
		get => _city;
		set
		{
			_city = value;
			City_HasBeenChanged = _city == City_OriginalValue ? false : true;
		}
	}
	private String? _city;
	public String? City_OriginalValue  { get; private set; }
	public Boolean City_HasBeenChanged  { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? Region
	{
		get => _region;
		set
		{
			_region = value;
			Region_HasBeenChanged = _region == Region_OriginalValue ? false : true;
		}
	}
	private String? _region;
	public String? Region_OriginalValue  { get; private set; }
	public Boolean Region_HasBeenChanged  { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? PostalCode
	{
		get => _postalCode;
		set
		{
			_postalCode = value;
			PostalCode_HasBeenChanged = _postalCode == PostalCode_OriginalValue ? false : true;
		}
	}
	private String? _postalCode;
	public String? PostalCode_OriginalValue  { get; private set; }
	public Boolean PostalCode_HasBeenChanged  { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? Country
	{
		get => _country;
		set
		{
			_country = value;
			Country_HasBeenChanged = _country == Country_OriginalValue ? false : true;
		}
	}
	private String? _country;
	public String? Country_OriginalValue  { get; private set; }
	public Boolean Country_HasBeenChanged  { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? Phone
	{
		get => _phone;
		set
		{
			_phone = value;
			Phone_HasBeenChanged = _phone == Phone_OriginalValue ? false : true;
		}
	}
	private String? _phone;
	public String? Phone_OriginalValue  { get; private set; }
	public Boolean Phone_HasBeenChanged  { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? Fax
	{
		get => _fax;
		set
		{
			_fax = value;
			Fax_HasBeenChanged = _fax == Fax_OriginalValue ? false : true;
		}
	}
	private String? _fax;
	public String? Fax_OriginalValue  { get; private set; }
	public Boolean Fax_HasBeenChanged  { get; private set; }
	/// <summary>
	/// Entities that reference this entity by foreign key
	/// </summary>
	/// <example>null</example>
	public virtual ICollection<Northwind_dbo_CustomerCustomerDemo_IR>?FK_CustomerCustomerDemo_Customers_RefBy_IR { get; set; } = new HashSet<Northwind_dbo_CustomerCustomerDemo_IR>();
	/// <summary>
	/// Entities that reference this entity by foreign key
	/// </summary>
	/// <example>null</example>
	public virtual ICollection<Northwind_dbo_Orders_IR>?FK_Orders_Customers_RefBy_IR { get; set; } = new HashSet<Northwind_dbo_Orders_IR>();
}
