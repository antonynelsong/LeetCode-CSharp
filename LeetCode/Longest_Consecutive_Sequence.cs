using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Longest_Consecutive_Sequence
    {
        public int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
           
            nums = nums.Distinct().ToArray();
            Array.Sort(nums);

            int maxSize = 1;
            int localcount = 1;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i + 1] == nums[i] + 1)
                {
                    localcount++;
                }
                else
                {
                    localcount = 1;
                }

                if (maxSize < localcount)
                {
                    maxSize = localcount;
                }
            }
            return maxSize;
        }
    }
}
