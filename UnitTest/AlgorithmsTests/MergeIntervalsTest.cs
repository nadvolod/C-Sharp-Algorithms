using System.Collections.Generic;
using Algorithms.Interviews;
using Xunit;

namespace UnitTest.AlgorithmsTests
{
    public static class MergeIntervalsTest
    {
        [Fact]
        public static void IntBinarySearchTest()
        {
            //intervals = [[1,4],[4,5]]
            //jagged array
            var intervals = new[] { 
                new[] { 1, 4 }, 
                new[] { 4, 5 } 
            };

            var result = MergeIntervals.Merge(intervals);
        }
    }
}