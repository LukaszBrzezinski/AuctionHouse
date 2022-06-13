using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionHouse.API.Services
{
    public class Password : IPassword
    {
        public string password;

        public bool IsPasswordTooShort()
        {
            if (password.Length < 6)
            {
                return true;
            }
            return false;
        }
        public bool IsExistCapitalLetter()
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (!Char.IsLower(password[i]))
                {
                    return true;
                }

            }
            return false;
        }
        public string IsCorrectPassword()
        {
            string warings = "Hasło " + password+". ";
            if (IsPasswordTooShort())
            {
                warings += "Jest za krótkie." ;
            }
            if (!IsExistCapitalLetter())
            {
                warings += "Brakuje dużej litery. ";
            }


            return warings;
        }
    }
}
