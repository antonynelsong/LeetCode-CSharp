using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LargestRiseSet
    {
        public int maxSizeSet(List<int> riceBags)
        {
            int maxSize = 0;

            if (riceBags.Count <2)
            {
                return -1;
            }

            for (int i = 0; i < riceBags.Count; i++)
            {
                int localCount = 1;
                int riceGrainCount = riceBags[i];

                while (riceBags.Contains(riceGrainCount * riceGrainCount))
                {
                    localCount++;
                    riceGrainCount *= riceGrainCount;
                }
              
                if (maxSize < localCount)
                {
                    maxSize = localCount;
                }
            }

            return maxSize;
        }
    }
}
