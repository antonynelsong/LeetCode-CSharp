using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    public class Test_Valid_Words
    {
        [Test]
        public void T01_Valid_Words_Test()
        {
            //Arrange
            string permitted = "abc";
            string[] words = new string[] { "d", "ab", "abce" };

            Valid_Words valid_Words = new Valid_Words();

            //Act
            int actualResult = valid_Words.CountValidWords(permitted, words);

            //Assert
            Assert.That(actualResult, Is.EqualTo(1));
        }

        [Test]
        public void T02_Valid_Words_Test()
        {
            //Arrange
            string permitted = "ake";
            string[] words = new string[] { "ail", "kea", "a" };

            Valid_Words valid_Words = new Valid_Words();

            //Act
            int actualResult = valid_Words.CountValidWords(permitted, words);

            //Assert
            Assert.That(actualResult, Is.EqualTo(2));
        }
    }
}
