using System;
using Xunit;

namespace primo
{
    public class RSAOperationsTest
    {
        [Fact]
        public void testCalculatePhi()
        {
            Assert.Equal("2395401", RSAOperations.calculatePhi("4000", "600"));
        }
    }
}