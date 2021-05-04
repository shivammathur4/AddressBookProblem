using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            //creating a list
            List<Contacts> contacts = new List<Contacts>();

            Console.WriteLine("Hello, Welcome to Address Book!");
            //choice = 0 means choice has not made yet
            int choice = 0;
            while (choice != 5)
            {
                Console.WriteLine("\t********Main Menu***********\t");
                Console.WriteLine("Enter the following choice");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Display Contacts");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Add New Contacts: ");
                        Console.WriteLine("Enter the Firstname: ");
                        string first_name = Console.ReadLine();
                        Console.WriteLine("Enter the Lastname: ");
                        string last_name = Console.ReadLine();
                        Console.WriteLine("Enter the Address: ");
                        string address = Console.ReadLine();
                        Console.WriteLine("Enter the City: ");
                        string city = Console.ReadLine();
                        Console.WriteLine("Enter the State: ");
                        string state = Console.ReadLine();
                        Console.WriteLine("Enter the Zip: ");
                        int zip = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Phone number");
                        long phone = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Enter the Email: ");
                        string email = Console.ReadLine();

                        //Reference for c
                        Contacts ct1 = new Contacts(first_name, last_name, address, city, state, zip, phone, email);
                        contacts.Add(ct1);
                        Console.WriteLine("Contact Added Successfully");
                        break;

                    case 4:
                        foreach (Contacts c in contacts)
                        {
                            Console.WriteLine(c);
                        }
                        break;
                }
            }
        }
    }
}
