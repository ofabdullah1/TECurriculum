using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Car myCar = new Car();
            // myCar.vinNumber = "hdy8hfyrhukidau73";
            //myCar.year = 2023;

            myCar.VinNumber = "12345678901234567";
            myCar.Manf = "Honda";

            Console.WriteLine(myCar.ToString());

            //Console.WriteLine(myCar.vinNumber);

            Console.WriteLine(myCar.VinNumber);

            Car newCar = new Car();

            Console.WriteLine(newCar);
            Car anotherCar = new Car("12345", 2020, "Honda", "CR-V");
            Console.WriteLine(anotherCar);


            //////////////////////////////////////////////
            /////////////////////////////////////////////
            ///

            Deck myDeck = new Deck();

            string result = myDeck.DisplayDeck();
            Console.WriteLine("Here is the deck:");
            Console.WriteLine(result);

            Console.WriteLine();

        }
    }
}
