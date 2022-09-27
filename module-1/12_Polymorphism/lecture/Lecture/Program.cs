using Lecture.Farming;
using System;
using System.Collections.Generic;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // OLD MACDONALD
            //
           // FarmAnimal[] animals = new FarmAnimal[] { new Cow(), new Chicken() };

            List<FarmAnimal> animals = new List<FarmAnimal>();
            animals.Add(new Cow());
            animals.Add(new Chicken());
            animals.Add(new Sheep());


            Cow myCow = (Cow)animals[0];

            foreach (FarmAnimal animal in animals)
            {
                Console.WriteLine();
                Console.WriteLine("Old MacDonald had a farm, ee ay ee ay oh!");
                Console.WriteLine("And on his farm he had a " + animal.Name + ", ee ay ee ay oh!");
                Console.WriteLine("With a " + animal.Sound + " " + animal.Sound + " here");
                Console.WriteLine("And a " + animal.Sound + " " + animal.Sound + " there");
                Console.WriteLine("Here a " + animal.Sound + " there a " + animal.Sound + " everywhere a " + animal.Sound + " " + animal.Sound);
             

            }
            Console.WriteLine();
            Console.WriteLine("Old MacDonald had a farm, ee ay ee ay oh!");
            Console.WriteLine();
            Console.WriteLine("Cow gives milk: " + myCow.GivesMilk);

        }
    }
}
