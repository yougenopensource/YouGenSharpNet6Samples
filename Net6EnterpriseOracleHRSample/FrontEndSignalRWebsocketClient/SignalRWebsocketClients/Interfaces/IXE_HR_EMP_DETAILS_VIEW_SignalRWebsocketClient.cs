/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202605 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using XE_HR_Common.IndirectReferenceTransformerModels;
namespace XE_HR_FrontEndSignalRWebsocketClient.SignalRWebsocketClients;
public interface IXE_HR_EMP_DETAILS_VIEW_SignalRWebsocketClient
{
	Task<IEnumerable<XE_HR_EMP_DETAILS_VIEW_IR>?> GetAll();
	Task<IEnumerable<XE_HR_EMP_DETAILS_VIEW_IR>?> GetByBestMatchedQueryPattern(XE_HR_EMP_DETAILS_VIEW_IR input);
    Task InitializeAsync();
    Boolean GetStatus();
    ValueTask DisposeAsync();
}
