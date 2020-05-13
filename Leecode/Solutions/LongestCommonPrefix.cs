using System.Collections.Generic;

namespace Leecode.Solutions
{
    public static class LongestCommonPrefix
    {
        public static string LongestCommonPrefixFun(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";

            //! 找出最短字符串
            var shortestStr = new char[] { };
            var shortestLenth = 0;
            var commonChar = new List<char>();

            foreach (var str in strs)
            {
                var arr = str.ToCharArray();
                var len = str.Length;

                if (str == "")
                {
                    shortestStr = arr;
                    shortestLenth = len;
                    break;
                }

                if (shortestLenth == 0)
                {
                    shortestStr = arr;
                    shortestLenth = len;
                }
                else
                {
                    if (shortestLenth > len)
                    {
                        shortestStr = arr;
                        shortestLenth = len;
                    }
                }
            }

            if (shortestLenth == 0)
                return "";

            var br = true;
            for (var i = 0; i < shortestLenth; ++i)
            {
                var testChar = shortestStr[i];
                var bl = true;

                while (bl)
                {
                    foreach (var str in strs)
                    {
                        if (str[i] != testChar)
                        {
                            bl = false;
                            br = false;
                            break;
                        }
                    }
                    if (bl)
                        commonChar.Add(testChar);

                    bl = false;
                }
                if (!br)
                    break;

            }
            return new string(commonChar.ToArray());
        }
    }
}
