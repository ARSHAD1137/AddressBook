using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBook
{
    class AddressBookBuilder
    {


        public static List<Contact> list  = new List<Contact>();
        public static Dictionary<string, Contact> dictionary = new Dictionary<string, Contact>();

        public static void AddInput(Contact myObj)

        {
            list.Add(myObj);
        }
        public static void DisplayContact()
        {
            foreach (var element in dictionary)
            {
                Console.WriteLine($"Address Book:{element.Key}");
                Console.WriteLine($"First Name:{element.Value.FirstName}");
                Console.WriteLine($"Last Name:{element.Value.LastName}");
                Console.WriteLine($"Address:{element.Value.Address}");
                Console.WriteLine($"City:{element.Value.City}");
                Console.WriteLine($"State:{element.Value.State}");
                Console.WriteLine($"Pincode:{element.Value.Pincode}");
                Console.WriteLine($"Phone Number:{element.Value.PhoneNumber}");
                Console.WriteLine($"Email:{element.Value.Email}");
            }
        }
        public static void Edit()
        {
   
            string EnterName = Console.ReadLine();
            foreach (var element in dictionary)
                if (element.Key == EnterName)
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
        public static void Delete()
        {
            string DeleteName = Console.ReadLine();
            foreach (var Contact in list)
                if (Contact.FirstName == DeleteName)
                {
                    list.Remove(Contact);
                    Console.WriteLine("Contact Details Deleted Succesfully");
                    break;
                }
        }
        public static void Add()
        {
                string AddName = Console.ReadLine();

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

                Console.WriteLine("Email:");
                string email = Console.ReadLine();
                var Input = new Contact(firstName, lastName, address, city, state, pincode, phoneNumber, email);
           
                 dictionary.Add(AddName, Input);
        }
        public static void Duplicate()
        {
            string AddName = Console.ReadLine();
            Console.WriteLine("First Name:");
            string firstName = Console.ReadLine();
            
            foreach (var element in dictionary)
            {
                if (element.Key.Equals(AddName) || element.Key.Equals(firstName))
                {
                    Console.WriteLine("Address Book Already Exists");
                }
                else
                {
                    Console.WriteLine("No Address Book Found, Please Select Option 1 To Add Address Book");
                }
            }

            //var duplicate = list.GroupBy(e => firstName).Where(e => e.Count() > 1).Select(e => e.Key).ToList();
            //element.Key.Equals(firstName)
        }
    }
}