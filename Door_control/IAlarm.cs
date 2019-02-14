using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Door_control
{
    public interface IAlarm
    {
        void RaiseAlarm();
    }

    public class Alarm : IAlarm
    {
        public void RaiseAlarm()
        {
            
        }
    }

    public class FakeAlarm : IAlarm
    {
        public int RaiseAlarmNo { get; private set; } = 0;
        public void RaiseAlarm()
        {
            RaiseAlarmNo++;
        }
    }
}
