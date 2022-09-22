using System;
using System.Collections.Generic;

namespace CollectionsPart2Tutorial
{
    public class CollectionsPart2Tutorial
    {
        static void Main(string[] args)
        {

            // Step One: Declare a Dictionary

            Dictionary<string, string> projects = new Dictionary<string, string>();


            // Step Two: Add items to a Dictionary

            projects["Ada"] = "Inventing new programs";
            projects["Omar"] = "Inventing new ideas";
            projects["Cars"] = "Inventing new ways to make cars";


            // Step Three: Loop through a Dictionary

            foreach (KeyValuePair<string, string> project in projects)


        }
    }
}
