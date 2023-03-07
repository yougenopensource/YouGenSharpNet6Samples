/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202605 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Newtonsoft.Json;
using XE_HR_BackEndCommon.Configuration;
namespace XE_HR_CommonTests;
public class TestBase
{
	protected CustomAppSettings? _customAppSettings;
	[TestInitialize()]
    public virtual void Init()
    {
	    _customAppSettings = JsonConvert.DeserializeObject<CustomAppSettings>(File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "appSettings.Test.json")));
	}
}