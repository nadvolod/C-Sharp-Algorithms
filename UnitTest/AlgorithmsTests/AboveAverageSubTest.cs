using System.Collections.Generic;
using Xunit;

namespace UnitTest.AlgorithmsTests
{
    public static class AboveAverageSubTest
    {
        [Fact]
        public static void IntBinarySearchTest()
        {
            int[] arr_1 = {3, 4, 2};
            var result = AboveAverageSub.aboveAverageSubarrays(arr_1);
        }
    }
}