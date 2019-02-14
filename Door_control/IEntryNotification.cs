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
