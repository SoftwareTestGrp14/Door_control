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
          entryNotification=new FakeEntryNotfication();
          userValidation=new FakeUserValidation();
          _uut=new Door_control.DoorControl(door, userValidation, entryNotification, alarm);
        }

        [Test]
        public void RequestEntry_RequestEntryCalled_IdEqualsTrue_ValidateEntryRequestIsCalled()
        {
            _uut.RequestEntry(1);
            FakeUserValidation userValidationCheck = (FakeUserValidation)userValidation;
            Assert.That(userValidationCheck.ValidateEntryRequestNo, Is.EqualTo(1));
        }
        [Test]
        public void RequestEntry_RequestEntryCalled_IdEqualsTrue_OpenCalled()
        {
            _uut.RequestEntry(1);
            FakeDoor doorCheck = (FakeDoor) door;
            Assert.That(doorCheck.OpenNo, Is.EqualTo(1));
        }

        [Test]
        public void RequestEntry_RequestEntryCalled_IdEqualsTrue_NotifyEntryGrantedIsCalled()
        {
            _uut.RequestEntry(1);
            FakeEntryNotfication entryNotficationCheck = (FakeEntryNotfication)entryNotification;
            Assert.That(entryNotficationCheck.NotifyEntryGrantedNo, Is.EqualTo(1));
        }

        [Test]
        public void RequestEntry_RequestEntryCalled_IdEqualsTrue_NotifyEntryDeniedIsNotCalled()
        {
            _uut.RequestEntry(1);
            FakeEntryNotfication entryNotficationCheck = (FakeEntryNotfication)entryNotification;
            Assert.That(entryNotficationCheck.NotifyEntryDeniedNo, Is.EqualTo(0));
        }

        [Test]
        public void RequestEntry_RequestEntryCalled_IdEqualsFalse_NotifyEntryDeniedIsCalled()
        {
            _uut.RequestEntry(2);
            FakeEntryNotfication entryNotficationCheck = (FakeEntryNotfication)entryNotification;
            Assert.That(entryNotficationCheck.NotifyEntryDeniedNo, Is.EqualTo(1));
        }

        [Test]
        public void RequestEntry_RequestEntryCalled_IdEqualsFalse_NotifyEntryGrantedIsNotCalled()
        {
            _uut.RequestEntry(2);
            FakeEntryNotfication entryNotficationCheck = (FakeEntryNotfication)entryNotification;
            Assert.That(entryNotficationCheck.NotifyEntryGrantedNo, Is.EqualTo(0));
        }

        [Test]
        public void DoorOpen_DoorOpenIsCalled_StateEqualsDoorClosed_ClosedCalled()
        {
            _uut.DoorOpen();
            FakeDoor doorCheck = (FakeDoor)door;
            Assert.That(doorCheck.CloseNo, Is.EqualTo(1));
        }

        [Test]
        public void DoorOpen_DoorOpenIsCalled_StateEqualsDoorClosed_RaiseAlarmCalled()
        {
            _uut.DoorOpen();
            FakeAlarm alarmCheck = (FakeAlarm) alarm;
            Assert.That(alarmCheck.Triggers, Is.EqualTo(1));
        }
    }
}
