using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class SearchContact
    {
        public static bool DoesExist(List<Contacts> list ,string firstName, string lastName)
        {
            foreach (var item in list)
            {
                if (item.FirstName == firstName && item.LastName == lastName) return true;
            }
            return false;
        }
    }
}
