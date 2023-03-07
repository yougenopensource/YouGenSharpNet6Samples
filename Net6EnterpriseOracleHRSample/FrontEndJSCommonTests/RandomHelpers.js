/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202605 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
const chars = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789 ';
const charLength = 63;
const utf8Encoder = new TextEncoder();
function generateString(length) {
	let output = '';
	let i = 0;
	for (i; i < length; i++) {
		output += chars.charAt(Math.floor(Math.random() * charLength));
	}
	return output;
}
function generateByteArray(length) {
	return utf8Encoder.encode(generateString(length));
}
function generateByte() {
	return generateByteArray[0];
}
function generateNumber(min,max) {
	return Math.floor(Math.random() * (max - min) ) + min;
}
function generateUint16() {
	return generateNumber(0,65535);
}
function generateInt16() {
	return generateNumber(-32768,32767);
}
function generateUInt32() {
	return generateNumber(0,4294967295);
}
function generateInt32() {
	return generateNumber(-2147483648,2147483647);
}
function generateUint64() {
	return generateNumber(0,9007199254740991);
}
function generateInt64() {
	return generateNumber(-9007199254740991,9007199254740991);
}
function generateNonWholeNumber(precision,scale) {
	const max = '999999999999999';
	const min = '-999999999999999';
	const seedRand = Math.random();
	const adjMax = parseInt(max.substring(0, precision - scale));
	const adjMin = parseInt(min.substring(0, precision - scale + 1));
	const str = (seedRand * (adjMax - adjMin) + adjMin).toFixed(scale);
	return parseFloat(str);
}
function generateDecimal(precision,scale) {
	return generateNonWholeNumber(precision,scale);
}
function generateFloat() {
	return generateNonWholeNumber(8,7);
}
function generateDouble() {
	return generateNonWholeNumber(15,14);
}
function generateBoolean() {
	return Math.random() < 0.5;
}
function generateDateTime() {
	const start = new Date(1901,1,1);
	const end = new Date(1901,1,1);
	return new Date(start.getTime() + Math.random() * (end.getTime() - start.getTime()));
}
function generateDateTimeOffset() {
	return undefined;
}
function generateTimeSpan() {
	return undefined;
}
function generateGuid() {
	let dt = new Date().getTime();
	let guid = 'xxxxxxxx-xxxx-xxxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function(c) {
		dt = Math.floor(dt/16);
		return (c=='x' ? r :(r&0x3|0x8)).toString(16);
	});
	return guid;
}
