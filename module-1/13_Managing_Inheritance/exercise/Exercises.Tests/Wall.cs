﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public abstract class Wall
    {
        public string Name { get; set; }
        public string Color { get; set; }
        
        
        public Wall(string name, string color)
        {

        }


        public abstract int GetArea();




    }
}
