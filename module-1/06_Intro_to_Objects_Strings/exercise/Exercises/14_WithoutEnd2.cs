namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a version without both the first and last char of the string. The string
        may be any length, including 0.
        WithoutEnd2("Hello") → "ell"
        WithoutEnd2("abc") → "b"
        WithoutEnd2("ab") → ""
        */
        public string WithoutEnd2(string str)
        {
            string withoutEnd =("");
            if (str.Length >= 3)

            {
                string result = str.Remove(0, 1);
                string result2 = result.Remove(result.Length-1);
                return result2;
                
                
            }
            return withoutEnd;
        }
    }
}
