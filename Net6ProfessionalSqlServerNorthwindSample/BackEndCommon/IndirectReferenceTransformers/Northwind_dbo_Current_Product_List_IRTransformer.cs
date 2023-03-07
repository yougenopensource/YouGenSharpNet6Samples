/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Northwind_BackEndSqlEntities.Entities;
using Northwind_BackEndCommon.Services;
using Northwind_Common.IndirectReferenceTransformerModels;
namespace Northwind_BackEndCommon.IndirectReferenceTransformers;
public partial class IRTransformers : IIRTransformers
{
	public Northwind_dbo_Current_Product_List_IR ToIndirectModel(Northwind_dbo_Current_Product_List input)
	{
		var retData = new Northwind_dbo_Current_Product_List_IR(
			productID_IR_ : _encryptionDecryptionService!.EncInt32(input.ProductID),
			productName_ : input.ProductName
			);
		return retData;
	}
	public Northwind_dbo_Current_Product_List ToEntity(Northwind_dbo_Current_Product_List_IR input)
	{
		var retData = new Northwind_dbo_Current_Product_List(		
			productID_ : _encryptionDecryptionService.DecInt32(input.ProductID_IR),
			productName_ : input.ProductName ?? String.Empty
			);
		return retData;
	}
}