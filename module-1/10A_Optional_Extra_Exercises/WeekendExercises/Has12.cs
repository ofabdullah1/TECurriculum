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
         Given an array of ints, return true if there is a 1 in the array 
         with a 2 somewhere later in the array.
         has12([1, 3, 2]) → true
         has12([3, 1, 2]) → true
         has12([3, 1, 4, 5, 2]) → true
         */
        public bool Has12(int[] nums)
        {
            bool result = false;
            bool foundAOne = false;
            
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                   foundAOne = true;
                }
                else if(nums[i] == 2 && foundAOne == true)
                {
                    result = true;
                }

            }
            return result;
        }
    }
}

//Stuck? Here is a solution - https://vimeo.com/501568556/374eb4795d
