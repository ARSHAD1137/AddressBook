using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBook
{
    class AddressBookBuilder
    {


        private List<Contact> list { get; set; } = new List<Contact>();
        public void AddInput(Contact myObj)

        {
            list.Add(myObj);
        }
        public void DisplayContact()
        {
            foreach (var Contact in list)
            {
                Console.WriteLine("First Name:" + Contact.FirstName + "");
                Console.WriteLine("Last Name:" + Contact.LastName + "");
                Console.WriteLine("Address:" + Contact.Address + "");
                Console.WriteLine("City:" + Contact.City + "");
                Console.WriteLine("State:" + Contact.State + "");
                Console.WriteLine("Pincode:" + Contact.Pincode + "");
                Console.WriteLine("Phone Number:" + Contact.PhoneNumber + "");
                Console.WriteLine("Email:" + Contact.Email + "");
            }
        }
        public void Edit(string EnterName)
        {
            foreach (var Contact in list)
                if (Contact.FirstName == EnterName)
                {
                    Console.WriteLine("Enter Upadated Details");
                    Console.WriteLine("First Name:");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Last Name:");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Address:");
                    string address = Console.ReadLine();
                    Console.WriteLine("City:");
                    string city = Console.ReadLine();
                    Console.WriteLine("State:");
                    string state = Console.ReadLine();
                    Console.WriteLine("Pincode:");
                    int pincode = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Phone Number:");
                    int phoneNumber = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Enter valid Name");
                }
        }
    }
}