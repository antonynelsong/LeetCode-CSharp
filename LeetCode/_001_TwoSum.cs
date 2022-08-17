using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _001_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int nextNumber = target - nums[i];

                if (dictionary.ContainsKey(nums[i]))
                {
                    return new int[] { dictionary[nums[i]], i };
                }

                dictionary[nextNumber] = i;
            }
            return new int[] { };
        }
    }
}
