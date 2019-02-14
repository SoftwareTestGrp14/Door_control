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
}
