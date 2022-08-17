using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Number_of_Valid_Words_in_a_Sentence
    {
        public int CountValidWords(string sentence)
        {
            int count = 0;
            string[] words = sentence.Split(' ');
            HashSet<char> punctuationMarks = new HashSet<char>() { '!', '.', ',' };

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                if (string.IsNullOrEmpty(word))
                {
                    continue;
                }

                if (IsValid(word, punctuationMarks))
                {
                    count++;
                }
            }

            return count;

        }

        private bool IsValid(string word, HashSet<char> punctuationMarks)
        {
            bool hypen = false;
            bool punctuation = false;
            for (int j = 0; j < word.Length; j++)
            {
                char character = word[j];

                //Rule :1 
                if (char.IsDigit(character) || char.IsUpper(character))
                {
                    return false;
                }

                //Rule:2
                if (character == '-')
                {
                    if (hypen || j == 0 || j == word.Length - 1 || (!char.IsLetter(word[j - 1]) || !char.IsLetter(word[j + 1])))
                    {
                        return false;
                    }

                    hypen = true;
                }

                //Rule:3 - punctuation allowed only at last 

                if (punctuationMarks.Contains(character))
                {
                    if (punctuation || j != word.Length - 1)
                    {
                        return false;
                    }

                    punctuation = true;
                }

            }

            return true;
        }

    }
}
