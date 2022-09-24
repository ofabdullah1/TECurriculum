namespace Exercises.Classes
{
    public class Elevator
    {

        public int CurrentLevel { get; private set; } = 1;
        public int NumberOfLevels { get; private set; } = 1;
        public bool DoorIsOpen { get; private set; }


        public void OpenDoor()
        {

        }


        public void CloseDoor()
        {

        }


        public void GoUp(int deiredFloor)
        {

        }



        public void GoDown(int desiredFloor)
        {

        }


        public Elevator(int numberOfLevels)
        {
            NumberOfLevels = numberOfLevels;

        }




    }

}
