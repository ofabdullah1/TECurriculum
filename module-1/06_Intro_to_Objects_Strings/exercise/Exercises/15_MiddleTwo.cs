namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string of even length, return a string made of the middle two chars, so the string "string"
        yields "ri". The string length will be at least 2.
        MiddleTwo("string") → "ri"
        MiddleTwo("code") → "od"
        MiddleTwo("Practice") → "ct"
        */
        public string MiddleTwo(string str)
        {
            string result = str.Substring(0, str.Length / 2);
            string result2 = str.Substring(str.Length / 2);
            string result3 = result.Substring(result.Length - 1);
            string result4 = result2.Substring(result2[0]);

            string result5 = result4 + result3;
            

            return result5;
        }
    }
}
