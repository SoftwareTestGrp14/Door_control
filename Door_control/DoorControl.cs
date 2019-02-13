using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Door_control
{
    
    class DoorControl
    {
        enum State
        {

        }

        private IDoor _door;
        private IUserValidation _userValidation;
        private IEntryNotification _entryNotification;
        private IAlarm _alarm;
        public void RequestEntry(int id, IDoor door, IUserValidation userValidation, IEntryNotification entryNotification, IAlarm alarm)
        {
            _door = door;
            _userValidation = userValidation;
            _entryNotification = entryNotification;
            _alarm = alarm;
        }

        public void DoorClosed()
        {

        }

        public void DoorOpen()
        {

        }
    }
}
