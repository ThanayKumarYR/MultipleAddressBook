using AddressBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MultipleAddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to Multiple Address Book !");
            Dictionary<int,AddressBooking> dictionary = new Dictionary<int,AddressBooking>();
            Dictionary<string, List<string>> cities = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> states = new Dictionary<string, List<string>>();

            int BookIdMain = 1;
            while (true) 
            {
                try
                {
                    Console.WriteLine("1.Create 2.Open 3.Rename 4.Display all 5.Display one 6.Delete 7.City 8.State 9.Exit");
                    Console.Write("Enter the choice = ");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1: 
                            Console.WriteLine("Creation of Address Book.");
                            Console.Write("Enter the Address book name = ");
                            string bookName  = Console.ReadLine();
                            AddressBooking address = new AddressBooking(BookIdMain++, bookName);
                            dictionary[address.BookId] = address;
                            break;
                        case 2:
                            Console.WriteLine("Opening the AddressBook");
                            Console.WriteLine("Press 1 -> Id or 2 -> Name");
                            int pressNum = int.Parse(Console.ReadLine());
                            switch (pressNum)
                            { 
                                case 1:
                                    Console.Write("Enter the id = ");
                                    int Bid = int.Parse(Console.ReadLine());
                                    if (dictionary.ContainsKey(Bid))
                                        dictionary[Bid].Open(cities,states);
                                    else Console.WriteLine("Id does not exist !");
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the Bookname = ");
                                    string BookNamed = Console.ReadLine();
                                    if (dictionary.Values.Any((book) => book.Bookname == BookNamed))
                                    {
                                        dictionary.Values.Single((book) => book.Bookname == BookNamed).Open(cities,states);
                                    }
                                    else
                                    { 
                                        Console.WriteLine("Book name doesnot exist !");
                                    }
                                    break;
                                default: 
                                    Console.WriteLine("Invalid Input !");
                                    break;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Renaming the AddressBook");
                            Console.WriteLine("Press 1 -> Id or 2 -> Name");
                            int pressNum1 = int.Parse(Console.ReadLine());
                            switch (pressNum1)
                            {
                                case 1:
                                    Console.Write("Enter the id = ");
                                    int Bid = int.Parse(Console.ReadLine());
                                    if (dictionary.ContainsKey(Bid))
                                    {
                                        Console.Write("Rename the book= ");
                                        string BookReName = Console.ReadLine();
                                        dictionary[Bid].Bookname = BookReName;
                                    }
                                    else Console.WriteLine("Id does not exist !");
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the Bookname = ");
                                    string BookNamed = Console.ReadLine();
                                    if (dictionary.Values.Any((book) => book.Bookname == BookNamed))
                                    {
                                        Console.Write("Rename the book= ");
                                        string BookReName = Console.ReadLine();
                                        dictionary.Values.Single((book) => book.Bookname == BookNamed).Bookname = BookReName;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Book name doesnot exist !");
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Invalid Input !");
                                    break;
                            }
                            break;
                        case 4:
                            Console.WriteLine("Displaying all the Address Book");
                            foreach (var item in dictionary)
                            {
                                Console.WriteLine($"Id = {item.Key}, Book Name = {item.Value.Bookname}");
                            }
                            break;
                        case 5:
                            Console.WriteLine("Displaying the AddressBook");
                            Console.WriteLine("Press 1 -> Id or 2 -> Name");
                            int pressNum2 = int.Parse(Console.ReadLine());
                            switch (pressNum2)
                            {
                                case 1:
                                    Console.Write("Enter the id = ");
                                    int Bid = int.Parse(Console.ReadLine());
                                    if (dictionary.ContainsKey(Bid))
                                    {
                                        Console.WriteLine($"Book Id = {dictionary[Bid].BookId}");
                                        Console.WriteLine($"Book Name = {dictionary[Bid].Bookname}");
                                        foreach (Contacts contact in dictionary[Bid].list) contact.display();
                                    }
                                    else Console.WriteLine("Id does not exist !");
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the Bookname = ");
                                    string BookNamed = Console.ReadLine();
                                    if (dictionary.Values.Any((book) => book.Bookname == BookNamed))
                                    {
                                       int BookID = dictionary.Values.Single((book) => book.Bookname == BookNamed).BookId;
                                        Console.WriteLine($"Book Id = {dictionary[BookID].BookId}");
                                        Console.WriteLine($"Book Name = {dictionary[BookID].Bookname}");
                                        foreach (Contacts contact in dictionary[BookID].list) contact.display();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Book name doesnot exist !");
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Invalid Input !");
                                    break;
                            }
                            break;
                        case 6:
                            Console.WriteLine("Deleting the AddressBook");
                            Console.WriteLine("Press 1 -> Id or 2 -> Name");
                            int pressNum3 = int.Parse(Console.ReadLine());
                            switch (pressNum3)
                            {
                                case 1:
                                    Console.Write("Enter the id = ");
                                    int Bid = int.Parse(Console.ReadLine());
                                    if (dictionary.ContainsKey(Bid))
                                    {
                                        Console.WriteLine($"Removing address book in {dictionary[Bid].Bookname}");
                                        dictionary.Remove(Bid);
                                    }
                                    else Console.WriteLine("Id does not exist !");
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the Bookname = ");
                                    string BookNamed = Console.ReadLine();
                                    if (dictionary.Values.Any((book) => book.Bookname == BookNamed))
                                    {
                                        int BookID = dictionary.Values.Single((book) => book.Bookname == BookNamed).BookId;
                                        Console.WriteLine($"Removing address book in {dictionary[BookID].Bookname}");
                                        dictionary.Remove(BookID);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Book name does not exist !");
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Invalid Input !");
                                    break;
                            }
                            break;
                        case 7:
                            Console.WriteLine("Contacts by City\n");
                            Console.WriteLine("City -> Contacts");
                            foreach (string city in cities.Keys)
                            {
                                foreach (string contact in cities[city])
                                {
                                    Console.WriteLine(city+" -> "+contact);
                                }
                            }
                            break;
                        case 8:
                            Console.WriteLine("Contacts by State\n");
                            Console.WriteLine("State -> Contacts");
                            foreach (string state in states.Keys)
                            {
                                foreach (string contact in states[state])
                                {
                                    Console.WriteLine(state + " -> " + contact);
                                }
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid Input !");
                            break ;
                    }
                }
                catch (Exception ex) 
                {
                    Console.WriteLine("\n\t\t\t" + ex.Message + "\n" );
                }
            }
        }
    }
}
