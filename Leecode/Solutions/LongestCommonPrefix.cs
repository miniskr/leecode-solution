namespace Leecode.Solutions
{
    public static class LongestCommonPrefix
    {
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
