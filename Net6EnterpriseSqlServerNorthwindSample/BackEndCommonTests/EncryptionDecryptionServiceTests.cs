/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Northwind_BackEndCommon.Services;
namespace Northwind_CommonTests.CommonTests;
[TestClass()]
public class EncryptionDecryptionServiceTests : TestBase
{
    protected IEncryptionDecryptionService? _service;
    [TestInitialize()]
    public override void Init()
    {
        base.Init();
        _service = new EncryptionDecryptionService(_customAppSettings!.EncryptDecryptKey!);
    }
    [TestMethod()]
    public void EncDecStrTest()
    {
        var input = "some thing to encrypt and this one is going to be a really really really long string to test because 1234152123421352342353245;'''';1435nn &(*&(*&(*&   &Y(*&(*&()*&)(*&()*&()*&(*YHKLJHLKJHL:KJHLK:J:LKJ:LKJL:KHLKJHLKJHKLJHLKJHLKJHLKJHKLJHLKJHLKJHLKJHKLJH ";
        var result = _service!.EncStr(input);
        var result2 = _service!.DecStr(result);
        Assert.IsTrue(input == result2);
    }
    [TestMethod()]
    public void EncDecByteTest()
    {
        Byte input = Convert.ToByte(123);
        var result = _service!.EncByte(input);
        var result2 = _service!.DecByte(result);
        Assert.IsTrue(input == result2);
    }
    [TestMethod()]
    public void EncDecByteNullableTest()
    {
        Byte? input = Convert.ToByte(123);
        var result = _service!.EncByteNullable(input);
        var result2 = _service!.DecByteNullable(result);
        Assert.IsTrue(input == result2);
        input = null;
        result = _service!.EncByteNullable(input);
        result2 = _service!.DecByteNullable(result);
        Assert.IsTrue(input == result2);
    }
    [TestMethod()]
    public void EncDecInt16Test()
    {
        Int16 input = -1234;
        var result = _service!.EncInt16(input);
        var result2 = _service!.DecInt16(result);
        Assert.IsTrue(input == result2);
    }
    [TestMethod()]
    public void EncDecInt16NullableTest()
    {
        Int16? input = -1234;
        var result = _service!.EncInt16Nullable(input);
        var result2 = _service!.DecInt16Nullable(result);
        Assert.IsTrue(input == result2);
        input = null;
        result = _service!.EncInt16Nullable(input);
        result2 = _service!.DecInt16Nullable(result);
        Assert.IsTrue(input == result2);
    }
    [TestMethod()]
    public void EncDecUInt16Test()
    {
        UInt16 input = 1234;
        var result = _service!.EncUInt16(input);
        var result2 = _service!.DecUInt16(result);
        Assert.IsTrue(input == result2);
    }
    [TestMethod()]
    public void EncDecUInt16NullableTest()
    {
        UInt16? input = 1234;
        var result = _service!.EncUInt16Nullable(input);
        var result2 = _service!.DecUInt16Nullable(result);
        Assert.IsTrue(input == result2);
        input = null;
        result = _service!.EncUInt16Nullable(input);
        result2 = _service!.DecUInt16Nullable(result);
        Assert.IsTrue(input == result2);
    }
    [TestMethod()]
    public void EncDecInt32Test()
    {
        Int32 input  = -1223371457;
        var result = _service!.EncInt32(input);
        var result2 = _service!.DecInt32(result);
        Assert.IsTrue(input == result2);
    }
    [TestMethod()]
    public void EncDecInt32NullableTest()
    {
        Int32? input = -1223371457;
        var result = _service!.EncInt32Nullable(input);
        var result2 = _service!.DecInt32Nullable(result);
        Assert.IsTrue(input == result2);
        input = null;
        result = _service!.EncInt32Nullable(input);
        result2 = _service!.DecInt32Nullable(result);
        Assert.IsTrue(input == result2);
    }
    [TestMethod()]
    public void EncDecUInt32Test()
    {
        UInt32 input = 1223371457;
        var result = _service!.EncUInt32(input);
        var result2 = _service!.DecUInt32(result);
        Assert.IsTrue(input == result2);
    }
    [TestMethod()]
    public void EncDecUInt32NullableTest()
    {
        UInt32? input = 1223371457;
        var result = _service!.EncUInt32Nullable(input);
        var result2 = _service!.DecUInt32Nullable(result);
        Assert.IsTrue(input == result2);
        input = null;
        result = _service!.EncUInt32Nullable(input);
        result2 = _service!.DecUInt32Nullable(result);
        Assert.IsTrue(input == result2);
    }
    [TestMethod()]
    public void EncDecInt64Test()
    {
        Int64 input = -1223371231231457;
        var result = _service!.EncInt64(input);
        var result2 = _service!.DecInt64(result);
        Assert.IsTrue(input == result2);
    }
    [TestMethod()]
    public void EncDecInt64NullableTest()
    {
        Int64? input = -1223371231231457;
        var result = _service!.EncInt64Nullable(input);
        var result2 = _service!.DecInt64Nullable(result);
        Assert.IsTrue(input == result2);
        input = null;
        result = _service!.EncInt64Nullable(input);
        result2 = _service!.DecInt64Nullable(result);
        Assert.IsTrue(input == result2);
    }
    [TestMethod()]
    public void EncDecUInt64Test()
    {
        UInt64 input = 1223371231231457;
        var result = _service!.EncUInt64(input);
        var result2 = _service!.DecUInt64(result);
        Assert.IsTrue(input == result2);
    }
    [TestMethod()]
    public void EncDecUInt64NullableTest()
    {
        UInt64? input = 1223371231231457;
        var result = _service!.EncUInt64Nullable(input);
        var result2 = _service!.DecUInt64Nullable(result);
        Assert.IsTrue(input == result2);
        input = null;
        result = _service!.EncUInt64Nullable(input);
        result2 = _service!.DecUInt64Nullable(result);
        Assert.IsTrue(input == result2);
    }
    [TestMethod()]
    public void EncDecDecimalTest()
    {
        Decimal input = -1234.4m;
        var result = _service!.EncDecimal(input);
        var result2 = _service!.DecDecimal(result);
        Assert.IsTrue(input == result2);
    }
    [TestMethod()]
    public void EncDecDecimalNullableTest()
    {
        Decimal? input = -1234.4m;
        var result = _service!.EncDecimalNullable(input);
        var result2 = _service!.DecDecimalNullable(result);
        Assert.IsTrue(input == result2);
        input = null;
        result = _service!.EncDecimalNullable(input);
        result2 = _service!.DecDecimalNullable(result);
        Assert.IsTrue(input == result2);
    }
    [TestMethod()]
    public void EncDecDoubleTest()
    {
        Double input = -1234.4d;
        var result = _service!.EncDouble(input);
        var result2 = _service!.DecDouble(result);
        Assert.IsTrue(input == result2);
    }
    [TestMethod()]
    public void EncDecDoubleNullableTest()
    {
        Double? input = -1234.4d;
        var result = _service!.EncDoubleNullable(input);
        var result2 = _service!.DecDoubleNullable(result);
        Assert.IsTrue(input == result2);
        input = null;
        result = _service!.EncDoubleNullable(input);
        result2 = _service!.DecDoubleNullable(result);
        Assert.IsTrue(input == result2);
    }
    [TestMethod()]
    public void CreateHashTest()
    {
        String input = "some other 1235 && -^% string";
        var result = _service!.CreateHash(input);
        Assert.IsTrue(!String.IsNullOrWhiteSpace(result));
        Assert.IsTrue(input != result);
    }
}
