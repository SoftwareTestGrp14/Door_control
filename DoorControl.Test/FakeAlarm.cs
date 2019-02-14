using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Door_control;

namespace Door.Control.Test
{
    class FakeAlarm : IAlarm
    {
        public int Triggers { get; private set; } = 0;
        public void RaiseAlarm()
        {
            ++Triggers;
        }
    }
}
