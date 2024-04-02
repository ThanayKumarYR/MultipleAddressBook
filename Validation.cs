using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblems
{
    public class Validation
    {
        //pattern to match First name where 1st letter is caps and next 2 to 9 letters are small
        private string PatName { get; set; } = @"^[A-Z][a-z]{2,9}$";

        private string PatEmail { get; set; } = @"^\w{3,}([.+-]\w{1,})?@\w{1,}.[a-z]{1,}(.[a-z]{1,})?$";

        private string PatNumber { get; set; } = @"^[0-9]{1,3}\s[0-9]{10}$";

        private string PatZipCode { get; set; } = @"^\d{6}$";

        //refactoring code of email
        private string PatPassword { get; set; } = "^(?=.*?[A-Z])(?=.*?[0-9])(?=[^#?!@$%^&*-+]*[#?!@$%^&*-+][^#?!@$%^&*-+]*$).{8,}$";
        public bool IsName(string name)
        {
            if (Regex.IsMatch(name,PatName)) return true;
            else return false;
        }

        public bool IsEmail(string email) 
        {
            if (Regex.IsMatch(email,PatEmail)) return true;
            else return false;
        }

        public bool IsNumber(string number)
        {
            if (Regex.IsMatch(number, PatNumber)) return true;
            else return false;
        }
        public bool IsPassword(string password)
        {
            if (Regex.IsMatch(password, PatPassword)) return true;
            else return false;
        }
        public bool IsZipCode(string password)
        {
            if (Regex.IsMatch(password, PatZipCode)) return true;
            else return false;
        }
    }
}
