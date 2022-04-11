using System;
using System.Collections.Generic;

public class AboveAverageSub{

//   You are given an array A containing N integers. Your task is to find all subarrays whose average sum is greater than the average sum of the remaining array elements. You must return the start and end index of each subarray in sorted order.
// A subarray that starts at position L1 and ends at position R1 comes before a subarray that starts at L2 and ends at R2 if L1 < L2, or if L1 = L2 and R1 ≤ R2.
// Note that we'll define the average sum of an empty array to be 0, and we'll define the indicies of the array (for the purpose of output) to be 1 through N. A subarray that contains a single element will have L1 = R1.
// Signature
// Subarray[] aboveAverageSubarrays(int[] A)
// Input
// 1 ≤ N ≤ 2,000
// 1 ≤ A[i] ≤ 1,000,000
// Output
// A Subarray is an object with two integer fields, left and right, defining the range that a given subarray covers. Return a list of all above-average subarrays sorted as explained above.
// Example 1
// A = [3, 4, 2]
// output = [[1, 2], [1, 3], [2, 2]]
// The above-average subarrays are [3, 4], [3, 4, 2], and [4].
  public class Subarray {
    int left;
    int right;
    public Subarray(int left, int right) {
        this.left = left;
        this.right = right;
    }
    
    public override string ToString(){
      // int[] arr = new int[] {left, right};
      return $"{left}, {right}";
    }
  }

  public static Subarray[] aboveAverageSubarrays(int[] arr) {
    List<Subarray> resultList = new List<Subarray>();

    int totalSum = 0;
    
    foreach(int k in arr){
      totalSum += k;
    }

    for (int leftPointer = 0; leftPointer < arr.Length; leftPointer++) {

      int sumCurrent = 0;
      for (int rightPointer = leftPointer; rightPointer < arr.Length; rightPointer++) {
        //iterate through every single element and keep appending the new value to the sumCurrent
        sumCurrent += arr[rightPointer];
        //demoninator = arr.Length - (count of all integers involved in the sum, +1 because we need to count each index)
        var denominator = arr.Length - (rightPointer - leftPointer + 1); 
        if(denominator == 0) continue;
        if (sumCurrent / (rightPointer - leftPointer + 1) > (totalSum - sumCurrent) / denominator) {
          //1,1
          var subArr = new Subarray(leftPointer + 1, rightPointer + 1);
          resultList.Add(subArr);
        }
      }
    }
    Console.WriteLine(resultList.ToArray().ToString());
    return resultList.ToArray();
  }
}

/**/