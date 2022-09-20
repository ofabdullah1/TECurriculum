﻿namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string and an index, return a string length 2 starting at the given index. If the index is
        too big or too small to define a string length 2, use the first 2 chars. The string length will be
        at least 2.
        TwoChar("java", 0) → "ja"
        TwoChar("java", 2) → "va"
        TwoChar("java", 3) → "ja"
        */
        public string TwoChar(string str, int index)
        {
            if (str.Length-1 > index && index > 0)

            {
                string result = str.Substring(index, index + 2);
                return result;
            }
            else if (str.Length-1 < index)
            {
                string result = str.Substring(0, 2);
                return result;
            }
            return str;
        }
    }
}
