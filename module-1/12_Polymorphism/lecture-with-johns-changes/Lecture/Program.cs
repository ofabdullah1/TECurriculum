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

            //FarmAnimal[] animals = new FarmAnimal[] { new Cow(), new Chicken() };

            //FarmAnimal[] animals = new FarmAnimal[2];
            //animals[0] = new Cow();
            //animals[1] = new Chicken();

            List<IMakeSound> animals = new List<IMakeSound>();
            animals.Add(new Cow());
            animals.Add(new Chicken());
            animals.Add(new Sheep());
            animals.Add(new Tractor());

            Cow myCow = (Cow)animals[0];

            foreach (IMakeSound animal in animals)
            {
                Console.WriteLine();
                Console.WriteLine("Old MacDonald had a farm, ee ay ee ay oh!");
                Console.WriteLine("And on his farm he had a " + animal.Name + ", ee ay ee ay oh!");
                Console.WriteLine("With a " + animal.Sound + " " + animal.Sound + " here");
                Console.WriteLine("And a " + animal.Sound + " " + animal.Sound + " there");
                Console.WriteLine("Here a " + animal.Sound + " there a " + animal.Sound + " everywhere a " + animal.Sound + " " + animal.Sound);
                
               
            }
            Console.WriteLine();
            Console.WriteLine("Olyd MacDonald had a farm, ee ay ee ay oh!");
            Console.WriteLine();
           Console.WriteLine("Cow gives milk: " + myCow.GivesMilk);

           // Tractor tractor = new Tractor();

            //Console.WriteLine();
            //Console.WriteLine("Old MacDonald had a farm, ee ay ee ay oh!");
            //Console.WriteLine("And on his farm he had a " + tractor.Name + ", ee ay ee ay oh!");
            //Console.WriteLine("With a " + tractor.Sound + " " + tractor.Sound + " here");
            //Console.WriteLine("And a " + tractor.Sound + " " + tractor.Sound + " there");
            //Console.WriteLine("Here a " + tractor.Sound + " there a " + tractor.Sound + " everywhere a " + tractor.Sound + " " + tractor.Sound);

        }
    }
}
