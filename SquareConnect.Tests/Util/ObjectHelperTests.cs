using SquareConnect.Objects.V1;
using SquareConnect.Util;
using Xunit;

namespace SquareConnect.Tests.Util
{
    public class ObjectHelperTests
    {
        [Fact]
        public void GetEnumFromString_Invalid_String_Returns_Default()
        {
            var moneyCurrencyCodeString = "ZZZ";

            Assert.Equal((MoneyCurrencyCode)0, ObjectHelper.GetEnumFromDescription<MoneyCurrencyCode>(moneyCurrencyCodeString));

        }

        [Fact]
        public void GetEnumFromString_Valid_String_Return_Correct_Enum()
        {
            var moneyCurrencyCodeString = "USD";
            var expectedValeu = MoneyCurrencyCode.USD;

            Assert.Equal(expectedValeu, ObjectHelper.GetEnumFromDescription<MoneyCurrencyCode>(moneyCurrencyCodeString));
        }

        [Fact]
        public void GetEnumFromString_Enum_With_Description_ToString_Value_Fail()
        {
            var refundTypeString = "Partial";
            var expectedValue = RefundType.Partial;

            Assert.NotEqual(expectedValue, ObjectHelper.GetEnumFromDescription<RefundType>(refundTypeString));
        }

        [Fact]
        public void GetEnumFromString_Enum_With_Description_Pass()
        {
            var refundTypeString = "PARTIAL";
            var expectedValue = RefundType.Partial;

            Assert.Equal(expectedValue, ObjectHelper.GetEnumFromDescription<RefundType>(refundTypeString));
        }
    }
}
