using RegexProblems;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static AddressBook.CustomException;

namespace AddressBook
{
    class EditContacts
    {

        public static void EditingContacts(List<Contacts> list)
        {
            try
            {
                string oldFname, oldLname;
                Validation validation = new Validation();

                Console.Write("If you wanna exit press Y + enter else anyChar + enter = ");
                char chooseExit = char.Parse(Console.ReadLine());
                if (chooseExit == 'Y' || chooseExit == 'y') return;

                Console.WriteLine("Editing Contacts");
                Console.Write("Enter the First name: ");
                string firstname = Console.ReadLine();
                Console.Write("Enter the Last name: ");
                string lastname = Console.ReadLine();

                if (firstname.Length == 0 || lastname.Length == 0)
                {
                    throw new StringEmptyException();
                }
                else if (firstname.Length > 0 && lastname.Length > 0)
                {
                    foreach (Contacts item in list)
                    {
                        if (item.FirstName == firstname && item.LastName == lastname)
                        {
                            oldFname = item.FirstName; oldLname = item.LastName;
                            while (true)
                            {
                                Console.WriteLine("\nEnter 1 -> edit First Name");
                                Console.WriteLine("Enter 2 -> edit Last Name");
                                Console.WriteLine("Enter 3 -> edit email ");
                                Console.WriteLine("Enter 4 -> edit phone number");
                                Console.WriteLine("Enter 5 -> edit address");
                                Console.WriteLine("Enter 6 -> edit city");
                                Console.WriteLine("Enter 7 -> edit state");
                                Console.WriteLine("Enter 8 -> edit zip code");
                                Console.WriteLine("Enter 9 -> exit editing\n");

                                Console.Write("Enter the choice = ");
                                int choice = int.Parse(Console.ReadLine());

                                switch (choice)
                                {
                                    case 1:
                                        Console.Write("\nEdit the First name = ");
                                        string fname = Console.ReadLine();
                                        if (!validation.IsName(fname)) throw new InvalidNameException();
                                        if (SearchContact.DoesExist(list,fname,oldLname)) throw new ContactAlreadyExistsException();
                                        item.FirstName = fname;
                                        break;
                                    case 2:
                                        Console.Write("\nEdit the Last name = ");
                                        string lname = Console.ReadLine();
                                        if (validation.IsName(lastname) == false) throw new InvalidNameException();
                                        if (SearchContact.DoesExist(list, oldFname, lname)) throw new ContactAlreadyExistsException();
                                        item.LastName = lname;
                                        break;
                                    case 3:
                                        Console.Write("\nEdit the Email = ");
                                        string editEmail = Console.ReadLine();
                                        if (!validation.IsEmail(editEmail)) throw new InvalidEmailException();
                                        item.Email = editEmail;
                                        break;
                                    case 4:
                                        Console.Write("\nEdit the Phone Number = ");
                                        string editNumber = Console.ReadLine();
                                        if (!validation.IsNumber(editNumber)) throw new InvalidNumberException();
                                        item.PhoneNumber = editNumber;
                                        break;
                                    case 5:
                                        Console.Write("\nEdit the Address = ");
                                        string editAddress = Console.ReadLine();
                                        if(string.IsNullOrEmpty(editAddress)) throw new StringEmptyException();
                                        item.Address = editAddress; 
                                        break;
                                    case 6:
                                        Console.Write("\nEdit the City = ");
                                        string editCity = Console.ReadLine();
                                        if (string.IsNullOrEmpty(editCity)) throw new StringEmptyException();
                                        item.City = editCity;
                                        break;
                                    case 7:
                                        Console.Write("\nEdit the State = ");
                                        string editState = Console.ReadLine();
                                        if (string.IsNullOrEmpty(editState)) throw new StringEmptyException();
                                        item.State = editState; 
                                        break;
                                    case 8:
                                        Console.Write("\nEdit the Zip Code = ");
                                        string editZipCode = Console.ReadLine();
                                        if (!validation.IsZipCode(editZipCode)) throw new InvalidZipCodeException();
                                        item.ZipCode = editZipCode;
                                        break;
                                    case 9:
                                        return;
                                    default:
                                        Console.WriteLine("Invalid input !");
                                        break;
                                }

                            }
                        }
                        else
                        {
                            throw new ContactNotFoundException();
                        }
                    }
                }
            }
            catch { EditingContacts(list); }
        }
    }
}
