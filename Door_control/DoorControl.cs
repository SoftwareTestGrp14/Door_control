using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Door_control
{
    
    public class DoorControl
    {
        enum State
        {
            DoorOpening,
            DoorClosing,
            DoorClosed,
            DoorBreached
        };

        private IDoor _door;
        private IUserValidation _userValidation;
        private IEntryNotification _entryNotification;
        private IAlarm _alarm;
        private State _state = State.DoorClosed;

        public DoorControl(IDoor door, IUserValidation userValidation, IEntryNotification entryNotification, IAlarm alarm)
        {
            _door = door;
            _userValidation = userValidation;
            _entryNotification = entryNotification;
            _alarm = alarm;
        }
        public void RequestEntry(int id)
        {
            if (_state==State.DoorClosed)
            {
                if (_userValidation.ValidateEntryRequest(id) == true)
                {
                    _door.Open(this);
                    _entryNotification.NotifyEntryGranted();
                    _state = State.DoorOpening;
                }

                else
                {
                    _entryNotification.NotifyEntryDenied();
                }
            }
            else
            {
                
            }
            
        }

        public void DoorClosed()
        {
            if (_state==State.DoorClosing)
            {
                _state = State.DoorClosed;
            }
            
        }

        public void DoorOpen()
        {
            if (_state==State.DoorOpening)
            {
                _door.Close(this);
                _state = State.DoorClosing;
            }
            
            else if (_state==State.DoorClosed)
            {
                _door.Close(this);
                _alarm.RaiseAlarm();
                _state = State.DoorBreached;
            }

        }
    }
}
