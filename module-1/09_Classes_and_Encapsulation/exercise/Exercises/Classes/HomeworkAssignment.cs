namespace Exercises.Classes
{
    public class HomeworkAssignment
    {
        public int EarnedMarks{ get; set; }
        public int PossibleMarks { get; private set; }
        public string SubmitterName { get; private set; }
        public string LetterGrade
        {
            get
            {
                
                

               if  (EarnedMarks >= 90) 
                    {
                       return "A";
                    }
                    else if ((EarnedMarks >= 80) && (EarnedMarks <= 89))
                    {
                        return "B";
                    }
                    else if ((EarnedMarks >= 70) && (EarnedMarks <= 79))
                    {
                        return "C";
                    }
                    else if ((EarnedMarks >= 60) && ( EarnedMarks <= 69))
                    {
                        return "D";
                    }
                    else
                    {
                    return "F";
                    }
               

            }
        }


    public HomeworkAssignment (int possibleMarks, string submitterName)
        {
            PossibleMarks = possibleMarks;
            SubmitterName = submitterName;
        }

        
            
     }
        

    
}
