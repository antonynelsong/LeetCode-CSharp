namespace LeetCode.Test
{
    public class Test_Three_in_a_Row
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_AreThreeConsecutiveOddValuesWithinArray()
        {
            int[] nums = new int[] { 1, 3, 4, 2, 3, 9, 1 };

            Three_in_a_Row three_In_A_Row = new Three_in_a_Row();

            bool actualResult = three_In_A_Row.AreThreeConsecutiveOddValuesWithinArray(nums);

            Assert.IsTrue(actualResult);
        }
    }
}