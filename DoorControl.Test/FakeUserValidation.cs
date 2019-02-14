using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Door_control;

namespace DoorControl.Test
{
    public class FakeUserValidation : IUserValidation
    {
        public int ValidateEntryRequestNo { get; private set; } = 0;
        public bool ValidateEntryRequest(int id)
        {
            ValidateEntryRequestNo++;

            if (id == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
