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
        public void Open()
        {
            OpenNo++;
        }

        public void Close()
        {
            CloseNo++;
        }
    }
}
