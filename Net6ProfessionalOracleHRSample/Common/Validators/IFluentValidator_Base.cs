/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202507 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
namespace XE_HR_Common.Validators;
public interface IFluentValidator_Base
{
    Task<IEnumerable<String>> ValidateValue(Object model, String propertyName);
    Task ValidateValueAndThrow(Object model, String propertyName);
    Task ValidateModelAndThrow(Object model);
}
