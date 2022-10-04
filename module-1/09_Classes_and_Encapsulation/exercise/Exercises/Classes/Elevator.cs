namespace Exercises.Classes
{
    public class Elevator
    {

        public int CurrentLevel { get; private set; } = 1;
        public int NumberOfLevels { get; private set; } = 5;
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
            if(DoorIsOpen == false && deiredFloor >= CurrentLevel && deiredFloor <= NumberOfLevels )
            {
                CurrentLevel = deiredFloor ;
            }
            

        }



        public void GoDown(int desiredFloor)
        {
            if (DoorIsOpen == false && desiredFloor <= CurrentLevel && desiredFloor > 0 && desiredFloor >=1 )
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
