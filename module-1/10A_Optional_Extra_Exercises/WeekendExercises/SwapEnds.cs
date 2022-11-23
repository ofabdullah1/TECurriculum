﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given an array of ints, swap the first and last elements in the array. 
         Return the modified array. The array 
         length will be at least 1.
         swapEnds([1, 2, 3, 4]) → [4, 2, 3, 1]
         swapEnds([1, 2, 3]) → [3, 2, 1]
         swapEnds([8, 6, 7, 9, 5]) → [5, 6, 7, 9, 8]
         */
        public int[] SwapEnds(int[] nums)
        {
            int[] result = new int[nums.Length];
            int temp = 0;
            
            result[0] = nums[nums.Length - 1];
            nums[0] = temp;
            result[result.Length - 1] = temp;
            return result;
        }


    }
}

// Stuck? - Here is a solution - https://vimeo.com/501988253/0512f0be98
