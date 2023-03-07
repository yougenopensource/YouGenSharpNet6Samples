/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202605 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XE_HR_BackEndCommonTests.RequestHandlerUnitTests;
using XE_HR_BackEndDatabaseClient.Repositories;
using XE_HR_BackEndSqlEntities.Entities;
using XE_HR_Common.IndirectReferenceTransformerModels;
using XE_HR_Common.Validators;
using XE_HR_BackEndCommon.IndirectReferenceTransformers;
using XE_HR_BackEndCommon.RequestHandlers;
using XE_HR_BackEndDatabaseClientTests.HydratedStaticEntities;
using XE_HR_CommonTests.HydratedStaticIndirectReferenceTransformerModels;
using XE_HR_BackEndDatabaseClientTests.HydratedDynamicEntities;
using XE_HR_CommonTests.HydratedDynamicIndirectReferenceTransformerModels;
namespace XE_HR_BackEndCommonTests;
[TestClass()]
public class XE_HR_PACKAGE1_OPEN_ONE_CURSOR_StoredProcedure_RequestHandler_UnitTests : RequestHandlerUnitTestBase
{
    private Mock<ILogger<XE_HR_PACKAGE1_OPEN_ONE_CURSOR_StoredProcedure_RequestHandler>>? _logger;
	private XE_HR_HydratedStaticEntities? _staticEntities;
	private XE_HR_HydratedStaticIndirectReferenceTransformerModels? _staticIRModels;
	private XE_HR_PACKAGE1_OPEN_ONE_CURSOR_IM_IR_FluentValidator? _inputValidator;
	private XE_HR_HydratedDynamicEntities? _dynamicEntities;
	private XE_HR_HydratedDynamicIndirectReferenceTransformerModels? _dynamicIRModels;
	private Mock<IXE_HR_PACKAGE1_OPEN_ONE_CURSOR_StoredProcedure_Repository>? _staticRepository;
	private Mock<IIRTransformers>? _staticIndirectReferenceTransformers;
	private IXE_HR_PACKAGE1_OPEN_ONE_CURSOR_StoredProcedure_RequestHandler? _staticRequestHandler;
	private Mock<IXE_HR_PACKAGE1_OPEN_ONE_CURSOR_StoredProcedure_Repository>? _dynamicRepository;
	private Mock<IIRTransformers>? _dynamicIndirectReferenceTransformers;
	private IXE_HR_PACKAGE1_OPEN_ONE_CURSOR_StoredProcedure_RequestHandler? _dynamicRequestHandler;
	[TestInitialize()]
    public override void Init()
    {
        base.Init();
        _logger = new Mock<ILogger<XE_HR_PACKAGE1_OPEN_ONE_CURSOR_StoredProcedure_RequestHandler>>();		
		_staticEntities = new XE_HR_HydratedStaticEntities();
		_staticIRModels = new XE_HR_HydratedStaticIndirectReferenceTransformerModels();
		_staticIndirectReferenceTransformers = new Mock<IIRTransformers>();
		_staticIndirectReferenceTransformers!.Setup(x => x.ToIndirectModel(It.IsAny<XE_HR_PACKAGE1_OPEN_ONE_CURSOR_IM>())).Returns(_staticIRModels!.GetHydratedStaticXE_HR_PACKAGE1_OPEN_ONE_CURSOR_IM_IR());
		_staticIndirectReferenceTransformers!.Setup(x => x.ToEntity(It.IsAny<XE_HR_PACKAGE1_OPEN_ONE_CURSOR_IM_IR>())).Returns(_staticEntities!.GetHydratedStaticXE_HR_PACKAGE1_OPEN_ONE_CURSOR_IM());
		_staticIndirectReferenceTransformers!.Setup(x => x.ToIndirectModel(It.IsAny<XE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM>())).Returns(_staticIRModels!.GetHydratedStaticXE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM_IR());
		_staticIndirectReferenceTransformers!.Setup(x => x.ToEntity(It.IsAny<XE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM_IR>())).Returns(_staticEntities!.GetHydratedStaticXE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM());
		_inputValidator = new XE_HR_PACKAGE1_OPEN_ONE_CURSOR_IM_IR_FluentValidator();
		_dynamicEntities = new XE_HR_HydratedDynamicEntities();
		_dynamicIRModels = new XE_HR_HydratedDynamicIndirectReferenceTransformerModels();
		_dynamicIndirectReferenceTransformers = new Mock<IIRTransformers>();
		_dynamicIndirectReferenceTransformers!.Setup(x => x.ToIndirectModel(It.IsAny<XE_HR_PACKAGE1_OPEN_ONE_CURSOR_IM>())).Returns(_dynamicIRModels!.GetHydratedDynamicXE_HR_PACKAGE1_OPEN_ONE_CURSOR_IM_IR());
		_dynamicIndirectReferenceTransformers!.Setup(x => x.ToEntity(It.IsAny<XE_HR_PACKAGE1_OPEN_ONE_CURSOR_IM_IR>())).Returns(_dynamicEntities!.GetHydratedDynamicXE_HR_PACKAGE1_OPEN_ONE_CURSOR_IM());
		_dynamicIndirectReferenceTransformers!.Setup(x => x.ToIndirectModel(It.IsAny<XE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM>())).Returns(_dynamicIRModels!.GetHydratedDynamicXE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM_IR());
		_dynamicIndirectReferenceTransformers!.Setup(x => x.ToEntity(It.IsAny<XE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM_IR>())).Returns(_dynamicEntities!.GetHydratedDynamicXE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM());
		_staticRepository = new Mock<IXE_HR_PACKAGE1_OPEN_ONE_CURSOR_StoredProcedure_Repository>();
		_staticRepository!.Setup(x => x.Call_XE_HR_PACKAGE1_OPEN_ONE_CURSOR(It.IsAny<XE_HR_PACKAGE1_OPEN_ONE_CURSOR_IM>())).Returns(Task.FromResult((XE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM?)_staticEntities!.GetHydratedStaticXE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM()));
		_dynamicRepository = new Mock<IXE_HR_PACKAGE1_OPEN_ONE_CURSOR_StoredProcedure_Repository>();
		_dynamicRepository!.Setup(x => x.Call_XE_HR_PACKAGE1_OPEN_ONE_CURSOR(It.IsAny<XE_HR_PACKAGE1_OPEN_ONE_CURSOR_IM>())).Returns(Task.FromResult((XE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM?)_dynamicEntities!.GetHydratedDynamicXE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM()));
		_dynamicRequestHandler = new XE_HR_PACKAGE1_OPEN_ONE_CURSOR_StoredProcedure_RequestHandler(_logger!.Object, _encryptionDecryptionService!, _dynamicIndirectReferenceTransformers!.Object, _dynamicRepository!.Object, _inputValidator!);
		_staticRequestHandler = new XE_HR_PACKAGE1_OPEN_ONE_CURSOR_StoredProcedure_RequestHandler(_logger!.Object, _encryptionDecryptionService!, _staticIndirectReferenceTransformers!.Object, _staticRepository!.Object, _inputValidator!);
    }
	[TestMethod()]
	public async Task StaticCall_XE_HR_PACKAGE1_OPEN_ONE_CURSOR_Test()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_PACKAGE1_OPEN_ONE_CURSOR_IM_IR();
		// When
		var retData = await _staticRequestHandler!.HandleCall_XE_HR_PACKAGE1_OPEN_ONE_CURSOR(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicCall_XE_HR_PACKAGE1_OPEN_ONE_CURSOR_Test()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_PACKAGE1_OPEN_ONE_CURSOR_IM_IR();
		// When
		var retData = await _dynamicRequestHandler!.HandleCall_XE_HR_PACKAGE1_OPEN_ONE_CURSOR(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
}
