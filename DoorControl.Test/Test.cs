using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Door_control;
using DoorControl = Door_control.DoorControl;

namespace Door.Control.Test
{
    [TestFixture]
    public class Test
    {
        private Door_control.DoorControl _uut;
        private IAlarm alarm;
        private IDoor door;
        private IEntryNotification entryNotification;
        private IUserValidation userValidation;

        [SetUp]
        public void Setup()
        {
          alarm=new FakeAlarm();
          door=new FakeDoor();
          entryNotification=new EntryNotfication();
          userValidation=new UserValidation();
          _uut=new Door_control.DoorControl(door, userValidation, entryNotification, alarm);
        }

        [Test]
        public void RequestEntry_RequestEntryCalled_OpenCalled()
        {
            _uut.RequestEntry(1);
            FakeDoor doorCheck = (FakeDoor) door;
            Assert.That(doorCheck.OpenNo, Is.EqualTo(1));
        }
    }
}
