using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Door_control
{
    public interface IEntryNotification
    {
        void NotifyEntryGranted();
        void NotifyEntryDenied();

    }

    public class EntryNotfication : IEntryNotification
    {
        public void NotifyEntryGranted()
        {

        }

        public void NotifyEntryDenied()
        {

        }
    }
}
