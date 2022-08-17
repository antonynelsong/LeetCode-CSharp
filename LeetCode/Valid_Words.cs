using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Valid_Words
    {
        public int CountValidWords(string permitted, string[] words)
        {
            int total = 0;
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                for (int j = 0; j < word.Length; j++)
                {
                    if (!permitted.Contains(word[j]))
                    {
                        break;
                    }
                    if (j == word.Length - 1)
                    {
                        total++;
                    }
                }
            }
            return total;
        }
    }
}
