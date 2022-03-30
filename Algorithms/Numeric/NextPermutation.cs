using System;
using System.Linq;

public class NextPermutation {
  // working code https://replit.com/@nadvolod/Algorithms
  public static void Main (string[] args) {
    int[] arr_1 = {1, 2, 3};
    int[] expected_1 = {1,3,2};
    var output_1 = CalcNextPermutation(arr_1);
    //print out an array using String.Join()
    Console.WriteLine(String.Join(",",output_1));
    // Determines whether two sequences are equal according to an equality comparer
    Console.WriteLine(output_1.SequenceEqual(expected_1));

    int[] arr_2 = {9, 5, 4, 3, 1};
    int[] expected_2 = {1,3,4,5,9};
    var output_2 = CalcNextPermutation(arr_2);
    //print out an array using String.Join()
    Console.WriteLine(String.Join(",",output_2));
    // Determines whether two sequences are equal according to an equality comparer
    Console.WriteLine(output_2.SequenceEqual(expected_2));
  }

    public static int[] CalcNextPermutation(int[] nums) {
        // input: [9, 5, 4, 3, 1]
        //set i to 2nd to last element
        int i = nums.Length - 2;
        //need to move right to left
        // while > 0 and the number to the right is <= number to the left. 1 <= 3?
        // will take us all the way to i=0 for the input above
        while(i >= 0 && nums[i+1] <= nums[i]){
            i--;
        }
        // true after loop above
        if(i >=0){
            // j is at the end of the array
            int j = nums.Length -1;
            // while 1 <= 9
            while (nums[j] <= nums[i]){
                j--;
            }
            // j will get down to 0
            Swap(nums, i, j);
        }
        Reverse(nums, i+1);
      return nums;
    }
    
    private static void Reverse(int[] nums, int start) {
        int i = start, j = nums.Length - 1;
      Console.WriteLine("Reverse() i:" + i + "j:" + j);
        while (i < j) {
            Swap(nums, i, j);
            i++;
            j--;
        }
    }

    private static void Swap(int[] nums, int i, int j) {
      Console.WriteLine("Swap() i:" + i + "j:" + j);
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}

/*
input: [1,2,3]
output: [1,3,2], the next larger lexicographically greater permutation

input: [3,2,1]
output: [1,2,3], we start over

an arrangement, not increment
in-place
next permutation
in-place replacement and constant space should immediately indicate swapping
if the elements are increasing from the right, they are currently at their largest possible permutation
observe that for any given sequence that is in descending order, no next larger permutation is possible
[9, 5, 4, 3, 1], nothing larger is possible
*/