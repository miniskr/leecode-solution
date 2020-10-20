using Leecode.Solutions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Leecode.Test
{
    public class ValidParenthesesTest
    {
        [Fact]
        public void Test()
        {
            var s1 = "{{{{{{";
            var s2 = "(([]}))}";
            var s3 = "(())[]{}";
            var s4 = "(({[))]}";

            var valid = new ValidParentheses();

            Assert.False(valid.IsValid(s1));
            Assert.False(valid.IsValid(s2));
            Assert.True(valid.IsValid(s3));
            Assert.False(valid.IsValid(s4));
        }
    }
}
