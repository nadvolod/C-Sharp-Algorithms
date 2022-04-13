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
    
    public static int[][] Merge(int[][] intervals)
    {
        //sort intervals based on increasing order of start
        intervals = intervals.OrderBy( x => x[0]).ToArray();
        var merged = new LinkedList<int[]>();
        // an interval is a single row in the array
        // we can access different elements like interval[0], interval[1]...
        foreach (var interval in intervals)
        {
            // if the first element of the interval is greater than 
            if (merged.Count == 0 || merged.Last()[1] < interval[0])
            {
                //add a single int[] with 2 elements
                merged.AddLast(interval);
            }
            // otherwise, there is overlap, so we merge the current and previous
            // intervals.
            else
            {
                //merge the 2 intervals
            }
        }

        return new int[1][];
    }
    /*
     * Time complexity : O(n\log{}n)O(nlogn)
     * Other than the sort invocation, we do a simple linear scan of the list,
     * so the runtime is dominated by the O(n\log{}n)O(nlogn) complexity of sorting.
        
        Space complexity : O(\log N)O(logN) (or O(n)O(n))
        If we can sort intervals in place, we do not need more than constant additional space, 
        although the sorting itself takes O(\log n)O(logn) space. 
        Otherwise, we must allocate linear space to store a copy of intervals and sort that.
     */
    
    /*
     * Solution from https://www.geeksforgeeks.org/merging-intervals/
     *1. Sort the intervals based on increasing order of 
    starting time.
2. Push the first interval on to a stack.
3. For each interval do the following
   a. If the current interval does not overlap with the stack 
       top, push it.
   b. If the current interval overlaps with stack top and ending
       time of current interval is more than that of stack top, 
       update stack top with the ending  time of current interval.
4. At the end stack contains the merged intervals.
     *
     * 
     */
    
    // class sortHelper : IComparer
    // {
    //     int IComparer.Compare(object a, object b)
    //     {
    //         Interval first = (Interval)a;
    //         Interval second = (Interval)b;
    //         if (first.start == second.start)
    //         {
    //             return first.end - second.end;
    //         }
    //         return first.start - second.start;
    //     }
    // }
    //
    // // The main function that takes a set of intervals, merges
    // // overlapping intervals and prints the result
    // public static void mergeIntervals(Interval []arr)
    // {
    //
    //     // Test if the given set has at least one interval
    //     if (arr.Length <= 0)
    //         return;
    //     Array.Sort(arr, new sortHelper());
    //
    //     // Create an empty stack of intervals
    //     Stack stack = new Stack();
    //
    //     // Push the first interval to stack
    //     stack.Push(arr[0]);
    //
    //     // Start from the next interval and merge if necessary
    //     for (int i = 1 ; i < arr.Length; i++)
    //     {
    //
    //         // get interval from stack top
    //         Interval top = (Interval)stack.Peek();
    //
    //         // if current interval is not overlapping with stack top,
    //         // Push it to the stack
    //         if (top.end < arr[i].start)
    //             stack.Push(arr[i]);
    //
    //         // Otherwise update the ending time of top if ending of current
    //         // interval is more
    //         else if (top.end < arr[i].end)
    //         {
    //             top.end = arr[i].end;
    //             stack.Pop();
    //             stack.Push(top);
    //         }
    //     }
    //
    //     // Print contents of stack
    //     Console.Write("The Merged Intervals are: ");
    //     while (stack.Count != 0)
    //     {
    //         Interval t = (Interval)stack.Pop();
    //         Console.Write("[" + t.start + "," + t.end + "] ");
    //     }
    // }
}