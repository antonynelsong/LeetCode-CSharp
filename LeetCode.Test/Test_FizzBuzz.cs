using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    public class Test_FizzBuzz
    {
        [Test]
        public void T01_Test_FizzBuzz()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            fizzBuzz.fizzBuzz(15);
        }
    }
}
