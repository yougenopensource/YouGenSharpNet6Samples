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
using XE_HR_Common.IndirectReferenceTransformerModels;
using XE_HR_BackEndDatabaseClient.Repositories;
using XE_HR_Common.Validators;
using XE_HR_BackEndCommon.IndirectReferenceTransformers;
using XE_HR_BackEndCommon.Services;
namespace XE_HR_BackEndCommon.RequestHandlers;
public class XE_HR_REGIONS_RequestHandler : IXE_HR_REGIONS_RequestHandler
{
    private readonly ILogger<XE_HR_REGIONS_RequestHandler> _logger;
    private readonly IEncryptionDecryptionService _encryptionDecryptionService; 
    private readonly IIRTransformers _indirectReferenceTransformers;
    private readonly IXE_HR_REGIONS_Repository _repository;
    private readonly XE_HR_REGIONS_IR_FluentValidator_Create _createValidator;
    private readonly XE_HR_REGIONS_IR_FluentValidator_Read _readValidator;
    private readonly XE_HR_REGIONS_IR_FluentValidator_Update _updateValidator;
    private readonly XE_HR_REGIONS_IR_FluentValidator_Delete _deleteValidator;
    public XE_HR_REGIONS_RequestHandler(
        ILogger<XE_HR_REGIONS_RequestHandler> logger
        ,IEncryptionDecryptionService encryptionDecryptionService
        ,IIRTransformers indirectReferenceTransformers
        ,IXE_HR_REGIONS_Repository repository 
        ,XE_HR_REGIONS_IR_FluentValidator_Create createValidator
        ,XE_HR_REGIONS_IR_FluentValidator_Read readValidator
        ,XE_HR_REGIONS_IR_FluentValidator_Update updateValidator
        ,XE_HR_REGIONS_IR_FluentValidator_Delete deleteValidator
    )
    {
        _logger = logger;
        _encryptionDecryptionService = encryptionDecryptionService;
        _indirectReferenceTransformers = indirectReferenceTransformers;
        _repository = repository;
        _createValidator = createValidator;
        _readValidator = readValidator;
        _updateValidator = updateValidator;
        _deleteValidator = deleteValidator;
    }
	//Main Handlers
	public async Task<IEnumerable<XE_HR_REGIONS_IR>?> HandleGetAll()
	{
		await PreHandleGetAll();
		var retData = await _repository.GetAll();
		await PostHandleGetAll();
		return retData == null || !retData.Any() ? Enumerable.Empty<XE_HR_REGIONS_IR>() : retData.Select(x => _indirectReferenceTransformers.ToIndirectModel(x)!).ToList();
	}
	public async Task<IEnumerable<XE_HR_REGIONS_IR>?> HandleGetByREGION_ID(String? rEGION_ID_IR)
	{
		await PreHandleGetByREGION_ID(rEGION_ID_IR);
		var retData = await _repository.GetByREGION_ID(_encryptionDecryptionService.DecInt32(rEGION_ID_IR));
		await PostHandleGetByREGION_ID(rEGION_ID_IR);
		return retData == null || !retData.Any() ? Enumerable.Empty<XE_HR_REGIONS_IR>() : retData.Select(x => _indirectReferenceTransformers.ToIndirectModel(x)!).ToList();
	}
	public async Task<XE_HR_REGIONS_IR?> HandleCreate<T>(T irModel) where T : XE_HR_REGIONS_IR
	{
		var entity = _indirectReferenceTransformers.ToEntity(irModel);
		await PreHandleCreate(irModel);
		entity = await _repository.Create(entity!);
		if (entity != null) 
		{
			await PostHandleCreate(irModel);
			return _indirectReferenceTransformers.ToIndirectModel(entity!);
		}
		else
			return null;
	}
	public async Task HandleUpdateByREGION_ID<T>(String? rEGION_ID_IR, T irModel) where T : XE_HR_REGIONS_IR
	{
		var entity = _indirectReferenceTransformers.ToEntity(irModel);
		await PreHandleUpdateByREGION_ID(rEGION_ID_IR, irModel);
		await _repository.UpdateByREGION_ID(_encryptionDecryptionService.DecInt32(rEGION_ID_IR), entity!);
		await PostHandleUpdateByREGION_ID(rEGION_ID_IR, irModel);
	}
	public async Task HandleDeleteByREGION_ID(String? rEGION_ID_IR)
	{
		await PreHandleDeleteByREGION_ID(rEGION_ID_IR);
		await _repository.DeleteByREGION_ID(_encryptionDecryptionService.DecInt32(rEGION_ID_IR));
		await PostHandleDeleteByREGION_ID(rEGION_ID_IR);
	}
	//PreCRUD Handlers
	private async Task PreHandleGetAll()
	{
		// Add preCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PreHandleGetByREGION_ID(String? rEGION_ID_IR)
	{
		// Add preCRUD calls/events
		var selectorProperties = new XE_HR_REGIONS_IR();
		selectorProperties.REGION_ID_IR = rEGION_ID_IR;
		await _readValidator.ValidateModelAndThrow(selectorProperties);
	}
	private async Task PreHandleCreate(XE_HR_REGIONS_IR irModel)
	{
		// Add preCRUD calls/events
		await _createValidator.ValidateModelAndThrow(irModel);
	}
	private async Task PreHandleUpdateByREGION_ID(String? rEGION_ID_IR, XE_HR_REGIONS_IR irModel)
	{
		// Add preCRUD calls/events
		var selectorProperties = new XE_HR_REGIONS_IR();
		selectorProperties.REGION_ID_IR = rEGION_ID_IR;
		await _readValidator.ValidateModelAndThrow(selectorProperties);
		await _updateValidator.ValidateModelAndThrow(irModel);
	}
	private async Task PreHandleDeleteByREGION_ID(String? rEGION_ID_IR)
	{
		// Add preCRUD calls/events
		var selectorProperties = new XE_HR_REGIONS_IR();
		selectorProperties.REGION_ID_IR = rEGION_ID_IR;
		await _deleteValidator.ValidateModelAndThrow(selectorProperties);
	}
	//PostCRUD Handlers
	private async Task PostHandleGetAll()
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PostHandleGetByREGION_ID(String? rEGION_ID_IR)
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PostHandleCreate(XE_HR_REGIONS_IR irModel)
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PostHandleUpdateByREGION_ID(String? rEGION_ID_IR, XE_HR_REGIONS_IR irModel)
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PostHandleDeleteByREGION_ID(String? rEGION_ID_IR)
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
}
