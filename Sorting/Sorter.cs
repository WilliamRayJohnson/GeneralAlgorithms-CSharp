using System;

namespace Algorithms.Sorting
{
    public class Sorter
    {
        public int[] bubbleSort(int[] data)
        {
            bool swapMade = true;
            int tempValue;

            while (swapMade)
            {
                swapMade = false;
                for (int i = 0; i <= (data.Length - 2); i++)
                {
                    if (data[i] > data[i+1])
                    {
                        tempValue = data[i];
                        data[i] = data[i+1];
                        data[i+1] = tempValue;
                        swapMade = true;
                    }
                }
            }

            return data;
        }

        public int[] enhancedBubbleSort(int[] data)
        {
            bool swapMade = true;
            int tempValue;
            int unsortedValueCount = data.Length;

            while (swapMade & unsortedValueCount > 1)
            {
                swapMade = false;
                for (int i = 0; i <= (unsortedValueCount - 2); i++)
                {
                    if (data[i] > data[i+1])
                    {
                        tempValue = data[i];
                        data[i] = data[i+1];
                        data[i+1] = tempValue;
                        swapMade = true;
                    }
                }
                unsortedValueCount--;
            }

            return data;
        }
    }
}
