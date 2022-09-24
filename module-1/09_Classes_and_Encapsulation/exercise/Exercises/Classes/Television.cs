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
            
        }

        public void ChannelUp()
        {
            
        }

        public void ChannelDown()
        {
           
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
            if (IsOn && CurrentVolume > 10)
            {
                CurrentVolume -= 1;
            }
        }



    
    
    
    
    }
    
        

        
}
