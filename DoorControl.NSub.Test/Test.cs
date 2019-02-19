using Door_control;
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


    }
}
