using Leecode.Solutions;
using Xunit;

namespace Leecode.Text
{
    public class LongestCommonPrefixTest
    {
        [Fact]
        public void Test()
        {
            var arr = new string[] { };
            var arr1 = new string[] { "flower", "flow", "flight" };
            var arr2 = new string[] { "dog", "racecar", "car" };
            var arr3 = new string[] { "", "b" };
            var arr4 = new string[] { "aa", "aa" };
            var arr5 = new string[] { "abab", "aba", "" };
            var arr6 = new string[] { "aca", "cba" };

            var prefix = LongestCommonPrefix.LongestCommonPrefixFun1(arr);
            var prefix1 = LongestCommonPrefix.LongestCommonPrefixFun1(arr1);
            var prefix2 = LongestCommonPrefix.LongestCommonPrefixFun1(arr2);
            var prefix3 = LongestCommonPrefix.LongestCommonPrefixFun1(arr3);
            var prefix4 = LongestCommonPrefix.LongestCommonPrefixFun1(arr4);
            var prefix5 = LongestCommonPrefix.LongestCommonPrefixFun1(arr5);
            var prefix6 = LongestCommonPrefix.LongestCommonPrefixFun1(arr6);

            Assert.Equal("", prefix);
            Assert.Equal("fl", prefix1);
            Assert.Equal("", prefix2);
            Assert.Equal("", prefix3);
            Assert.Equal("aa", prefix4);
            Assert.Equal("", prefix5);
            Assert.Equal("", prefix6);
        }
    }
}
