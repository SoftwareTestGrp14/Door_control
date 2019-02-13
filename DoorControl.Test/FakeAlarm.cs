using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl.Test
{
    class FakeAlarm
    {
        private int _Triggers = 0;

        public int _Alarms
        {
            get { return this._Triggers; }
        }
        
        public void RaiseAlarm()
        {
            ++_Triggers;
        }
    }
}
