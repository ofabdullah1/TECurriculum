using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    class RectangleWall : Wall
    {

        public string Name { get; set; }
        public string Color { get; set; }
        public int Length { get; set; }
        public int Height { get; set; }
        


        public RectangleWall(string name, string color, int length, int height) : base(name, color)
        {
            Name = name;
            Color = color;
            Length = length;
            Height = height;
            

        }



        public override int GetArea()
        {
            return Length * Height;
        }

        public override string ToString()
        {
            return Name + " " + "(" + Length + "x" + Height + ")" + " rectangle";
        }



    }
}
