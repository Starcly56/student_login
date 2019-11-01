using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_of__student
{
    public class Helper
    {
        public bool CheckEmail(string email)
        {
            if (email.Contains ( "@"))
                return true;
            else
                return false;
               
        }
        public bool CheckPassword (string password,string cpassword)
        {
            if (password == cpassword)
                return true;
            else
                return false;
        }

    }
}
