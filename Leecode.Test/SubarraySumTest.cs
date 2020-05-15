using Leecode.Solutions;
using Xunit;

namespace Leecode.Test
{
    public class SubarraySumTest
    {
        [Fact]
        public void Test()
        {
            var k1 = 2;
            var arr1 = new int[] { 1, 1, 1 };
            var k2 = 100;
            var arr2 = new int[] { 28, 54, 7, -70, 22, 65, -6 };
            var k3 = 0;
            var arr3 = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };


            Assert.Equal(2, Solution.SubarraySum1(arr1, k1));
            Assert.Equal(1, Solution.SubarraySum1(arr2, k2));
            Assert.Equal(55, Solution.SubarraySum1(arr3, k3));
        }
    }
}
