using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given an array of strings, return a Dictionary<string, Boolean> where each different string is a key and value
         * is true only if that string appears 2 or more times in the array.
         *
         * WordMultiple(["a", "b", "a", "c", "b"]) → {"b": true, "c": false, "a": true}
         * WordMultiple(["c", "b", "a"]) → {"b": false, "c": false, "a": false}
         * WordMultiple(["c", "c", "c", "c"]) → {"c": true}
         *
         */
        public Dictionary<string, bool> WordMultiple(string[] words)
        {
            Dictionary<string, bool> numberCount = new Dictionary<string, bool>();

            foreach (string item in words)
            {



                if (numberCount.ContainsKey(item) == true)
                {
                    //item exists in dict
                    //add 1 to existing item
                    numberCount[item] = true;
                }
                else
                {

                    numberCount[item] = false;

                }

                
            }
            return numberCount;





            //foreach (string item in words)
            //{
            //    bool appearsTwice = numberCount.ContainsKey(item + item);

            //    if (appearsTwice)
            //    {
            //        //item appears 2 or more times
            //        // return item as key and true value

            //        numberCount[item] = numberCount[item] + 1;
            //    }
            //    else
            //    {
            //        retur

            //    }

        }
        }
}
