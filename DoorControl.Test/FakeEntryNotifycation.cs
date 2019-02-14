using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Door_control;

namespace Door.Control.Test
{
    public class FakeEntryNotfication : IEntryNotification
    {
        public int NotifyEntryGrantedNo { get; private set; } = 0;
        public int NotifyEntryDeniedNo { get; private set; } = 0;

        public void NotifyEntryGranted()
        {
            NotifyEntryGrantedNo++;
        }

        public void NotifyEntryDenied()
        {
            NotifyEntryDeniedNo++;
        }
    }
}
