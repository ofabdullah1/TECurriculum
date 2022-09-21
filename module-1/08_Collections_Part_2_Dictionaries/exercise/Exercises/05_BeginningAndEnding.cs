using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given an array of non-empty strings, return a Dictionary<string, string> where for every different string in the array,
         * there is a key of its first character with the value of its last character.
         *
         * BeginningAndEnding(["code", "bug"]) → {"b": "g", "c": "e"}
         * BeginningAndEnding(["man", "moon", "main"]) → {"m": "n"}
         * BeginningAndEnding(["muddy", "good", "moat", "good", "night"]) → {"g": "d", "m": "t", "n": "t"}
         */
        public Dictionary<string, string> BeginningAndEnding(string[] words)
        {
            Dictionary<string, string> numberCount = new Dictionary<string, string>();

             foreach (string item in words)
            for (int i = 0; i < numberCount.Count; i++)
                
                {
                
                   // numberCount[item] = item.Substring(0,1);
                    numberCount.Add(item.Substring(0, 1), item.Substring(item.Length - 1, 1)); //item.Substring(item.Length-1,1);

                }



                return numberCount;
        }
    }
}
