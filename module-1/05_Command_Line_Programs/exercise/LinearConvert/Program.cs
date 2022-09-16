using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the length: ");

            string length = Console.ReadLine();


            // double tempFarenheit = double.Parse(temperature);

            Console.Write("Is the Temperature in (m)eters or (f)eet");

            string lengthType = Console.ReadLine();


            //double tempConvertC = double.Parse(tempType);
            //double tempConverF = double.Parse(tempType);
            double tempChoice = double.Parse(length);
            if (lengthType == "m")

            {
                tempChoice = tempChoice * 3.2808399;
                Console.WriteLine(length + "m" + " " + "is " + tempChoice + " feet.");
            }
            else if (lengthType == "f")
            {
                tempChoice = tempChoice * 0.3048;
                Console.WriteLine(length + "f" + " " + "is " + tempChoice + " meters.");
            }
        }
    }
}
