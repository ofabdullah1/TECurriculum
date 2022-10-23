using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {


        /*
         Given an int array, return true if the array contains 2 twice, 
         or 3 twice. The array will be length 0, 1, or 2.
         double23([2, 2]) → true
         double23([3, 3]) → true
         double23([2, 3]) → false
         */
        public bool Double23(int[] nums)
        {
            bool result = false;

            for (int i = 0; i < nums.Length; i++)
            {
                if(nums.Length == 2)
                {
                    if (nums[0] == 2 && nums[1] == 2 || nums[0] == 3 && nums[1] == 3)
                    {
                        result = true;
                    }
                }

            }
                return result;
        }
    }
}
// Stuck? - Here is a solution - https://vimeo.com/501471206/b8efbb029f
