using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Leecode.Solutions
{
    public class ValidParentheses
    {
        private readonly Dictionary<char, char> dic;

        public ValidParentheses()
        {
            this.dic = new Dictionary<char, char>()
            {
                {')', '(' },
                {']', '[' },
                {'}', '{' }
            };
        }

        public bool IsValid(string s)
        {
            var charStr = s.ToCharArray();
            var stack = new Stack<char>();

            for (var i = 0; i < charStr.Length; i++)
            {
                var strKey = charStr[i];

                if (this.dic.ContainsKey(strKey))
                {
                    var topElement = stack.Count == 0 ? '#' : stack.Pop();
                    if (topElement != this.dic.GetValueOrDefault(strKey))
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(strKey);
                }
            }

            return stack.Count == 0;
        }
    }
}
