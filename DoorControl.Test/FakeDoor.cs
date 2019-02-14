using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Door_control;

namespace Door.Control.Test
{
    public class FakeDoor : IDoor
    {

        public int OpenNo { get; private set; } = 0;
        public int CloseNo { get; private set; } = 0;
        public void Open(Door_control.DoorControl doorControl)
        {
            OpenNo++;
            doorControl.DoorOpen();
        }

        public void Close(Door_control.DoorControl doorControl)
        {
            CloseNo++;
            doorControl.DoorClosed();
        }
    }
}
