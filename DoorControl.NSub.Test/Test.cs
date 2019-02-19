﻿using Door_control;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Door_control;
using NSubstitute;

namespace DoorControl.NSub.Test
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
            alarm = Substitute.For<IAlarm>();
            door = Substitute.For<IDoor>();
            entryNotification = Substitute.For<IEntryNotification>();
            userValidation = Substitute.For<IUserValidation>();
            _uut = new Door_control.DoorControl(door, userValidation, entryNotification, alarm);
        }


        [Test]
        public void RequestEntry_RequestEntryCalled_IdEqualsTrue_ValidateEntryRequestIsCalled()
        {
            _uut.RequestEntry(1);
            userValidation.Received(1).ValidateEntryRequest(1);
        }

        [Test]
        public void RequestEntry_RequestEntryCalled_IdEqualsTrue_OpenCalled()
        {
            _uut.RequestEntry(1);
            door.Received(1).Open(_uut);
        }

        [Test]
        public void RequestEntry_RequestEntryCalled_IdEqualsTrue_NotifyEntryGrantedIsCalled()
        {
            _uut.RequestEntry(1);

            entryNotification.Received(1).NotifyEntryGranted();
        }


        [Test]
        public void RequestEntry_RequestEntryCalled_IdEqualsTrue_NotifyEntryDeniedIsNotCalled()
        {
            _uut.RequestEntry(1);
            entryNotification.DidNotReceive().NotifyEntryDenied();
        }

        [Test]
        public void RequestEntry_RequestEntryCalled_IdEqualsFalse_NotifyEntryDeniedIsCalled()
        {
            _uut.RequestEntry(2);
            entryNotification.Received(1).NotifyEntryDenied();
        }





        [Test]
        public void RequestEntry_RequestEntryCalled_IdEqualsFalse_NotifyEntryGrantedIsNotCalled()
        {
            _uut.RequestEntry(2);
            entryNotification.Received(0).NotifyEntryGranted();
        }

        [Test]
        public void RequestEntry_RequestEntryCalled_IdEqualsTrue_ClosedCalled()
        {
            _uut.RequestEntry(1);
            door.Received(1).Close(doorControl: _uut);
        }
    }
}
