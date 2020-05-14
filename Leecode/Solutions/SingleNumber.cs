using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leecode.Solutions
{
    public static partial class Solution
    {
        /*
         * 给定一个非空整数数组，除了某个元素只出现一次以外，其余每个元素均出现两次。找出那个只出现了一次的元素。
         * 说明：
         * 你的算法应该具有线性时间复杂度。 你可以不使用额外空间来实现吗？
         * 
         * 示例 1:
         * 
         * 输入: [2,2,1]
         * 输出: 1
         * 示例 2:
         * 
         * 输入: [4,1,2,1,2]
         * 输出: 4
         * 
         * 来源：力扣（LeetCode）
         * 链接：https://leetcode-cn.com/problems/single-number
         * 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
        public static int SingleNumber(int[] nums)
        {
            
            var single = 0;
            foreach(var num in nums)
            {
                var count = nums.Where(x => x == num).Count();
                if(count == 1)
                {
                    single = num;
                    break;
                }

            }
            return single;
        }

        //! 使用异或方式，连续2次相同异或思路解题
        public static int SingleNumber1(int[] nums)
        {
            var ret = nums[0];
            for(var i = 1; i < nums.Length; i++)
            {
                ret ^= nums[i];
            }

            return ret;
        }
    }
}
