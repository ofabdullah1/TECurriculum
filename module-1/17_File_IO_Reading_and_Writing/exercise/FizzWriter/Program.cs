using System;
using System.IO;

namespace FizzWriter
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("What is the destination file?");
            string outputFile = Console.ReadLine();




            string directory = @"c:\niceplace";
            string outputFullPath = Path.Combine(directory, outputFile);

            try
            {

                using (StreamWriter sw = new StreamWriter(outputFullPath, false))



                    for (int i = 1; i < 301; i++)

                    {
                        if (i % 3 == 0 && i % 5 == 0)
                        {
                            sw.WriteLine("FizzBuzz");
                        }
                        else if (i % 3 == 0)
                        {
                            sw.WriteLine("Fizz");
                        }
                        else if (i % 5 == 0)
                        {
                            sw.WriteLine("Buzz");
                        }
                        else
                        {
                            sw.WriteLine(i);
                        }



                    }


            }
            catch (IOException ex)
            {
                Console.WriteLine("You have entered an invalid destination file, the program will now stop");
            }





        }
    }
}
