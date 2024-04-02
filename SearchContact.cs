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
            return list.Any((contact) => contact.FirstName == firstName && contact.LastName == lastName);
        }
    }
}
