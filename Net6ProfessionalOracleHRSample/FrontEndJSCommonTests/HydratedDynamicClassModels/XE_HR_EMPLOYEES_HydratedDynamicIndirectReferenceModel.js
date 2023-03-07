/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202507 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
function getHydratedDynamicXE_HR_EMPLOYEES(fillPrimaryKey = false) {
	let retObj = new XE_HR_EMPLOYEES_IR();
	retObj.EMPLOYEE_ID_IR = (fillPrimaryKey ? encrypt(1) : null);
	retObj.FIRST_NAME = generateString(20);
	retObj.LAST_NAME = generateString(25);
	retObj.EMAIL = generateString(25);
	retObj.PHONE_NUMBER = generateString(20);
	retObj.HIRE_DATE = generateDateTime();
	retObj.JOB_ID = generateString(10);
	retObj.SALARY = generateDecimal(8,2);
	retObj.COMMISSION_PCT = generateDecimal(2,2);
	retObj.MANAGER_ID_IR = encrypt(1);
	retObj.DEPARTMENT_ID_IR = encrypt(1);
	// Foreign key entities
	retObj.EMP_DEPT_FK_Ref_IR = getHydratedDynamicXE_HR_DEPARTMENTS_IR();
	retObj.EMP_JOB_FK_Ref_IR = getHydratedDynamicXE_HR_JOBS_IR();
	retObj.EMP_MANAGER_FK_Ref_IR = getHydratedDynamicXE_HR_EMPLOYEES_IR();
	return retObj;
}
