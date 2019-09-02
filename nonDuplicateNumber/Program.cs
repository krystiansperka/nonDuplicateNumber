﻿using System;
using System.Collections;
using System.Collections.Generic;

/*Given a list of numbers, where every number shows up twice except for one number, find that one number.

Example:
Input: [4, 3, 2, 4, 1, 3, 2]
Output: 1
Here's the function signature:

def singleNumber(nums):
  # Fill this in.

print singleNumber([4, 3, 2, 4, 1, 3, 2])
# 1

Challenge: Find a way to do this using O(1) memory.
*/

namespace nonDuplicateNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var solution = new Solution();
            solution.RunTest1();
        }
    }

    public class Solution
    {
        public int RunTest1()
        {
            int[] testArray = { 4, 3, 2, 4, 1, 3, 2 };
            return singleNumber(testArray);
        }

        public int singleNumber(int[] inputArray)
        {
            
            Dictionary<int, bool> dictionaryOfPairs = new Dictionary<int, bool>();

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (!dictionaryOfPairs.ContainsKey(inputArray[i]))
                {
                    dictionaryOfPairs.Add(inputArray[i], false);
                }
                else
                {
                    dictionaryOfPairs[inputArray[i]] = true;

                }

            }

            if (dictionaryOfPairs.ContainsValue(false))
            {
                foreach (KeyValuePair<int, bool> kvp in dictionaryOfPairs)
                {
                    if (kvp.Value == false)
                        return kvp.Key;
                }

                    
            }








            return 0; 
        }
    }
}
