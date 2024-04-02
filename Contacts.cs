using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Contacts
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        
        public Contacts(string firstname, string lastname, string email,string phonenumber, string address, string city,string state, string zipcode ) 
        
        {
            FirstName = firstname;  
            LastName = lastname;    
            Email = email;
            PhoneNumber = phonenumber;
            Address = address;
            City = city;
            State = state;
            ZipCode = zipcode;

        }

        public void display() 
        {
            Console.WriteLine($"{FirstName} {LastName} {Email} {PhoneNumber} {Address} {City} {State} {ZipCode}");
            
        }
    }
}
