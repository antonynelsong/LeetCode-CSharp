using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Three_Consecutive_Integers_That_Sum_to_a_Given_Number
    {
        public long[] SumOfThree(long num)
        {
             if (num % 3 != 0) return new long[0];

            return new long[3] { num / 3 - 1, num / 3, num / 3 + 1 };
        }
    }
}

