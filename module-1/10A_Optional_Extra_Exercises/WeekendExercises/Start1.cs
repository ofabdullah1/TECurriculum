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
         Start with 2 int arrays, a and b, of any length. Return how 
         many of the arrays have 1 as their first element.
         start1([1, 2, 3], [1, 3]) → 2
         start1([7, 2, 3], [1]) → 1
         start1([1, 2], []) → 1
         */
        public int Start1(int[] a, int[] b)
        {
            int firstOne = 0;

            if(a.Length > 0 && a[0] == 1)
            {
                firstOne += 1;
            }
            if(b.Length >0 && b[0] == 1)
            {
                firstOne += 1;
            }

            return firstOne;
        }
    }
}

// Stuck? - Here is a solution - https://vimeo.com/501986871/bef45ae1ce
