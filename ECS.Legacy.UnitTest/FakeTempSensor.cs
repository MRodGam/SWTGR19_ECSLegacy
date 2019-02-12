using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ECS.Legacy;

namespace ECS.Legacy.UnitTest
{
    class FakeTempSensor : ITempSensor
    {
      

        public int GetTemp()
        {
            return gen.Next(-5, 45);
        }

        public bool RunSelfTest()
        {
            return true;
        }

    }
}
