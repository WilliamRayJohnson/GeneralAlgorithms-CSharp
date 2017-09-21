using System;
using Xunit;
using Algorithms.Sorting;

namespace Algorithms.UnitTests.Sorting
{
    public class SorterTest
    {
        private Sorter sorter;
        private int[] data;
        int[] expectedSortedArray;

        public SorterTest()
        {
            sorter = new Sorter();
            data = new int[]{4,55,33,10,3,1,0};
            expectedSortedArray = new int[]{0,1,3,4,10,33,55};
        }

        [Fact]
        public void testBubbleSort()
        {
            int[] actaulSortedArray = sorter.bubbleSort(data);

            Assert.Equal(expectedSortedArray, actaulSortedArray);
        }

        [Fact]
        public void testBubbleSortAlreadySorted()
        {
            int[] actaulSortedArray = sorter.bubbleSort(expectedSortedArray);

            Assert.Equal(expectedSortedArray, actaulSortedArray);
        }

        [Fact]
        public void testEnhancedBubbleSort()
        {
            int[] actaulSortedArray = sorter.enhancedBubbleSort(data);

            Assert.Equal(expectedSortedArray, actaulSortedArray);
        }
    }
}
