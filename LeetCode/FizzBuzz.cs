using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class FizzBuzz
    {
        public void fizzBuzz(int n)
        {
            for (int number = 1; number <= n; number++)
            {
                if (number%3==0 && number %5==0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                if (number % 3 == 0 && number % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
                if (number % 3 != 0 && number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                if (number % 3 != 0 && number % 5 != 0)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
