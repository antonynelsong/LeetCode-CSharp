namespace LeetCode
{
    public class Three_in_a_Row
    {
        public bool AreThreeConsecutiveOddValuesWithinArray(int[] nums)
        {
            int noOfTimes = 0;
            int position = 0, nextDigit = 0;
            int maxValue = 3;

            while (nums.Length >= maxValue && position <= nums.Length - maxValue)
            {
                int value = nums[nextDigit];

                if (value % 2 == 1) //Odd
                {
                    noOfTimes++;

                    if (noOfTimes == maxValue)
                    {
                        return true;
                    }

                    nextDigit++;
                }
                else
                {
                    position++;
                    noOfTimes = 0;
                    nextDigit = position;
                }
            }
            return false; //Even
        }
    }
}