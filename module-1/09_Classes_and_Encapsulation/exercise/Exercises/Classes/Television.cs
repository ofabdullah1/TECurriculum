namespace Exercises.Classes
{
    public class Television
    {
        public bool IsOn { get; private set; } = false;
        public int CurrentChannel { get; private set; } = 3;
        public int CurrentVolume { get; private set; } = 2;

        

        public void TurnOn()
        {
            
           
            if(!IsOn)
            {
                IsOn = true;
            }
            
        }


        public void TurnOff()
        {
           
            if (IsOn)
            {
                IsOn = false;
            }
           
        }

        public void ChangeChannel(int newChannel)
        {
            if(IsOn && CurrentChannel >= 3 && CurrentChannel <= 18)
            {
                CurrentChannel = newChannel;
            }
            
        }

        public void ChannelUp()
        {
            if (IsOn && CurrentChannel != 18)
            {
                CurrentChannel += 1;
            }
            else if(CurrentChannel >18)
            {
                CurrentChannel = 3;
            }

        }

        public void ChannelDown()
        {
            if (IsOn && CurrentChannel !=3)
            {
                CurrentChannel -= 1;
            }
            
            
        }

        public void RaiseVolume()
        {
            if (IsOn && CurrentVolume < 10)
            {
                
                CurrentVolume += 1;
            }
        }

        public void LowerVolume()
        {
            if (IsOn && CurrentVolume != 0)
            {
                CurrentVolume -= 1;
            }
            //else if(IsOn && CurrentVolume !< 0)
            //{
            //    CurrentVolume -= 1;
            //}
        }



    
    
    
    
    }
    
        

        
}
