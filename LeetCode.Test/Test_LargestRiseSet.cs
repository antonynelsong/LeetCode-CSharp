using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    public class Test_LargestRiseSet
    {
        [Test]
        public void T01_Test_maxSizeSet()
        {
            List<int> riceBags = new() { 3, 9, 4, 2, 16 };

            LargestRiseSet largestRiseSet = new LargestRiseSet();

            int actualResult = largestRiseSet.maxSizeSet(riceBags);

            Assert.That(actualResult, Is.EqualTo(3));
        }
    }
}
