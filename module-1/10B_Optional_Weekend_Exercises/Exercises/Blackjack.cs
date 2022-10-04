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
         Given 2 int values greater than 0, return whichever value is nearest to 21 without going over. Return 0 if they both 
         go over.
         blackjack(19, 21) → 21
         blackjack(21, 19) → 21
         blackjack(19, 22) → 19
         */
        public int Blackjack(int a, int b)
        {
            
            if(a > 21 && b > 21)
            {
                return 0;
            }
            else if(a>21)
            {
                return b;
            }
            else if(b>21)
            {
                return a;
            }
            else if(a <= b)
            {
                return b;   
            }
            else
            {
                return a;
            }
            
            return 0;
        }
    }
}

// Stuck? Here is a solution - https://vimeo.com/501449147/96a04bf700
