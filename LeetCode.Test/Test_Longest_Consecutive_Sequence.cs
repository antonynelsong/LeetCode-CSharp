using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    public class Test_Longest_Consecutive_Sequence
    {
        [Test]
        public void T01_Test_Longest_Consecutive_Sequence()
        {
            int[] nums = new int[] { 100, 4, 200, 1, 3, 2 };

            Longest_Consecutive_Sequence sequence = new Longest_Consecutive_Sequence();

            int actualResult = sequence.LongestConsecutive(nums);

            Assert.That(actualResult, Is.EqualTo(4));
        }

        [Test]
        public void T02_Test_Longest_Consecutive_Sequence()
        {
            int[] nums = new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };

            Longest_Consecutive_Sequence sequence = new Longest_Consecutive_Sequence();

            int actualResult = sequence.LongestConsecutive(nums);

            Assert.That(actualResult, Is.EqualTo(9));
        }

        [Test]
        public void T03_Test_Longest_Consecutive_Sequence()
        {
            int[] nums = new int[] { };

            Longest_Consecutive_Sequence sequence = new Longest_Consecutive_Sequence();

            int actualResult = sequence.LongestConsecutive(nums);

            Assert.That(actualResult, Is.EqualTo(0));
        }

        [Test]
        public void T04_Test_Longest_Consecutive_Sequence()
        {
            int[] nums = new int[] { 9, 1, 4, 7, 3, -1, 0, 5, 8, -1, 6 };

            Longest_Consecutive_Sequence sequence = new Longest_Consecutive_Sequence();

            int actualResult = sequence.LongestConsecutive(nums);

            Assert.That(actualResult, Is.EqualTo(7));
        }

        [Test]
        public void T05_Test_Longest_Consecutive_Sequence()
        {
            int[] nums = new int[] { 1, 2, 0, 1 };

            Longest_Consecutive_Sequence sequence = new Longest_Consecutive_Sequence();

            int actualResult = sequence.LongestConsecutive(nums);

            Assert.That(actualResult, Is.EqualTo(3));
        }
    }
}
