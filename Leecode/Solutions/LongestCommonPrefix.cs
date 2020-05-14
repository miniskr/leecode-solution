﻿namespace Leecode.Solutions
{
    public static partial class Solution
    {
        /*
         * 编写一个函数来查找字符串数组中的最长公共前缀。

         * 如果不存在公共前缀，返回空字符串 ""。
         * 
         * 示例 1:
         * 
         * 输入: ["flower","flow","flight"]
         * 输出: "fl"
         * 示例 2:
         * 
         * 输入: ["dog","racecar","car"]
         * 输出: ""
         * 解释: 输入不存在公共前缀。
         * 说明:
         * 
         * 所有输入只包含小写字母 a-z 。
         * 
         * 来源：力扣（LeetCode）
         * 链接：https://leetcode-cn.com/problems/longest-common-prefix
         * 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */

        public static string LongestCommonPrefixFun(string[] strs)
        {
            if (strs == null || strs.Length == 0) return "";

            string prefix = strs[0];
            // 找空字符串
            foreach (var str in strs)
            {
                if (string.IsNullOrWhiteSpace(str))
                {
                    prefix = str;
                    break;
                }
            }

            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    // prefix = prefix.Substring(0, prefix.Length - 1);
                    prefix = prefix[0..^1];
                    if (string.IsNullOrWhiteSpace(prefix)) return "";
                }
            }
            return prefix;
        }
    }
}
