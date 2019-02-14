using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Door_control
{
    public interface IDoor
    {
        void Open(DoorControl doorControl);
        void Close(DoorControl doorControl);
    }

    public class Door : IDoor
    {
        public void Open(DoorControl doorControl)
        {
            
        }

        public void Close(DoorControl doorControl)
        {
            
        }
    }

    public class FakeDoor : IDoor
    {
        
        public int OpenNo { get; private set; } = 0;
        public int CloseNo { get; private set; } = 0;
        public void Open(DoorControl doorControl)
        {
            OpenNo++;
            doorControl.DoorOpen();
        }

        public void Close(DoorControl doorControl)
        {
            CloseNo++;
            doorControl.DoorClosed();
        }
    }
}
