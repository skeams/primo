using System;
using Xunit;

namespace primo
{
    public class LargeNumberOpertaionsTest
    {
        [Fact]
        public void testFormatResult()
        {
            Assert.Equal("0", LargeNumberOperations.formatResult("000000"));
            Assert.Equal("23", LargeNumberOperations.formatResult("0000000023"));
            Assert.Equal("1055", LargeNumberOperations.formatResult("0001055"));
            Assert.Equal("1055", LargeNumberOperations.formatResult("1055"));
        }

        [Fact]
        public void testMultiplySimple()
        {
            Assert.Equal("99999", LargeNumberOperations.multiply('9', "11111"));
            Assert.Equal("99999", LargeNumberOperations.multiply('9', "00011111"));
            Assert.Equal("0", LargeNumberOperations.multiply('0', "11111"));
        }

        [Fact]
        public void testMultiplyFull()
        {
            string a = "112937";
            string b = "120890823999";
            string result = "13653046989975063";

            Assert.Equal(result, LargeNumberOperations.multiply(a, b));

            a = "0004455";
            b = "00000008857";
            result = "39457935";

            Assert.Equal(result, LargeNumberOperations.multiply(a, b));

            a = "0";
            b = "120890823999";
            result = "0";

            Assert.Equal(result, LargeNumberOperations.multiply(a, b));
        }

        [Fact]
        public void testSum()
        {
            Assert.Equal("302875", LargeNumberOperations.sum("2892", "299983"));
            Assert.Equal("302875", LargeNumberOperations.sum("00002892", "299983"));
            Assert.Equal("10000000000", LargeNumberOperations.sum("1", "9999999999"));
        }
    }
}
