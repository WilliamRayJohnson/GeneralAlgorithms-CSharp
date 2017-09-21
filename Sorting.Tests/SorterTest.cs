using System;
using Xunit;
using Algorithms.Sorting;

namespace Algorithms.UnitTests.Sorting
{
    public class SorterTest
    {
        private Sorter sorter;

        public SorterTest()
        {
            sorter = new Sorter();
        }

        [Fact]
        public void testBubbleSort()
        {
            int[] data = {4,55,33,10,3,1,0};
            int[] expectedSortedArray = {0,1,3,4,10,33,55};
            int[] actaulSortedArray = sorter.bubbleSort(data);

            Assert.Equal(expectedSortedArray, actaulSortedArray);
        }
    }
}
