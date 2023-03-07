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
using Northwind_Common.IndirectReferenceTransformerModels;
using Northwind_BackEndDatabaseClient.Repositories;
using Northwind_Common.Validators;
using Northwind_BackEndCommon.IndirectReferenceTransformers;
using Northwind_BackEndCommon.Services;
namespace Northwind_BackEndCommon.RequestHandlers;
public class Northwind_dbo_Categories_RequestHandler : INorthwind_dbo_Categories_RequestHandler
{
    private readonly ILogger<Northwind_dbo_Categories_RequestHandler> _logger;
    private readonly IEncryptionDecryptionService _encryptionDecryptionService; 
    private readonly IIRTransformers _indirectReferenceTransformers;
    private readonly INorthwind_dbo_Categories_Repository _repository;
    private readonly Northwind_dbo_Categories_IR_FluentValidator_Create _createValidator;
    private readonly Northwind_dbo_Categories_IR_FluentValidator_Read _readValidator;
    private readonly Northwind_dbo_Categories_IR_FluentValidator_Update _updateValidator;
    private readonly Northwind_dbo_Categories_IR_FluentValidator_Delete _deleteValidator;
    public Northwind_dbo_Categories_RequestHandler(
        ILogger<Northwind_dbo_Categories_RequestHandler> logger
        ,IEncryptionDecryptionService encryptionDecryptionService
        ,IIRTransformers indirectReferenceTransformers
        ,INorthwind_dbo_Categories_Repository repository 
        ,Northwind_dbo_Categories_IR_FluentValidator_Create createValidator
        ,Northwind_dbo_Categories_IR_FluentValidator_Read readValidator
        ,Northwind_dbo_Categories_IR_FluentValidator_Update updateValidator
        ,Northwind_dbo_Categories_IR_FluentValidator_Delete deleteValidator
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
	public async Task<IEnumerable<Northwind_dbo_Categories_IR>?> HandleGetAll()
	{
		await PreHandleGetAll();
		var retData = await _repository.GetAll();
		await PostHandleGetAll();
		return retData == null || !retData.Any() ? Enumerable.Empty<Northwind_dbo_Categories_IR>() : retData.Select(x => _indirectReferenceTransformers.ToIndirectModel(x)!).ToList();
	}
	public async Task<IEnumerable<Northwind_dbo_Categories_IR>?> HandleGetByCategoryName(String categoryName)
	{
		await PreHandleGetByCategoryName(categoryName);
		var retData = await _repository.GetByCategoryName((categoryName));
		await PostHandleGetByCategoryName(categoryName);
		return retData == null || !retData.Any() ? Enumerable.Empty<Northwind_dbo_Categories_IR>() : retData.Select(x => _indirectReferenceTransformers.ToIndirectModel(x)!).ToList();
	}
	public async Task<IEnumerable<Northwind_dbo_Categories_IR>?> HandleGetByCategoryID(String? categoryID_IR)
	{
		await PreHandleGetByCategoryID(categoryID_IR);
		var retData = await _repository.GetByCategoryID(_encryptionDecryptionService.DecInt32(categoryID_IR));
		await PostHandleGetByCategoryID(categoryID_IR);
		return retData == null || !retData.Any() ? Enumerable.Empty<Northwind_dbo_Categories_IR>() : retData.Select(x => _indirectReferenceTransformers.ToIndirectModel(x)!).ToList();
	}
	public async Task<Northwind_dbo_Categories_IR?> HandleCreate<T>(T irModel) where T : Northwind_dbo_Categories_IR
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
	public async Task HandleUpdateByCategoryName<T>(String categoryName, T irModel) where T : Northwind_dbo_Categories_IR
	{
		var entity = _indirectReferenceTransformers.ToEntity(irModel);
		await PreHandleUpdateByCategoryName(categoryName, irModel);
		await _repository.UpdateByCategoryName((categoryName), entity!);
		await PostHandleUpdateByCategoryName(categoryName, irModel);
	}
	public async Task HandleUpdateByCategoryID<T>(String? categoryID_IR, T irModel) where T : Northwind_dbo_Categories_IR
	{
		var entity = _indirectReferenceTransformers.ToEntity(irModel);
		await PreHandleUpdateByCategoryID(categoryID_IR, irModel);
		await _repository.UpdateByCategoryID(_encryptionDecryptionService.DecInt32(categoryID_IR), entity!);
		await PostHandleUpdateByCategoryID(categoryID_IR, irModel);
	}
	public async Task HandleDeleteByCategoryName(String categoryName)
	{
		await PreHandleDeleteByCategoryName(categoryName);
		await _repository.DeleteByCategoryName((categoryName));
		await PostHandleDeleteByCategoryName(categoryName);
	}
	public async Task HandleDeleteByCategoryID(String? categoryID_IR)
	{
		await PreHandleDeleteByCategoryID(categoryID_IR);
		await _repository.DeleteByCategoryID(_encryptionDecryptionService.DecInt32(categoryID_IR));
		await PostHandleDeleteByCategoryID(categoryID_IR);
	}
	//PreCRUD Handlers
	private async Task PreHandleGetAll()
	{
		// Add preCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PreHandleGetByCategoryName(String categoryName)
	{
		// Add preCRUD calls/events
		var selectorProperties = new Northwind_dbo_Categories_IR();
		selectorProperties.CategoryName = categoryName;
		await _readValidator.ValidateModelAndThrow(selectorProperties);
	}
	private async Task PreHandleGetByCategoryID(String? categoryID_IR)
	{
		// Add preCRUD calls/events
		var selectorProperties = new Northwind_dbo_Categories_IR();
		selectorProperties.CategoryID_IR = categoryID_IR;
		await _readValidator.ValidateModelAndThrow(selectorProperties);
	}
	private async Task PreHandleCreate(Northwind_dbo_Categories_IR irModel)
	{
		// Add preCRUD calls/events
		await _createValidator.ValidateModelAndThrow(irModel);
	}
	private async Task PreHandleUpdateByCategoryName(String categoryName, Northwind_dbo_Categories_IR irModel)
	{
		// Add preCRUD calls/events
		var selectorProperties = new Northwind_dbo_Categories_IR();
		selectorProperties.CategoryName = categoryName;
		await _readValidator.ValidateModelAndThrow(selectorProperties);
		await _updateValidator.ValidateModelAndThrow(irModel);
	}
	private async Task PreHandleUpdateByCategoryID(String? categoryID_IR, Northwind_dbo_Categories_IR irModel)
	{
		// Add preCRUD calls/events
		var selectorProperties = new Northwind_dbo_Categories_IR();
		selectorProperties.CategoryID_IR = categoryID_IR;
		await _readValidator.ValidateModelAndThrow(selectorProperties);
		await _updateValidator.ValidateModelAndThrow(irModel);
	}
	private async Task PreHandleDeleteByCategoryName(String categoryName)
	{
		// Add preCRUD calls/events
		var selectorProperties = new Northwind_dbo_Categories_IR();
		selectorProperties.CategoryName = categoryName;
		await _deleteValidator.ValidateModelAndThrow(selectorProperties);
	}
	private async Task PreHandleDeleteByCategoryID(String? categoryID_IR)
	{
		// Add preCRUD calls/events
		var selectorProperties = new Northwind_dbo_Categories_IR();
		selectorProperties.CategoryID_IR = categoryID_IR;
		await _deleteValidator.ValidateModelAndThrow(selectorProperties);
	}
	//PostCRUD Handlers
	private async Task PostHandleGetAll()
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PostHandleGetByCategoryName(String categoryName)
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PostHandleGetByCategoryID(String? categoryID_IR)
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PostHandleCreate(Northwind_dbo_Categories_IR irModel)
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PostHandleUpdateByCategoryName(String categoryName, Northwind_dbo_Categories_IR irModel)
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PostHandleUpdateByCategoryID(String? categoryID_IR, Northwind_dbo_Categories_IR irModel)
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PostHandleDeleteByCategoryName(String categoryName)
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PostHandleDeleteByCategoryID(String? categoryID_IR)
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
}
