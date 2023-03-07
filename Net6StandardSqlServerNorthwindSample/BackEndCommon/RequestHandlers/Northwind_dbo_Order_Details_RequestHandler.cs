/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195656 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Standard Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Northwind_BackEndDatabaseClient.Repositories;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndCommon.RequestHandlers;
public class Northwind_dbo_Order_Details_RequestHandler : INorthwind_dbo_Order_Details_RequestHandler
{
    private readonly ILogger<Northwind_dbo_Order_Details_RequestHandler> _logger;
    private readonly INorthwind_dbo_Order_Details_Repository _repository;
    public Northwind_dbo_Order_Details_RequestHandler(
    ILogger<Northwind_dbo_Order_Details_RequestHandler> logger
    ,INorthwind_dbo_Order_Details_Repository repository)
    {
        _logger = logger;
        _repository = repository;
    }
	//Main Handlers
	public async Task<IEnumerable<Northwind_dbo_Order_Details>?> HandleGetAll()
	{
		var retData = await _repository.GetAll();
		return retData;
	}
	public async Task<IEnumerable<Northwind_dbo_Order_Details>?> HandleGetByOrderIDAndProductID(Int32 orderID, Int32 productID)
	{
		var retData = await _repository.GetByOrderIDAndProductID(orderID, productID);
		return retData;
	}
	public async Task<IEnumerable<Northwind_dbo_Order_Details>?> HandleGetByOrderID(Int32 orderID)
	{
		var retData = await _repository.GetByOrderID(orderID);
		return retData;
	}
	public async Task<IEnumerable<Northwind_dbo_Order_Details>?> HandleGetByProductID(Int32 productID)
	{
		var retData = await _repository.GetByProductID(productID);
		return retData;
	}
	public async Task<Northwind_dbo_Order_Details?> HandleCreate(Northwind_dbo_Order_Details input)
	{
		var results = await _repository.Create(input);
		return results;
	}
	public async Task HandleUpdateByOrderIDAndProductID(Int32 orderID, Int32 productID, Northwind_dbo_Order_Details entity)
	{
		await _repository.UpdateByOrderIDAndProductID(orderID, productID, entity);
	}
	public async Task HandleUpdateByOrderID(Int32 orderID, Northwind_dbo_Order_Details entity)
	{
		await _repository.UpdateByOrderID(orderID, entity);
	}
	public async Task HandleUpdateByProductID(Int32 productID, Northwind_dbo_Order_Details entity)
	{
		await _repository.UpdateByProductID(productID, entity);
	}
	public async Task HandleDeleteByOrderIDAndProductID(Int32 orderID, Int32 productID)
	{
		await _repository.DeleteByOrderIDAndProductID(orderID, productID);
	}
	public async Task HandleDeleteByOrderID(Int32 orderID)
	{
		await _repository.DeleteByOrderID(orderID);
	}
	public async Task HandleDeleteByProductID(Int32 productID)
	{
		await _repository.DeleteByProductID(productID);
	}
}
