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
public class XE_HR_EMP_DETAILS_VIEW_RequestHandler_UnitTests : RequestHandlerUnitTestBase
{
	private Mock<ILogger<XE_HR_EMP_DETAILS_VIEW_RequestHandler>>? _logger;
	private XE_HR_HydratedDynamicEntities? _dynamicEntities;
	private XE_HR_HydratedDynamicIndirectReferenceTransformerModels? _dynamicIRModels;
	private Mock<IXE_HR_EMP_DETAILS_VIEW_Repository>? _dynamicRepository;
	private Mock<IIRTransformers>? _dynamicIndirectReferenceTransformers;
	private XE_HR_EMP_DETAILS_VIEW_IR_FluentValidator? _readValidator;
	private IXE_HR_EMP_DETAILS_VIEW_RequestHandler? _dynamicRequestHandler;
	private XE_HR_HydratedStaticEntities? _staticEntities;
	private XE_HR_HydratedStaticIndirectReferenceTransformerModels? _staticIRModels;
	private Mock<IXE_HR_EMP_DETAILS_VIEW_Repository>? _staticRepository;
	private Mock<IIRTransformers>? _staticIndirectReferenceTransformers;
	private IXE_HR_EMP_DETAILS_VIEW_RequestHandler? _staticRequestHandler;
	[TestInitialize()]
	public override void Init()
    {
        base.Init();
		_logger = new Mock<ILogger<XE_HR_EMP_DETAILS_VIEW_RequestHandler>>();		
		_dynamicEntities = new XE_HR_HydratedDynamicEntities();
		_dynamicIRModels = new XE_HR_HydratedDynamicIndirectReferenceTransformerModels();
		_dynamicIndirectReferenceTransformers = new Mock<IIRTransformers>();
		_dynamicIndirectReferenceTransformers!.Setup(x => x.ToIndirectModel(It.IsAny<XE_HR_EMP_DETAILS_VIEW>())).Returns(_dynamicIRModels!.GetHydratedDynamicXE_HR_EMP_DETAILS_VIEW_IR());
		_dynamicIndirectReferenceTransformers!.Setup(x => x.ToEntity(It.IsAny<XE_HR_EMP_DETAILS_VIEW_IR>())).Returns(_dynamicEntities!.GetHydratedDynamicXE_HR_EMP_DETAILS_VIEW());
		_readValidator = new XE_HR_EMP_DETAILS_VIEW_IR_FluentValidator();
		_dynamicRepository = new Mock<IXE_HR_EMP_DETAILS_VIEW_Repository>();
		_dynamicRepository!.Setup(x => x.GetAll()).Returns(Task.FromResult((IEnumerable<XE_HR_EMP_DETAILS_VIEW>?)new List<XE_HR_EMP_DETAILS_VIEW>{_dynamicEntities!.GetHydratedDynamicXE_HR_EMP_DETAILS_VIEW()}));
		_staticEntities = new XE_HR_HydratedStaticEntities();
		_staticIRModels = new XE_HR_HydratedStaticIndirectReferenceTransformerModels();
		_staticIndirectReferenceTransformers = new Mock<IIRTransformers>();
		_staticIndirectReferenceTransformers!.Setup(x => x.ToIndirectModel(It.IsAny<XE_HR_EMP_DETAILS_VIEW>())).Returns(_staticIRModels!.GetHydratedStaticXE_HR_EMP_DETAILS_VIEW_IR());
		_staticIndirectReferenceTransformers!.Setup(x => x.ToEntity(It.IsAny<XE_HR_EMP_DETAILS_VIEW_IR>())).Returns(_staticEntities!.GetHydratedStaticXE_HR_EMP_DETAILS_VIEW());
		_staticRepository = new Mock<IXE_HR_EMP_DETAILS_VIEW_Repository>();
		_staticRepository!.Setup(x => x.GetAll()).Returns(Task.FromResult((IEnumerable<XE_HR_EMP_DETAILS_VIEW>?)new List<XE_HR_EMP_DETAILS_VIEW>{_staticEntities!.GetHydratedStaticXE_HR_EMP_DETAILS_VIEW()}));
		_dynamicRequestHandler = new XE_HR_EMP_DETAILS_VIEW_RequestHandler(_logger.Object, _encryptionDecryptionService!, _dynamicIndirectReferenceTransformers!.Object, _dynamicRepository!.Object, _readValidator!);
		_staticRequestHandler = new XE_HR_EMP_DETAILS_VIEW_RequestHandler(_logger.Object, _encryptionDecryptionService!, _staticIndirectReferenceTransformers!.Object, _staticRepository!.Object, _readValidator!);
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
	public async Task GetAllStaticTest()
	{
		// When
		var retData = await _staticRequestHandler!.HandleGetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
}
