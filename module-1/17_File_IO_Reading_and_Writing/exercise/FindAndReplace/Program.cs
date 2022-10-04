using System;
using System.IO;

namespace FindAndReplace
{
    public class Program
    {
		public static void Main(string[] args)
		{
            Console.WriteLine("What is the search word?");
            string userINput = Console.ReadLine();
            Console.WriteLine("What is the replacement word?");
            string replacementWord = Console.ReadLine();
            Console.WriteLine("What is the source file?");
            string inputFile = Console.ReadLine();
            Console.WriteLine("What is the destination file?");
            string outputFile = Console.ReadLine();







            // Figure the full path of the input file and output file
            string directory = @"c:\niceplace";
            //string inputFile = "programminglanguages.txt";
            //string outputFile = "programminglanguages-FIXED2.txt";
            string inputFullPath = Path.Combine(directory, inputFile);
            string outputFullPath = Path.Combine(directory, outputFile);
            

            // Open the existing file with the typo using a StreamReader
            using (StreamReader sr = new StreamReader(inputFullPath))
            {
                // Open a StreamWriter where we will output the file
                using (StreamWriter sw = new StreamWriter(outputFullPath, true))
                {
                    // For each line in the input file, read it in
                    while (!sr.EndOfStream)
                    {
                        // Read an individual line
                        string line = sr.ReadLine();

                        // Replace the occurence of the word langauge with language
                        string fixedLine = line.Replace(userINput, replacementWord);

                        // Write the new line to the output file
                        sw.WriteLine(fixedLine);
                    }
                }
            }






        }
    }
}
