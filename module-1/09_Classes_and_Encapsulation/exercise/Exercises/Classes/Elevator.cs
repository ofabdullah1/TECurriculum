namespace Exercises.Classes
{
    public class Elevator
    {

        public int CurrentLevel { get; private set; } 
        public int NumberOfLevels { get; private set; } = 10;
        public bool DoorIsOpen { get; private set; } = false;


        public void OpenDoor()
        {
            
            
            {
                DoorIsOpen = true;
            }
        }


        public void CloseDoor()
        {
            
            
            {
                DoorIsOpen = false;
            }

        }


        public void GoUp(int deiredFloor)
        {
            if(DoorIsOpen = false )
            {
                CurrentLevel = deiredFloor ;
            }
            

        }



        public void GoDown(int desiredFloor)
        {
            if (DoorIsOpen = false )
            {
                CurrentLevel = desiredFloor;
            }
        }


        public Elevator(int numberOfLevels)
        {
            NumberOfLevels = numberOfLevels;

        }




    }

}
