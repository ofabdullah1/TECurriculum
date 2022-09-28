using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    class SquareWall: RectangleWall
    {

        

        public SquareWall(string name, string color, int sideLength) : base(name, color, sideLength, sideLength)
        {
            
        }

        public override string ToString()
        {
            return Name + " " + "(" + Length + "x" + Height + ")" + " " + "square";
        }




    }
}
