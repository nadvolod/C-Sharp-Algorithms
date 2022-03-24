using System;
using System.Collections.Generic;

public class TwoSumsFacebook {
  public void Test(string[] args) {
    int k_1 = 6;
    int[] arr_1 = {1, 2, 3, 4, 3};
    int expected_1 = 2;
    int output_1 = numberOfWays2(arr_1, k_1);
    Console.WriteLine(output_1 == expected_1);
    
    int k_2 = 6;
    int[] arr_2 = {1, 5, 3, 3, 3};
    int expected_2 = 4;
    int output_2 = numberOfWays2(arr_2, k_2);
    Console.WriteLine(output_2 == expected_2);
  }
  
  private static int numberOfWays(int[] arr, int k) {
    // O(n^2) time
    var sums = new Dictionary<string,int>();
    for(int i=0; i < arr.Length -1;i++){
      for(int j=1; j<arr.Length-1; j++){
        Console.WriteLine("i:" + i + "j:" + j);
        if(arr[i] + arr[j] == k){
          //had to create 2 keys so that we can store the inverse of each key
          var key = $"{i}{j}";          
          var key2 = $"{j}{i}";
          Console.WriteLine("key:" + key);
          //a check to ensure that we don't try to add a duplicate key
          if(!sums.ContainsKey(key) && !sums.ContainsKey(key2))
            //important to do ToString() to turn the int into a string
            //k is an int in this case
            sums.Add(key.ToString(), k);
        }
      }
    }
    Console.WriteLine("sums:" + sums.Count);
    return sums.Count;
  }

    private static int numberOfWays2(int[] arr, int k) {
    // O(n) time
    Dictionary<int, int> sums = new Dictionary<int, int>();
    int count = 0;
    for (int i = 0; i < arr.Length; i++) {
      // 6-1, F, count=0. 6-2,f. 6-3, f. 
      // 6-4,T, count=1. 6-3,T, count=2
        if (sums.ContainsKey(k - arr[i])) {
          // 
            count += sums[k - arr[i]];
        }
      // if the dictionary contains the current value
      // create a key with current arr value
      // set key = the value + 1
      // contains 1, false. contains 2, false. contains 3, f. contains 4, f.
        if (sums.ContainsKey(arr[i])) {
          //Console.WriteLine("m[arr[i]]:"+m[arr[i]]);
          //Console.WriteLine("m[arr[i]] + 1:"+ m[arr[i]] + 1);
            sums[arr[i]] = sums[arr[i]] + 1;
        } else {
          // add the key and count 1 for that key
          // {1: 1, 2:1, 3:1, 4:1, }
            sums.Add(arr[i], 1);
        }
      int val;
      Console.WriteLine("i:" + i + " key:"+sums.TryGetValue(i, out val) + " v:" + val);
    }
    return count;
  }
  
  /*
  Edge cases
  Make sure to test with values around the maximum possible input value (one billion)
  Will your solution work when all pairs sum to k? Imagine an array with 100,000 copies of k/2. What should the     answer be?
  */
}

