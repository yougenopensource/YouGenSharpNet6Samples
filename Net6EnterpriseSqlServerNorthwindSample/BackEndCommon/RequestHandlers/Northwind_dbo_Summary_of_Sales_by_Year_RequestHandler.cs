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
public class Northwind_dbo_Summary_of_Sales_by_Year_RequestHandler : INorthwind_dbo_Summary_of_Sales_by_Year_RequestHandler
{
    private readonly ILogger<Northwind_dbo_Summary_of_Sales_by_Year_RequestHandler> _logger;
    private readonly IEncryptionDecryptionService _encryptionDecryptionService; 
    private readonly IIRTransformers _indirectReferenceTransformers;
    private readonly INorthwind_dbo_Summary_of_Sales_by_Year_Repository _repository;
    private readonly Northwind_dbo_Summary_of_Sales_by_Year_IR_FluentValidator _readValidator;
    public Northwind_dbo_Summary_of_Sales_by_Year_RequestHandler(
        ILogger<Northwind_dbo_Summary_of_Sales_by_Year_RequestHandler> logger
        ,IEncryptionDecryptionService encryptionDecryptionService
        ,IIRTransformers indirectReferenceTransformers
        ,INorthwind_dbo_Summary_of_Sales_by_Year_Repository repository
        ,Northwind_dbo_Summary_of_Sales_by_Year_IR_FluentValidator readValidator
    )
    {
        _logger = logger;
        _encryptionDecryptionService = encryptionDecryptionService;
        _indirectReferenceTransformers = indirectReferenceTransformers;
        _repository = repository;
        _readValidator = readValidator;
    }
	//Main Handlers
	public async Task<IEnumerable<Northwind_dbo_Summary_of_Sales_by_Year_IR>?> HandleGetAll()
	{
		await PreHandleGetAll();
		var retData = await _repository.GetAll();
		await PostHandleGetAll();
		return retData == null || !retData.Any() ? Enumerable.Empty<Northwind_dbo_Summary_of_Sales_by_Year_IR>() : retData.Select(x => _indirectReferenceTransformers.ToIndirectModel(x)!).ToArray().ToList();
	}
	//PreCRUD Handlers
	private async Task PreHandleGetAll()
	{
		// Add preCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	//PostCRUD Handlers
	private async Task PostHandleGetAll()
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
}
