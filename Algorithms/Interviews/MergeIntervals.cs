using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Interviews;

/**
 * Prompt
 * Given an array of intervals where intervals[i] = [starti, endi], merge all overlapping intervals,
 * and return an array of the non-overlapping intervals that cover all the intervals in the input.
 *
 *Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
    Output: [[1,6],[8,10],[15,18]]
    Explanation: Since intervals [1,3] and [2,6] overlaps, merge them into [1,6].
    
    Input: intervals = [[1,4],[4,5]]
Output: [[1,5]]
Explanation: Intervals [1,4] and [4,5] are considered overlapping.
 * 
 */
public class MergeIntervals
{
    /*
     * Ex1. (4,12) (10,15). Is the start of the 2nd interval (10) <= the end of the 1st (12). Hence,
     * The interval is (4,15)
     * Ex2. (5,10) (5,11) is 5 <= 10 => (5,11). We picked 11 because it was greater than the first end
     *
     * Ex3. (1,6) (10,20) is 10 <= 6, no => (1,6) (10,20). The answer is what we started w/
     *
     * If you have a brute force solution, one technique you can try is to sort your input
     * (2,5) (1,4) (6,9)
     * Sort it to be (1,4)(2,5)(6,9)
     * Then follow the logic above
     *
     * // Assign 77 to the second element ([1]) of the first array ([0]):
            jaggedArray3[0][1] = 77;
     * 
     */
    
    public static int[,] Merge(int[][] intervals)
    {
        intervals = intervals.OrderBy( x => x[0]).ToArray();
        var merged = new List<int[]>();
        // an interval is a single row in the array
        // we can access different elements like interval[0], interval[1]...
        foreach (var interval in intervals)
        {
            // if the first element of the interval is greater than 
            if (merged.Count == 0 || merged[0].Last() < interval[0])
            {
                //add a single int[] with 2 elements
                merged.Add(interval);
            }
            // otherwise, there is overlap, so we merge the current and previous
            // intervals.
            else
            {
                //merged.Last(Math.Max(merged.))
            }
        }

        return new int[1,0];
    }
}