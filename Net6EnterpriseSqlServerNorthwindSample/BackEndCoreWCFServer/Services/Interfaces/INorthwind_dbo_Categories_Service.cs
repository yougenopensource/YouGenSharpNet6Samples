/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Northwind_Common.IndirectReferenceTransformerModels;
namespace Northwind_BackEndCoreWCFServer.Services;
[ServiceContract]
public interface INorthwind_dbo_Categories_Service
{
	[OperationContract]
	Task<IEnumerable<Northwind_dbo_Categories_IR>?> GetAll();
	[OperationContract]
	Task<IEnumerable<Northwind_dbo_Categories_IR>?> GetByCategoryName(String categoryName);
	[OperationContract]
	Task<IEnumerable<Northwind_dbo_Categories_IR>?> GetByCategoryID(String? categoryID_IR);
	[OperationContract]
	Task<Northwind_dbo_Categories_IR?> Create(Northwind_dbo_Categories_IR input);
	[OperationContract]
	Task UpdateByCategoryName(String categoryName, Northwind_dbo_Categories_IR input);
	[OperationContract]
	Task UpdateByCategoryID(String? categoryID_IR, Northwind_dbo_Categories_IR input);
	[OperationContract]
	Task DeleteByCategoryName(String categoryName);
	[OperationContract]
	Task DeleteByCategoryID(String? categoryID_IR);
}
