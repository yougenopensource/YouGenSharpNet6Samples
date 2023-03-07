/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
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
public class Northwind_dbo_Order_Details_RequestHandler : INorthwind_dbo_Order_Details_RequestHandler
{
    private readonly ILogger<Northwind_dbo_Order_Details_RequestHandler> _logger;
    private readonly IEncryptionDecryptionService _encryptionDecryptionService; 
    private readonly IIRTransformers _indirectReferenceTransformers;
    private readonly INorthwind_dbo_Order_Details_Repository _repository;
    private readonly Northwind_dbo_Order_Details_IR_FluentValidator_Create _createValidator;
    private readonly Northwind_dbo_Order_Details_IR_FluentValidator_Read _readValidator;
    private readonly Northwind_dbo_Order_Details_IR_FluentValidator_Update _updateValidator;
    private readonly Northwind_dbo_Order_Details_IR_FluentValidator_Delete _deleteValidator;
    public Northwind_dbo_Order_Details_RequestHandler(
        ILogger<Northwind_dbo_Order_Details_RequestHandler> logger
        ,IEncryptionDecryptionService encryptionDecryptionService
        ,IIRTransformers indirectReferenceTransformers
        ,INorthwind_dbo_Order_Details_Repository repository 
        ,Northwind_dbo_Order_Details_IR_FluentValidator_Create createValidator
        ,Northwind_dbo_Order_Details_IR_FluentValidator_Read readValidator
        ,Northwind_dbo_Order_Details_IR_FluentValidator_Update updateValidator
        ,Northwind_dbo_Order_Details_IR_FluentValidator_Delete deleteValidator
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
	public async Task<IEnumerable<Northwind_dbo_Order_Details_IR>?> HandleGetAll()
	{
		await PreHandleGetAll();
		var retData = await _repository.GetAll();
		await PostHandleGetAll();
		return retData == null || !retData.Any() ? Enumerable.Empty<Northwind_dbo_Order_Details_IR>() : retData.Select(x => _indirectReferenceTransformers.ToIndirectModel(x)!).ToList();
	}
	public async Task<IEnumerable<Northwind_dbo_Order_Details_IR>?> HandleGetByOrderIDAndProductID(String? orderID_IR, String? productID_IR)
	{
		await PreHandleGetByOrderIDAndProductID(orderID_IR, productID_IR);
		var retData = await _repository.GetByOrderIDAndProductID(_encryptionDecryptionService.DecInt32(orderID_IR), _encryptionDecryptionService.DecInt32(productID_IR));
		await PostHandleGetByOrderIDAndProductID(orderID_IR, productID_IR);
		return retData == null || !retData.Any() ? Enumerable.Empty<Northwind_dbo_Order_Details_IR>() : retData.Select(x => _indirectReferenceTransformers.ToIndirectModel(x)!).ToList();
	}
	public async Task<IEnumerable<Northwind_dbo_Order_Details_IR>?> HandleGetByOrderID(String? orderID_IR)
	{
		await PreHandleGetByOrderID(orderID_IR);
		var retData = await _repository.GetByOrderID(_encryptionDecryptionService.DecInt32(orderID_IR));
		await PostHandleGetByOrderID(orderID_IR);
		return retData == null || !retData.Any() ? Enumerable.Empty<Northwind_dbo_Order_Details_IR>() : retData.Select(x => _indirectReferenceTransformers.ToIndirectModel(x)!).ToList();
	}
	public async Task<IEnumerable<Northwind_dbo_Order_Details_IR>?> HandleGetByProductID(String? productID_IR)
	{
		await PreHandleGetByProductID(productID_IR);
		var retData = await _repository.GetByProductID(_encryptionDecryptionService.DecInt32(productID_IR));
		await PostHandleGetByProductID(productID_IR);
		return retData == null || !retData.Any() ? Enumerable.Empty<Northwind_dbo_Order_Details_IR>() : retData.Select(x => _indirectReferenceTransformers.ToIndirectModel(x)!).ToList();
	}
	public async Task<Northwind_dbo_Order_Details_IR?> HandleCreate<T>(T irModel) where T : Northwind_dbo_Order_Details_IR
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
	public async Task HandleUpdateByOrderIDAndProductID<T>(String? orderID_IR, String? productID_IR, T irModel) where T : Northwind_dbo_Order_Details_IR
	{
		var entity = _indirectReferenceTransformers.ToEntity(irModel);
		await PreHandleUpdateByOrderIDAndProductID(orderID_IR, productID_IR, irModel);
		await _repository.UpdateByOrderIDAndProductID(_encryptionDecryptionService.DecInt32(orderID_IR), _encryptionDecryptionService.DecInt32(productID_IR), entity!);
		await PostHandleUpdateByOrderIDAndProductID(orderID_IR, productID_IR, irModel);
	}
	public async Task HandleUpdateByOrderID<T>(String? orderID_IR, T irModel) where T : Northwind_dbo_Order_Details_IR
	{
		var entity = _indirectReferenceTransformers.ToEntity(irModel);
		await PreHandleUpdateByOrderID(orderID_IR, irModel);
		await _repository.UpdateByOrderID(_encryptionDecryptionService.DecInt32(orderID_IR), entity!);
		await PostHandleUpdateByOrderID(orderID_IR, irModel);
	}
	public async Task HandleUpdateByProductID<T>(String? productID_IR, T irModel) where T : Northwind_dbo_Order_Details_IR
	{
		var entity = _indirectReferenceTransformers.ToEntity(irModel);
		await PreHandleUpdateByProductID(productID_IR, irModel);
		await _repository.UpdateByProductID(_encryptionDecryptionService.DecInt32(productID_IR), entity!);
		await PostHandleUpdateByProductID(productID_IR, irModel);
	}
	public async Task HandleDeleteByOrderIDAndProductID(String? orderID_IR, String? productID_IR)
	{
		await PreHandleDeleteByOrderIDAndProductID(orderID_IR, productID_IR);
		await _repository.DeleteByOrderIDAndProductID(_encryptionDecryptionService.DecInt32(orderID_IR), _encryptionDecryptionService.DecInt32(productID_IR));
		await PostHandleDeleteByOrderIDAndProductID(orderID_IR, productID_IR);
	}
	public async Task HandleDeleteByOrderID(String? orderID_IR)
	{
		await PreHandleDeleteByOrderID(orderID_IR);
		await _repository.DeleteByOrderID(_encryptionDecryptionService.DecInt32(orderID_IR));
		await PostHandleDeleteByOrderID(orderID_IR);
	}
	public async Task HandleDeleteByProductID(String? productID_IR)
	{
		await PreHandleDeleteByProductID(productID_IR);
		await _repository.DeleteByProductID(_encryptionDecryptionService.DecInt32(productID_IR));
		await PostHandleDeleteByProductID(productID_IR);
	}
	//PreCRUD Handlers
	private async Task PreHandleGetAll()
	{
		// Add preCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PreHandleGetByOrderIDAndProductID(String? orderID_IR, String? productID_IR)
	{
		// Add preCRUD calls/events
		var selectorProperties = new Northwind_dbo_Order_Details_IR();
		selectorProperties.OrderID_IR = orderID_IR;
		selectorProperties.ProductID_IR = productID_IR;
		await _readValidator.ValidateModelAndThrow(selectorProperties);
	}
	private async Task PreHandleGetByOrderID(String? orderID_IR)
	{
		// Add preCRUD calls/events
		var selectorProperties = new Northwind_dbo_Order_Details_IR();
		selectorProperties.OrderID_IR = orderID_IR;
		await _readValidator.ValidateModelAndThrow(selectorProperties);
	}
	private async Task PreHandleGetByProductID(String? productID_IR)
	{
		// Add preCRUD calls/events
		var selectorProperties = new Northwind_dbo_Order_Details_IR();
		selectorProperties.ProductID_IR = productID_IR;
		await _readValidator.ValidateModelAndThrow(selectorProperties);
	}
	private async Task PreHandleCreate(Northwind_dbo_Order_Details_IR irModel)
	{
		// Add preCRUD calls/events
		await _createValidator.ValidateModelAndThrow(irModel);
	}
	private async Task PreHandleUpdateByOrderIDAndProductID(String? orderID_IR, String? productID_IR, Northwind_dbo_Order_Details_IR irModel)
	{
		// Add preCRUD calls/events
		var selectorProperties = new Northwind_dbo_Order_Details_IR();
		selectorProperties.OrderID_IR = orderID_IR;
		selectorProperties.ProductID_IR = productID_IR;
		await _readValidator.ValidateModelAndThrow(selectorProperties);
		await _updateValidator.ValidateModelAndThrow(irModel);
	}
	private async Task PreHandleUpdateByOrderID(String? orderID_IR, Northwind_dbo_Order_Details_IR irModel)
	{
		// Add preCRUD calls/events
		var selectorProperties = new Northwind_dbo_Order_Details_IR();
		selectorProperties.OrderID_IR = orderID_IR;
		await _readValidator.ValidateModelAndThrow(selectorProperties);
		await _updateValidator.ValidateModelAndThrow(irModel);
	}
	private async Task PreHandleUpdateByProductID(String? productID_IR, Northwind_dbo_Order_Details_IR irModel)
	{
		// Add preCRUD calls/events
		var selectorProperties = new Northwind_dbo_Order_Details_IR();
		selectorProperties.ProductID_IR = productID_IR;
		await _readValidator.ValidateModelAndThrow(selectorProperties);
		await _updateValidator.ValidateModelAndThrow(irModel);
	}
	private async Task PreHandleDeleteByOrderIDAndProductID(String? orderID_IR, String? productID_IR)
	{
		// Add preCRUD calls/events
		var selectorProperties = new Northwind_dbo_Order_Details_IR();
		selectorProperties.OrderID_IR = orderID_IR;
		selectorProperties.ProductID_IR = productID_IR;
		await _deleteValidator.ValidateModelAndThrow(selectorProperties);
	}
	private async Task PreHandleDeleteByOrderID(String? orderID_IR)
	{
		// Add preCRUD calls/events
		var selectorProperties = new Northwind_dbo_Order_Details_IR();
		selectorProperties.OrderID_IR = orderID_IR;
		await _deleteValidator.ValidateModelAndThrow(selectorProperties);
	}
	private async Task PreHandleDeleteByProductID(String? productID_IR)
	{
		// Add preCRUD calls/events
		var selectorProperties = new Northwind_dbo_Order_Details_IR();
		selectorProperties.ProductID_IR = productID_IR;
		await _deleteValidator.ValidateModelAndThrow(selectorProperties);
	}
	//PostCRUD Handlers
	private async Task PostHandleGetAll()
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PostHandleGetByOrderIDAndProductID(String? orderID_IR, String? productID_IR)
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PostHandleGetByOrderID(String? orderID_IR)
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PostHandleGetByProductID(String? productID_IR)
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PostHandleCreate(Northwind_dbo_Order_Details_IR irModel)
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PostHandleUpdateByOrderIDAndProductID(String? orderID_IR, String? productID_IR, Northwind_dbo_Order_Details_IR irModel)
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PostHandleUpdateByOrderID(String? orderID_IR, Northwind_dbo_Order_Details_IR irModel)
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PostHandleUpdateByProductID(String? productID_IR, Northwind_dbo_Order_Details_IR irModel)
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PostHandleDeleteByOrderIDAndProductID(String? orderID_IR, String? productID_IR)
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PostHandleDeleteByOrderID(String? orderID_IR)
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PostHandleDeleteByProductID(String? productID_IR)
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
}