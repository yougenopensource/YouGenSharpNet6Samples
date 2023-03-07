/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202605 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using XE_HR_Common.IndirectReferenceTransformerModels;
namespace XE_HR_BackEndCoreWCFServer.Services;
[ServiceContract]
public interface IXE_HR_COUNTRIES_Service
{
	[OperationContract]
	Task<IEnumerable<XE_HR_COUNTRIES_IR>?> GetAll();
	[OperationContract]
	Task<IEnumerable<XE_HR_COUNTRIES_IR>?> GetByCOUNTRY_ID(String cOUNTRY_ID);
	[OperationContract]
	Task<XE_HR_COUNTRIES_IR?> Create(XE_HR_COUNTRIES_IR input);
	[OperationContract]
	Task UpdateByCOUNTRY_ID(String cOUNTRY_ID, XE_HR_COUNTRIES_IR input);
	[OperationContract]
	Task DeleteByCOUNTRY_ID(String cOUNTRY_ID);
}
