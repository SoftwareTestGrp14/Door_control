using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Door_control
{
    public interface IUserValidation
    {
        bool ValidateEntryRequest(int id);
    }

    public class UserValidation : IUserValidation
    {
        public bool ValidateEntryRequest(int id)
        {
            return true;
        }
    }

    public class FakeUserValidation : IUserValidation
    {
        public int ValidateEntryRequestNo { get; private set; } = 0;
        public bool ValidateEntryRequest(int id)
        {
            ValidateEntryRequestNo++;

            if (id==1)
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
