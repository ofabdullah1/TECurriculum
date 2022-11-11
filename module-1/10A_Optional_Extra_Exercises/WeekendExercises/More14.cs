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
         Given an array of ints, return true if the number of 1's is 
         greater than the number of 4's
         more14([1, 4, 1]) → true
         more14([1, 4, 1, 4]) → false
         more14([1, 1]) → true
         */
        public bool More14(int[] nums)
        {

            bool result = false;
            int foundFour = 0;
            int foundOne = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == 1)
                {
                    foundOne += 1;
                }
                if (nums[i] == 4)
                {
                    foundFour += 1;
                }
            }
            if(foundOne > foundFour)
            {
                result = true;
            }
            return result;
        }
    }
}

// Stuck? - Here is a solution - https://vimeo.com/501882394/a44883058e
