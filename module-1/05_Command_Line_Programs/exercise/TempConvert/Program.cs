using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a temperature: ");
            
            string temperature = Console.ReadLine();
            
          
           // double tempFarenheit = double.Parse(temperature);

            Console.Write("Is the Temperature in (C)elsius or (F)arenheit");

            string tempType = Console.ReadLine();


            //double tempConvertC = double.Parse(tempType);
            //double tempConverF = double.Parse(tempType);
            double tempCelsius = double.Parse(temperature);
            if (tempType == "C")

            {
                tempCelsius = tempCelsius * 1.8 + 32;
                Console.WriteLine(temperature + "C" + " " + "is " + tempCelsius + " F.");
            }
            else if (tempType == "F")
            {
                tempCelsius = (tempCelsius - 32) / 1.8;
                Console.WriteLine(temperature + "F" + " " + "is " + tempCelsius + " C.");
            }

        
        }
    }
}
