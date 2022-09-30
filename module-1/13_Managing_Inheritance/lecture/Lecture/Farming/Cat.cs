using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    sealed class Cat:FarmAnimal
    {
        public Cat() : base("Cat", "Meow")
        {

        }

        public Cat(string name) : base(name, "Meow")
        {

        }

        public override string EatFood()
        {
            return "Munch, munch, munch...";
        }

        public override string ToString()
        {
            return "The perfect cat named " + Name;
        }



    }









}
