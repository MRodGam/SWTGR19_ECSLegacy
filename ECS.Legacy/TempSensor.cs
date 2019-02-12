using System;

namespace ECS.Legacy 
{
    public class TempSensor : ITempSensor
    {
        public int Temp { get; private set; }

        public int GetTemp()
        {
            
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}