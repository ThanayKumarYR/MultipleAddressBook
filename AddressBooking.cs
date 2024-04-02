using System;
using System.Collections;
using System.Collections.Generic;

namespace AddressBook
{
    class AddressBooking
    {
        public int BookId { get; set; }
        public string Bookname { get; set; }

        public List<Contacts> list = new List<Contacts>();

        public AddressBooking(int id,string name)
        { 
            BookId = id;
            Bookname = name;
        }
        public void Open()
        {
            try
            {
                Console.WriteLine("Welcome to Address Book !\n");
                
                while (true)
                {
                    Console.WriteLine("\nEnter 1 -> adding person's contact.");
                    Console.WriteLine("Enter 2 -> edit contact via name.");
                    Console.WriteLine("Enter 3 -> delete contact.");
                    Console.WriteLine("Enter 4 -> display contacts.");
                    Console.WriteLine("Enter 5 -> exiting the addressbook.\n");

                    Console.Write("Enter the choice = ");
                    int choice = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (choice)
                    {
                        case 1:
                            int count = list.Count;
                            Console.WriteLine("Adding contact details !");
                            AddDetails.AddingDetails(list);
                            if (count != list.Count)
                            {
                                Contacts contacts = list[list.Count - 1];
                                contacts.display();
                            }
                            break;
                        case 2:
                            if (list.Count > 0)
                                EditContacts.EditingContacts(list);
                            else Console.WriteLine("Address book is empty !, please add contacts and then edit!");
                            break;
                        case 3:
                            if (list.Count > 0)
                                DeleteContact.DeletingContacts(list);
                            else Console.WriteLine("Address book is empty !, please add contacts and then delete!");
                            break;

                        case 4:
                            if (list.Count > 0)
                                foreach (Contacts contact in list) contact.display();
                            else Console.WriteLine("Address book is empty !, please add contacts and then display");


                            break;
                        case 5: return;
                        default:
                            Console.WriteLine("Invalid input, enter value between 1 to 4");
                            break;

                            //everything upto date
                    }
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }
        }
    }
}
