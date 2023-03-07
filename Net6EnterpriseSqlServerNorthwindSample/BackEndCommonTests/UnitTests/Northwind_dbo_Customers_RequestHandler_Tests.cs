/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Northwind_BackEndSqlEntities.Entities;
using Northwind_BackEndDatabaseClient.Repositories;
using Northwind_Common.IndirectReferenceTransformerModels;
using Northwind_Common.Validators;
using Northwind_BackEndCommon.IndirectReferenceTransformers;
using Northwind_BackEndCommon.RequestHandlers;
using Northwind_BackEndDatabaseClientTests.HydratedStaticEntities;
using Northwind_BackEndDatabaseClientTests.HydratedDynamicEntities;
using Northwind_CommonTests.HydratedStaticIndirectReferenceTransformerModels;
using Northwind_CommonTests.HydratedDynamicIndirectReferenceTransformerModels;
namespace Northwind_BackEndCommonTests.RequestHandlerUnitTests;
[TestClass()]
public class Northwind_dbo_Customers_RequestHandler_UnitTests : RequestHandlerUnitTestBase
{
	private Mock<ILogger<Northwind_dbo_Customers_RequestHandler>>? _logger;
	private Boolean isSecondaryLookup;
	private Northwind_HydratedDynamicEntities? _dynamicEntities;
	private Northwind_HydratedDynamicIndirectReferenceTransformerModels? _dynamicIRModels;
	private Mock<INorthwind_dbo_Customers_Repository>? _dynamicRepository;
	private Mock<IIRTransformers>? _dynamicIndirectReferenceTransformers;
	private Northwind_dbo_Customers_IR_FluentValidator_Create? _createValidator;
	private Northwind_dbo_Customers_IR_FluentValidator_Read? _readValidator;
	private Northwind_dbo_Customers_IR_FluentValidator_Update? _updateValidator;
	private Northwind_dbo_Customers_IR_FluentValidator_Delete? _deleteValidator;
	private INorthwind_dbo_Customers_RequestHandler? _dynamicRequestHandler;
	private Northwind_HydratedStaticEntities? _staticEntities;
	private Northwind_HydratedStaticIndirectReferenceTransformerModels? _staticIRModels;
	private Mock<INorthwind_dbo_Customers_Repository>? _staticRepository;
	private Mock<IIRTransformers>? _staticIndirectReferenceTransformers;
	private INorthwind_dbo_Customers_RequestHandler? _staticRequestHandler;
	[TestInitialize()]
	public override void Init()
    {
        base.Init();
		_logger = new Mock<ILogger<Northwind_dbo_Customers_RequestHandler>>();		
		isSecondaryLookup = false;
		_dynamicEntities = new Northwind_HydratedDynamicEntities();
		_dynamicIRModels = new Northwind_HydratedDynamicIndirectReferenceTransformerModels();
		_dynamicIndirectReferenceTransformers = new Mock<IIRTransformers>();
		_dynamicIndirectReferenceTransformers!.Setup(x => x.ToIndirectModel(It.IsAny<Northwind_dbo_Customers>(), isSecondaryLookup)).Returns(_dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR());
		_dynamicIndirectReferenceTransformers!.Setup(x => x.ToEntity(It.IsAny<Northwind_dbo_Customers_IR>(), isSecondaryLookup)).Returns(_dynamicEntities!.GetHydratedDynamicNorthwind_dbo_Customers());
		_createValidator = new Northwind_dbo_Customers_IR_FluentValidator_Create();
		_readValidator = new Northwind_dbo_Customers_IR_FluentValidator_Read();
		_updateValidator = new Northwind_dbo_Customers_IR_FluentValidator_Update();
		_deleteValidator = new Northwind_dbo_Customers_IR_FluentValidator_Delete();
		_dynamicRepository = new Mock<INorthwind_dbo_Customers_Repository>();
		_dynamicRepository!.Setup(x => x.GetAll()).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Customers>?)new List<Northwind_dbo_Customers>{_dynamicEntities!.GetHydratedDynamicNorthwind_dbo_Customers()}));
		_staticEntities = new Northwind_HydratedStaticEntities();
		_staticIRModels = new Northwind_HydratedStaticIndirectReferenceTransformerModels();
		_staticIndirectReferenceTransformers = new Mock<IIRTransformers>();
		_staticIndirectReferenceTransformers!.Setup(x => x.ToIndirectModel(It.IsAny<Northwind_dbo_Customers>(), isSecondaryLookup)).Returns(_staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR());
		_staticIndirectReferenceTransformers!.Setup(x => x.ToEntity(It.IsAny<Northwind_dbo_Customers_IR>(), isSecondaryLookup)).Returns(_staticEntities!.GetHydratedStaticNorthwind_dbo_Customers());
		_staticRepository = new Mock<INorthwind_dbo_Customers_Repository>();
		_staticRepository!.Setup(x => x.GetAll()).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Customers>?)new List<Northwind_dbo_Customers>{_staticEntities!.GetHydratedStaticNorthwind_dbo_Customers()}));
		_dynamicRepository!.Setup(x => x.GetByCity(It.IsAny<String?>())).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Customers>?)new List<Northwind_dbo_Customers>{_dynamicEntities!.GetHydratedDynamicNorthwind_dbo_Customers()}));
		_staticRepository!.Setup(x => x.GetByCity(It.IsAny<String?>())).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Customers>?)new List<Northwind_dbo_Customers>{_staticEntities!.GetHydratedStaticNorthwind_dbo_Customers()}));
		_dynamicRepository!.Setup(x => x.GetByCompanyName(It.IsAny<String>())).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Customers>?)new List<Northwind_dbo_Customers>{_dynamicEntities!.GetHydratedDynamicNorthwind_dbo_Customers()}));
		_staticRepository!.Setup(x => x.GetByCompanyName(It.IsAny<String>())).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Customers>?)new List<Northwind_dbo_Customers>{_staticEntities!.GetHydratedStaticNorthwind_dbo_Customers()}));
		_dynamicRepository!.Setup(x => x.GetByCustomerID(It.IsAny<String>())).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Customers>?)new List<Northwind_dbo_Customers>{_dynamicEntities!.GetHydratedDynamicNorthwind_dbo_Customers()}));
		_staticRepository!.Setup(x => x.GetByCustomerID(It.IsAny<String>())).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Customers>?)new List<Northwind_dbo_Customers>{_staticEntities!.GetHydratedStaticNorthwind_dbo_Customers()}));
		_dynamicRepository!.Setup(x => x.GetByPostalCode(It.IsAny<String?>())).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Customers>?)new List<Northwind_dbo_Customers>{_dynamicEntities!.GetHydratedDynamicNorthwind_dbo_Customers()}));
		_staticRepository!.Setup(x => x.GetByPostalCode(It.IsAny<String?>())).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Customers>?)new List<Northwind_dbo_Customers>{_staticEntities!.GetHydratedStaticNorthwind_dbo_Customers()}));
		_dynamicRepository!.Setup(x => x.GetByRegion(It.IsAny<String?>())).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Customers>?)new List<Northwind_dbo_Customers>{_dynamicEntities!.GetHydratedDynamicNorthwind_dbo_Customers()}));
		_staticRepository!.Setup(x => x.GetByRegion(It.IsAny<String?>())).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Customers>?)new List<Northwind_dbo_Customers>{_staticEntities!.GetHydratedStaticNorthwind_dbo_Customers()}));
		_dynamicRepository!.Setup(x => x.Create(It.IsAny<Northwind_dbo_Customers>())).Returns(Task.FromResult((Northwind_dbo_Customers?)_dynamicEntities!.GetHydratedDynamicNorthwind_dbo_Customers()));
		_staticRepository!.Setup(x => x.Create(It.IsAny<Northwind_dbo_Customers>())).Returns(Task.FromResult((Northwind_dbo_Customers?)_staticEntities!.GetHydratedStaticNorthwind_dbo_Customers()));
		_dynamicRepository!.Setup(x => x.UpdateByCity(It.IsAny<String?>(), It.IsAny<Northwind_dbo_Customers>()));
		_staticRepository!.Setup(x => x.UpdateByCity(It.IsAny<String?>(), It.IsAny<Northwind_dbo_Customers>()));
		_dynamicRepository!.Setup(x => x.UpdateByCompanyName(It.IsAny<String>(), It.IsAny<Northwind_dbo_Customers>()));
		_staticRepository!.Setup(x => x.UpdateByCompanyName(It.IsAny<String>(), It.IsAny<Northwind_dbo_Customers>()));
		_dynamicRepository!.Setup(x => x.UpdateByCustomerID(It.IsAny<String>(), It.IsAny<Northwind_dbo_Customers>()));
		_staticRepository!.Setup(x => x.UpdateByCustomerID(It.IsAny<String>(), It.IsAny<Northwind_dbo_Customers>()));
		_dynamicRepository!.Setup(x => x.UpdateByPostalCode(It.IsAny<String?>(), It.IsAny<Northwind_dbo_Customers>()));
		_staticRepository!.Setup(x => x.UpdateByPostalCode(It.IsAny<String?>(), It.IsAny<Northwind_dbo_Customers>()));
		_dynamicRepository!.Setup(x => x.UpdateByRegion(It.IsAny<String?>(), It.IsAny<Northwind_dbo_Customers>()));
		_staticRepository!.Setup(x => x.UpdateByRegion(It.IsAny<String?>(), It.IsAny<Northwind_dbo_Customers>()));
		_dynamicRepository!.Setup(x => x.DeleteByCity(It.IsAny<String?>()));
		_staticRepository!.Setup(x => x.DeleteByCity(It.IsAny<String?>()));
		_dynamicRepository!.Setup(x => x.DeleteByCompanyName(It.IsAny<String>()));
		_staticRepository!.Setup(x => x.DeleteByCompanyName(It.IsAny<String>()));
		_dynamicRepository!.Setup(x => x.DeleteByCustomerID(It.IsAny<String>()));
		_staticRepository!.Setup(x => x.DeleteByCustomerID(It.IsAny<String>()));
		_dynamicRepository!.Setup(x => x.DeleteByPostalCode(It.IsAny<String?>()));
		_staticRepository!.Setup(x => x.DeleteByPostalCode(It.IsAny<String?>()));
		_dynamicRepository!.Setup(x => x.DeleteByRegion(It.IsAny<String?>()));
		_staticRepository!.Setup(x => x.DeleteByRegion(It.IsAny<String?>()));
		_dynamicRequestHandler = new Northwind_dbo_Customers_RequestHandler(_logger.Object, _encryptionDecryptionService!, _dynamicIndirectReferenceTransformers!.Object, _dynamicRepository!.Object, _createValidator!, _readValidator!, _updateValidator!, _deleteValidator!);
		_staticRequestHandler = new Northwind_dbo_Customers_RequestHandler(_logger.Object, _encryptionDecryptionService!, _staticIndirectReferenceTransformers!.Object, _staticRepository!.Object, _createValidator!, _readValidator!, _updateValidator!, _deleteValidator!);
	}
	[TestMethod()]
	public async Task CreateDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		// When
		var retData = await _dynamicRequestHandler!.HandleCreate(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetAllDynamicTest()
	{
		// When
		var retData = await _dynamicRequestHandler!.HandleGetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task CreateStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR();
		// When
		var retData = await _staticRequestHandler!.HandleCreate(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetAllStaticTest()
	{
		// When
		var retData = await _staticRequestHandler!.HandleGetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByCityDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		// When
		var retData = await _dynamicRequestHandler!.HandleGetByCity(input.City);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByCityStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR();
		// When
		var retData = await _staticRequestHandler!.HandleGetByCity(input.City);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByCompanyNameDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		// When
		var retData = await _dynamicRequestHandler!.HandleGetByCompanyName(input.CompanyName ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByCompanyNameStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR();
		// When
		var retData = await _staticRequestHandler!.HandleGetByCompanyName(input.CompanyName ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByCustomerIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		// When
		var retData = await _dynamicRequestHandler!.HandleGetByCustomerID(input.CustomerID ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByCustomerIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR();
		// When
		var retData = await _staticRequestHandler!.HandleGetByCustomerID(input.CustomerID ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByPostalCodeDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		// When
		var retData = await _dynamicRequestHandler!.HandleGetByPostalCode(input.PostalCode);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByPostalCodeStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR();
		// When
		var retData = await _staticRequestHandler!.HandleGetByPostalCode(input.PostalCode);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByRegionDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		// When
		var retData = await _dynamicRequestHandler!.HandleGetByRegion(input.Region);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByRegionStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR();
		// When
		var retData = await _staticRequestHandler!.HandleGetByRegion(input.Region);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByCityDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		// When
		// When
		await _dynamicRequestHandler!.HandleUpdateByCity(input.City, input2);
		// Then
		// TODO: Add test cases
	}
		// When
	[TestMethod()]
	public async Task UpdateByCityStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR();
		// When
		await _staticRequestHandler!.HandleUpdateByCity(input.City, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByCompanyNameDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		// When
		// When
		await _dynamicRequestHandler!.HandleUpdateByCompanyName(input.CompanyName ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
		// When
	[TestMethod()]
	public async Task UpdateByCompanyNameStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR();
		// When
		await _staticRequestHandler!.HandleUpdateByCompanyName(input.CompanyName ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByCustomerIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		// When
		// When
		await _dynamicRequestHandler!.HandleUpdateByCustomerID(input.CustomerID ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
		// When
	[TestMethod()]
	public async Task UpdateByCustomerIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR();
		// When
		await _staticRequestHandler!.HandleUpdateByCustomerID(input.CustomerID ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByPostalCodeDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		// When
		// When
		await _dynamicRequestHandler!.HandleUpdateByPostalCode(input.PostalCode, input2);
		// Then
		// TODO: Add test cases
	}
		// When
	[TestMethod()]
	public async Task UpdateByPostalCodeStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR();
		// When
		await _staticRequestHandler!.HandleUpdateByPostalCode(input.PostalCode, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByRegionDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		// When
		// When
		await _dynamicRequestHandler!.HandleUpdateByRegion(input.Region, input2);
		// Then
		// TODO: Add test cases
	}
		// When
	[TestMethod()]
	public async Task UpdateByRegionStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR();
		// When
		await _staticRequestHandler!.HandleUpdateByRegion(input.Region, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByCityDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		// When
		await _dynamicRequestHandler!.HandleDeleteByCity(input.City);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByCityStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR();
		// When
		await _staticRequestHandler!.HandleDeleteByCity(input.City);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByCompanyNameDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		// When
		await _dynamicRequestHandler!.HandleDeleteByCompanyName(input.CompanyName ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByCompanyNameStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR();
		// When
		await _staticRequestHandler!.HandleDeleteByCompanyName(input.CompanyName ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByCustomerIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		// When
		await _dynamicRequestHandler!.HandleDeleteByCustomerID(input.CustomerID ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByCustomerIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR();
		// When
		await _staticRequestHandler!.HandleDeleteByCustomerID(input.CustomerID ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByPostalCodeDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		// When
		await _dynamicRequestHandler!.HandleDeleteByPostalCode(input.PostalCode);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByPostalCodeStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR();
		// When
		await _staticRequestHandler!.HandleDeleteByPostalCode(input.PostalCode);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByRegionDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		// When
		await _dynamicRequestHandler!.HandleDeleteByRegion(input.Region);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByRegionStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR();
		// When
		await _staticRequestHandler!.HandleDeleteByRegion(input.Region);
		// Then
		// TODO: Add test cases
	}
}
