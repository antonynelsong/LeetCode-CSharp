using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    public class Test_Three_Consecutive_Integers_That_Sum_to_a_Given_Number
    {
        [Test]
        public void T01_Test_Three_Consecutive_Integers_That_Sum_to_a_Given_Number()
        {
            long[] expectedResult = new long[] { 10, 11, 12 };

            Three_Consecutive_Integers_That_Sum_to_a_Given_Number sequence = new Three_Consecutive_Integers_That_Sum_to_a_Given_Number();

            long input = 33;

            long[] actualResult = sequence.SumOfThree(input);

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void T02_Test_Three_Consecutive_Integers_That_Sum_to_a_Given_Number()
        {
            long[] expectedResult = new long[0];

            Three_Consecutive_Integers_That_Sum_to_a_Given_Number sequence = new Three_Consecutive_Integers_That_Sum_to_a_Given_Number();

            long input = 4;

            long[] actualResult = sequence.SumOfThree(input);

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}
