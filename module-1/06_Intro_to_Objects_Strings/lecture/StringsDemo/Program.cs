using System;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            int param = 6;
            Console.WriteLine("Before;" + param) ;

            Calc(param);

            Console.WriteLine("After:" + param);

            int[] values = { 3, 1, 4};
            Console.WriteLine("Array before: " + values[0]);
            Calc(values);


            Console.WriteLine("Array after: " + values[0]);

            Console.WriteLine();
            
            string name = "Ada Lovelace";

            // Strings are actually arrays of characters (char).
            // Those characters can be accessed using [] notation.

            // 1. Write code that prints out the first and last characters
            //      of name.
            // Output: A
            // Output: e

             Console.WriteLine("First and Last Character. ");
            Console.WriteLine(name[0]);
            Console.WriteLine(name[name.Length-1]);
            Console.WriteLine();
            

            // 2. How do we write code that prints out the first three characters
            // Output: Ada
            string result = name.Substring(0, 3);

            Console.WriteLine("First 3 characters: " + result);

            Console.WriteLine();

            // 3. Now print out the first three and the last three characters
            // Output: Adaace

            Console.WriteLine("First 3 and Last 3 characters: ");
            
            string lastThree = name.Substring(name.Length - 3);
           
            Console.WriteLine(result + lastThree);

            Console.WriteLine();

            // 4. What about the last word?
            // Output: Lovelace

            Console.WriteLine("Last Word: ");

            string[] word = name.Split(" ");
            Console.WriteLine(word[word.Length-1]);

            Console.WriteLine();

            // 5. Does the string contain inside of it "Love"?
            // Output: true

            Console.WriteLine("Contains \"Love\"");
            Console.WriteLine(name.Contains("Love"));            //boolean method
            Console.WriteLine();

            // 6. Where does the string "lace" show up in name?
            // Output: 8

            
            Console.WriteLine("Index of \"lace\": ");
            Console.WriteLine(name.IndexOf("lace"));
            Console.WriteLine();
            
            // 7. How many 'a's OR 'A's are in name?
            // Output: 3

            Console.WriteLine("Number of \"a's\": ");

            string[] countTheAs = name.Split(new char[] { 'a', 'A' });
            Console.WriteLine(countTheAs.Length - 1);
            Console.WriteLine();


            // 8. Replace "Ada" with "Ada, Countess of Lovelace"

            result = name.Replace("Ada", "Ada, Countess of Lovelace");
            Console.WriteLine(result);
            Console.WriteLine();

            // Console.WriteLine(name);

            // 9. Set name equal to null.

            name = null;
            Console.WriteLine("");

            // 10. If name is equal to null or "", print out "All Done".

            Console.WriteLine(String.IsNullOrEmpty(name));

            Console.ReadLine();
        }
    
        static void Calc (int input)
        {
            input = input + 100;

           
        }

        static void Calc(int[] numbers)
        {
            numbers[0] += 100;
            
        }
    }
}
