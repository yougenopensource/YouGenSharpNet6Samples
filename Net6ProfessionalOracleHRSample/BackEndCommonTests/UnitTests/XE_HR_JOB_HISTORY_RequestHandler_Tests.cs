/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202507 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using XE_HR_BackEndSqlEntities.Entities;
using XE_HR_BackEndDatabaseClient.Repositories;
using XE_HR_Common.IndirectReferenceTransformerModels;
using XE_HR_Common.Validators;
using XE_HR_BackEndCommon.IndirectReferenceTransformers;
using XE_HR_BackEndCommon.RequestHandlers;
using XE_HR_BackEndDatabaseClientTests.HydratedStaticEntities;
using XE_HR_BackEndDatabaseClientTests.HydratedDynamicEntities;
using XE_HR_CommonTests.HydratedStaticIndirectReferenceTransformerModels;
using XE_HR_CommonTests.HydratedDynamicIndirectReferenceTransformerModels;
namespace XE_HR_BackEndCommonTests.RequestHandlerUnitTests;
[TestClass()]
public class XE_HR_JOB_HISTORY_RequestHandler_UnitTests : RequestHandlerUnitTestBase
{
	private Mock<ILogger<XE_HR_JOB_HISTORY_RequestHandler>>? _logger;
	private Boolean isSecondaryLookup;
	private XE_HR_HydratedDynamicEntities? _dynamicEntities;
	private XE_HR_HydratedDynamicIndirectReferenceTransformerModels? _dynamicIRModels;
	private Mock<IXE_HR_JOB_HISTORY_Repository>? _dynamicRepository;
	private Mock<IIRTransformers>? _dynamicIndirectReferenceTransformers;
	private XE_HR_JOB_HISTORY_IR_FluentValidator_Create? _createValidator;
	private XE_HR_JOB_HISTORY_IR_FluentValidator_Read? _readValidator;
	private XE_HR_JOB_HISTORY_IR_FluentValidator_Update? _updateValidator;
	private XE_HR_JOB_HISTORY_IR_FluentValidator_Delete? _deleteValidator;
	private IXE_HR_JOB_HISTORY_RequestHandler? _dynamicRequestHandler;
	private XE_HR_HydratedStaticEntities? _staticEntities;
	private XE_HR_HydratedStaticIndirectReferenceTransformerModels? _staticIRModels;
	private Mock<IXE_HR_JOB_HISTORY_Repository>? _staticRepository;
	private Mock<IIRTransformers>? _staticIndirectReferenceTransformers;
	private IXE_HR_JOB_HISTORY_RequestHandler? _staticRequestHandler;
	[TestInitialize()]
	public override void Init()
    {
        base.Init();
		_logger = new Mock<ILogger<XE_HR_JOB_HISTORY_RequestHandler>>();		
		isSecondaryLookup = false;
		_dynamicEntities = new XE_HR_HydratedDynamicEntities();
		_dynamicIRModels = new XE_HR_HydratedDynamicIndirectReferenceTransformerModels();
		_dynamicIndirectReferenceTransformers = new Mock<IIRTransformers>();
		_dynamicIndirectReferenceTransformers!.Setup(x => x.ToIndirectModel(It.IsAny<XE_HR_JOB_HISTORY>(), isSecondaryLookup)).Returns(_dynamicIRModels!.GetHydratedDynamicXE_HR_JOB_HISTORY_IR());
		_dynamicIndirectReferenceTransformers!.Setup(x => x.ToEntity(It.IsAny<XE_HR_JOB_HISTORY_IR>(), isSecondaryLookup)).Returns(_dynamicEntities!.GetHydratedDynamicXE_HR_JOB_HISTORY());
		_createValidator = new XE_HR_JOB_HISTORY_IR_FluentValidator_Create();
		_readValidator = new XE_HR_JOB_HISTORY_IR_FluentValidator_Read();
		_updateValidator = new XE_HR_JOB_HISTORY_IR_FluentValidator_Update();
		_deleteValidator = new XE_HR_JOB_HISTORY_IR_FluentValidator_Delete();
		_dynamicRepository = new Mock<IXE_HR_JOB_HISTORY_Repository>();
		_dynamicRepository!.Setup(x => x.GetAll()).Returns(Task.FromResult((IEnumerable<XE_HR_JOB_HISTORY>?)new List<XE_HR_JOB_HISTORY>{_dynamicEntities!.GetHydratedDynamicXE_HR_JOB_HISTORY()}));
		_staticEntities = new XE_HR_HydratedStaticEntities();
		_staticIRModels = new XE_HR_HydratedStaticIndirectReferenceTransformerModels();
		_staticIndirectReferenceTransformers = new Mock<IIRTransformers>();
		_staticIndirectReferenceTransformers!.Setup(x => x.ToIndirectModel(It.IsAny<XE_HR_JOB_HISTORY>(), isSecondaryLookup)).Returns(_staticIRModels!.GetHydratedStaticXE_HR_JOB_HISTORY_IR());
		_staticIndirectReferenceTransformers!.Setup(x => x.ToEntity(It.IsAny<XE_HR_JOB_HISTORY_IR>(), isSecondaryLookup)).Returns(_staticEntities!.GetHydratedStaticXE_HR_JOB_HISTORY());
		_staticRepository = new Mock<IXE_HR_JOB_HISTORY_Repository>();
		_staticRepository!.Setup(x => x.GetAll()).Returns(Task.FromResult((IEnumerable<XE_HR_JOB_HISTORY>?)new List<XE_HR_JOB_HISTORY>{_staticEntities!.GetHydratedStaticXE_HR_JOB_HISTORY()}));
		_dynamicRepository!.Setup(x => x.GetByEMPLOYEE_IDAndSTART_DATE(It.IsAny<Int32>(), It.IsAny<DateTime>())).Returns(Task.FromResult((IEnumerable<XE_HR_JOB_HISTORY>?)new List<XE_HR_JOB_HISTORY>{_dynamicEntities!.GetHydratedDynamicXE_HR_JOB_HISTORY()}));
		_staticRepository!.Setup(x => x.GetByEMPLOYEE_IDAndSTART_DATE(It.IsAny<Int32>(), It.IsAny<DateTime>())).Returns(Task.FromResult((IEnumerable<XE_HR_JOB_HISTORY>?)new List<XE_HR_JOB_HISTORY>{_staticEntities!.GetHydratedStaticXE_HR_JOB_HISTORY()}));
		_dynamicRepository!.Setup(x => x.GetByDEPARTMENT_ID(It.IsAny<Int32?>())).Returns(Task.FromResult((IEnumerable<XE_HR_JOB_HISTORY>?)new List<XE_HR_JOB_HISTORY>{_dynamicEntities!.GetHydratedDynamicXE_HR_JOB_HISTORY()}));
		_staticRepository!.Setup(x => x.GetByDEPARTMENT_ID(It.IsAny<Int32?>())).Returns(Task.FromResult((IEnumerable<XE_HR_JOB_HISTORY>?)new List<XE_HR_JOB_HISTORY>{_staticEntities!.GetHydratedStaticXE_HR_JOB_HISTORY()}));
		_dynamicRepository!.Setup(x => x.GetByEMPLOYEE_ID(It.IsAny<Int32>())).Returns(Task.FromResult((IEnumerable<XE_HR_JOB_HISTORY>?)new List<XE_HR_JOB_HISTORY>{_dynamicEntities!.GetHydratedDynamicXE_HR_JOB_HISTORY()}));
		_staticRepository!.Setup(x => x.GetByEMPLOYEE_ID(It.IsAny<Int32>())).Returns(Task.FromResult((IEnumerable<XE_HR_JOB_HISTORY>?)new List<XE_HR_JOB_HISTORY>{_staticEntities!.GetHydratedStaticXE_HR_JOB_HISTORY()}));
		_dynamicRepository!.Setup(x => x.GetByJOB_ID(It.IsAny<String>())).Returns(Task.FromResult((IEnumerable<XE_HR_JOB_HISTORY>?)new List<XE_HR_JOB_HISTORY>{_dynamicEntities!.GetHydratedDynamicXE_HR_JOB_HISTORY()}));
		_staticRepository!.Setup(x => x.GetByJOB_ID(It.IsAny<String>())).Returns(Task.FromResult((IEnumerable<XE_HR_JOB_HISTORY>?)new List<XE_HR_JOB_HISTORY>{_staticEntities!.GetHydratedStaticXE_HR_JOB_HISTORY()}));
		_dynamicRepository!.Setup(x => x.Create(It.IsAny<XE_HR_JOB_HISTORY>())).Returns(Task.FromResult((XE_HR_JOB_HISTORY?)_dynamicEntities!.GetHydratedDynamicXE_HR_JOB_HISTORY()));
		_staticRepository!.Setup(x => x.Create(It.IsAny<XE_HR_JOB_HISTORY>())).Returns(Task.FromResult((XE_HR_JOB_HISTORY?)_staticEntities!.GetHydratedStaticXE_HR_JOB_HISTORY()));
		_dynamicRepository!.Setup(x => x.UpdateByEMPLOYEE_IDAndSTART_DATE(It.IsAny<Int32>(), It.IsAny<DateTime>(), It.IsAny<XE_HR_JOB_HISTORY>()));
		_staticRepository!.Setup(x => x.UpdateByEMPLOYEE_IDAndSTART_DATE(It.IsAny<Int32>(), It.IsAny<DateTime>(), It.IsAny<XE_HR_JOB_HISTORY>()));
		_dynamicRepository!.Setup(x => x.UpdateByDEPARTMENT_ID(It.IsAny<Int32?>(), It.IsAny<XE_HR_JOB_HISTORY>()));
		_staticRepository!.Setup(x => x.UpdateByDEPARTMENT_ID(It.IsAny<Int32?>(), It.IsAny<XE_HR_JOB_HISTORY>()));
		_dynamicRepository!.Setup(x => x.UpdateByEMPLOYEE_ID(It.IsAny<Int32>(), It.IsAny<XE_HR_JOB_HISTORY>()));
		_staticRepository!.Setup(x => x.UpdateByEMPLOYEE_ID(It.IsAny<Int32>(), It.IsAny<XE_HR_JOB_HISTORY>()));
		_dynamicRepository!.Setup(x => x.UpdateByJOB_ID(It.IsAny<String>(), It.IsAny<XE_HR_JOB_HISTORY>()));
		_staticRepository!.Setup(x => x.UpdateByJOB_ID(It.IsAny<String>(), It.IsAny<XE_HR_JOB_HISTORY>()));
		_dynamicRepository!.Setup(x => x.DeleteByEMPLOYEE_IDAndSTART_DATE(It.IsAny<Int32>(), It.IsAny<DateTime>()));
		_staticRepository!.Setup(x => x.DeleteByEMPLOYEE_IDAndSTART_DATE(It.IsAny<Int32>(), It.IsAny<DateTime>()));
		_dynamicRepository!.Setup(x => x.DeleteByDEPARTMENT_ID(It.IsAny<Int32?>()));
		_staticRepository!.Setup(x => x.DeleteByDEPARTMENT_ID(It.IsAny<Int32?>()));
		_dynamicRepository!.Setup(x => x.DeleteByEMPLOYEE_ID(It.IsAny<Int32>()));
		_staticRepository!.Setup(x => x.DeleteByEMPLOYEE_ID(It.IsAny<Int32>()));
		_dynamicRepository!.Setup(x => x.DeleteByJOB_ID(It.IsAny<String>()));
		_staticRepository!.Setup(x => x.DeleteByJOB_ID(It.IsAny<String>()));
		_dynamicRequestHandler = new XE_HR_JOB_HISTORY_RequestHandler(_logger.Object, _encryptionDecryptionService!, _dynamicIndirectReferenceTransformers!.Object, _dynamicRepository!.Object, _createValidator!, _readValidator!, _updateValidator!, _deleteValidator!);
		_staticRequestHandler = new XE_HR_JOB_HISTORY_RequestHandler(_logger.Object, _encryptionDecryptionService!, _staticIndirectReferenceTransformers!.Object, _staticRepository!.Object, _createValidator!, _readValidator!, _updateValidator!, _deleteValidator!);
	}
	[TestMethod()]
	public async Task CreateDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_JOB_HISTORY_IR();
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
		var input = _staticIRModels!.GetHydratedStaticXE_HR_JOB_HISTORY_IR();
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
	public async Task GetByEMPLOYEE_IDAndSTART_DATEDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_JOB_HISTORY_IR();
		// When
		var retData = await _dynamicRequestHandler!.HandleGetByEMPLOYEE_IDAndSTART_DATE(input.EMPLOYEE_ID_IR ?? String.Empty, input.START_DATE ?? new DateTime());
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByEMPLOYEE_IDAndSTART_DATEStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_JOB_HISTORY_IR();
		// When
		var retData = await _staticRequestHandler!.HandleGetByEMPLOYEE_IDAndSTART_DATE(input.EMPLOYEE_ID_IR ?? String.Empty, input.START_DATE ?? new DateTime());
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByDEPARTMENT_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_JOB_HISTORY_IR();
		// When
		var retData = await _dynamicRequestHandler!.HandleGetByDEPARTMENT_ID(input.DEPARTMENT_ID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByDEPARTMENT_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_JOB_HISTORY_IR();
		// When
		var retData = await _staticRequestHandler!.HandleGetByDEPARTMENT_ID(input.DEPARTMENT_ID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByEMPLOYEE_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_JOB_HISTORY_IR();
		// When
		var retData = await _dynamicRequestHandler!.HandleGetByEMPLOYEE_ID(input.EMPLOYEE_ID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByEMPLOYEE_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_JOB_HISTORY_IR();
		// When
		var retData = await _staticRequestHandler!.HandleGetByEMPLOYEE_ID(input.EMPLOYEE_ID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByJOB_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_JOB_HISTORY_IR();
		// When
		var retData = await _dynamicRequestHandler!.HandleGetByJOB_ID(input.JOB_ID ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByJOB_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_JOB_HISTORY_IR();
		// When
		var retData = await _staticRequestHandler!.HandleGetByJOB_ID(input.JOB_ID ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByEMPLOYEE_IDAndSTART_DATEDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_JOB_HISTORY_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicXE_HR_JOB_HISTORY_IR();
		// When
		// When
		await _dynamicRequestHandler!.HandleUpdateByEMPLOYEE_IDAndSTART_DATE(input.EMPLOYEE_ID_IR ?? String.Empty, input.START_DATE ?? new DateTime(), input2);
		// Then
		// TODO: Add test cases
	}
		// When
	[TestMethod()]
	public async Task UpdateByEMPLOYEE_IDAndSTART_DATEStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_JOB_HISTORY_IR();
		// When
		await _staticRequestHandler!.HandleUpdateByEMPLOYEE_IDAndSTART_DATE(input.EMPLOYEE_ID_IR ?? String.Empty, input.START_DATE ?? new DateTime(), input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByDEPARTMENT_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_JOB_HISTORY_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicXE_HR_JOB_HISTORY_IR();
		// When
		// When
		await _dynamicRequestHandler!.HandleUpdateByDEPARTMENT_ID(input.DEPARTMENT_ID_IR ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
		// When
	[TestMethod()]
	public async Task UpdateByDEPARTMENT_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_JOB_HISTORY_IR();
		// When
		await _staticRequestHandler!.HandleUpdateByDEPARTMENT_ID(input.DEPARTMENT_ID_IR ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByEMPLOYEE_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_JOB_HISTORY_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicXE_HR_JOB_HISTORY_IR();
		// When
		// When
		await _dynamicRequestHandler!.HandleUpdateByEMPLOYEE_ID(input.EMPLOYEE_ID_IR ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
		// When
	[TestMethod()]
	public async Task UpdateByEMPLOYEE_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_JOB_HISTORY_IR();
		// When
		await _staticRequestHandler!.HandleUpdateByEMPLOYEE_ID(input.EMPLOYEE_ID_IR ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByJOB_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_JOB_HISTORY_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicXE_HR_JOB_HISTORY_IR();
		// When
		// When
		await _dynamicRequestHandler!.HandleUpdateByJOB_ID(input.JOB_ID ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
		// When
	[TestMethod()]
	public async Task UpdateByJOB_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_JOB_HISTORY_IR();
		// When
		await _staticRequestHandler!.HandleUpdateByJOB_ID(input.JOB_ID ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByEMPLOYEE_IDAndSTART_DATEDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_JOB_HISTORY_IR();
		// When
		await _dynamicRequestHandler!.HandleDeleteByEMPLOYEE_IDAndSTART_DATE(input.EMPLOYEE_ID_IR ?? String.Empty, input.START_DATE ?? new DateTime());
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByEMPLOYEE_IDAndSTART_DATEStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_JOB_HISTORY_IR();
		// When
		await _staticRequestHandler!.HandleDeleteByEMPLOYEE_IDAndSTART_DATE(input.EMPLOYEE_ID_IR ?? String.Empty, input.START_DATE ?? new DateTime());
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByDEPARTMENT_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_JOB_HISTORY_IR();
		// When
		await _dynamicRequestHandler!.HandleDeleteByDEPARTMENT_ID(input.DEPARTMENT_ID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByDEPARTMENT_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_JOB_HISTORY_IR();
		// When
		await _staticRequestHandler!.HandleDeleteByDEPARTMENT_ID(input.DEPARTMENT_ID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByEMPLOYEE_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_JOB_HISTORY_IR();
		// When
		await _dynamicRequestHandler!.HandleDeleteByEMPLOYEE_ID(input.EMPLOYEE_ID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByEMPLOYEE_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_JOB_HISTORY_IR();
		// When
		await _staticRequestHandler!.HandleDeleteByEMPLOYEE_ID(input.EMPLOYEE_ID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByJOB_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_JOB_HISTORY_IR();
		// When
		await _dynamicRequestHandler!.HandleDeleteByJOB_ID(input.JOB_ID ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByJOB_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_JOB_HISTORY_IR();
		// When
		await _staticRequestHandler!.HandleDeleteByJOB_ID(input.JOB_ID ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
}
