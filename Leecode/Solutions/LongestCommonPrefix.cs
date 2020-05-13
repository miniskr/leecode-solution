using System.Collections.Generic;
using System;
using System.Text;

namespace Leecode.Solutions
{
    public static class LongestCommonPrefix
    {
        public static string LongestCommonPrefixFun1(string[] strs)
        {
            if (strs == null || strs.Length == 0) return "";

            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (string.IsNullOrWhiteSpace(prefix)) return "";
                }
            }
            return prefix;
        }
    }
}
