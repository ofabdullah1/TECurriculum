﻿namespace Exercises.Classes
{
    public class Television
    {
        public bool IsOn { get; private set; }
        public int CurrentChannel { get; private set; }
        public int CurrentVolume { get; private set; }

        public void TurnOff()
        {
            this.IsOn = false;
        }

        public void TurnOn()
        {
            IsOn = true;
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

        }

        public void LowerVolume()
        {

        }



    
    
    
    
    }
    
        

        
}
