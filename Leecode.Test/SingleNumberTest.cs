using Xunit;
using Leecode.Solutions;

namespace Leecode.Test
{
    public class SingleNumberTest
    {
        [Fact]
        public void Test()
        {
            var arr1 = new int[] { 2, 2, 1 };
            var arr2 = new int[] { 4, 1, 2, 1, 2 };

            Assert.Equal(1, Solution.SingleNumber1(arr1));
            Assert.Equal(4, Solution.SingleNumber1(arr2));

        }
    }
}
