using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class CustomException : ApplicationException
    {
        public CustomException() 
        {
            Console.Write("Custom Exception : ");
        }
        public class ContactNotFoundException : CustomException
        {
            public ContactNotFoundException()
            {
                Console.WriteLine("The contact your searching for does not exist\n!");
            }
        }

        public class ContactAlreadyExistsException : CustomException 
        {
            public ContactAlreadyExistsException()
            {
                Console.WriteLine("The contact already exit with the same first and last name !\n");
            }
        }

        public class InvalidEmailException : CustomException
        {
            public InvalidEmailException()
            { 
                Console.WriteLine("The entered email is not in the correct format !\n");
            }
        }

        public class InvalidNameException : CustomException 
        {
            public InvalidNameException() 
            {
                Console.WriteLine("The entered name is not in the correct format !\n");
            }
        }

        public class InvalidNumberException : CustomException
        {
            public InvalidNumberException()
            {
                Console.WriteLine("The entered number is not in the correct format !\n");
            }
        }

        public class InvalidZipCodeException : CustomException
        {
            public InvalidZipCodeException()
            {
                Console.WriteLine("The entered zip code is not in the correct format !\n");
            }
        }

        public class StringEmptyException : CustomException
        {
            public StringEmptyException()
            {
                Console.WriteLine("Inputs cannot be null !\n");
            }
        }

        public class InvalidInputException : CustomException
        {
            public InvalidInputException()
            {
                Console.WriteLine("Invalid Input !");
            }
        }
    }
}
