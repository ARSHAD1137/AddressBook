using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBook
{
    class AddressBookBuilder
    {


        public static List<Contact> list = new List<Contact>();
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
        public static void Search()
        {
            Console.WriteLine("Select the choice to find the Person from list");
            Console.WriteLine("Enter the Choice:\n 1: City\n 2: State\n X: Exit");
            string choice = Console.ReadLine();
            
           
            foreach(var element in dictionary)
            {
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter the city name:");
                        string city = Console.ReadLine();
                        if (element.Value.City.Equals(city))
                        {
                            Console.WriteLine("Person is found in {0}: " + element.Value.FirstName, city);
                        }
                        else
                        {
                            Console.WriteLine("Person is not found");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Enter the State name:");
                        string state = Console.ReadLine();
                        if (element.Value.State.Equals(state))
                        {
                            Console.WriteLine("Person is found in {0}: " + element.Value.FirstName, state);
                        }
                        else
                        {
                            Console.WriteLine("Person is not found");
                        }
                        break;
                    case "X":
                        return;
                }

            }
        }
        public static void View()
        {
            Console.WriteLine("View person by city and state");
            Console.WriteLine("Enter the person name");
            string name = Console.ReadLine();

            foreach (var element in dictionary)
            {
                if (element.Value.FirstName.Equals(name))
                {
                    Console.WriteLine("Person name is {0} from the city {1} and its state is {2}", name, element.Value.City, element.Value.State);
                }
                else
                {
                    Console.WriteLine("Person is not found");
                }

            }
        }
        public static void Contact()
        {
            Console.WriteLine("Get number of person to contact by city and state");
            Console.WriteLine("Select Choice to count person by \n 1: City\n 2: State\n X: Exit");
            string choice = Console.ReadLine();

            int count = 0;
            int count1 = 0;

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter the city name");
                    string city = Console.ReadLine();
                    foreach(var element in dictionary)
                    {
                        if (element.Value.City.Equals(city))
                        {
                            Console.WriteLine("Number of person available for contact in {0} is {1} ", city, count++);
                        }
                        else
                        {
                            Console.WriteLine("Person is not found for contact in" + "" + city);
                        }
                    }
                    break;
                case "2":
                    Console.WriteLine("Enter the state name");
                    string state = Console.ReadLine();
                    foreach(var element in dictionary)
                    {
                        if (element.Value.City.Equals(state))
                        {
                            Console.WriteLine("Number of person available for contact in {0} is {1}", state, count1++);
                        }
                        else
                        {
                            Console.WriteLine("Person is not found for contact in" + "" + state);
                        }
                    }
                    break;
                case "X":
                    return;

            }
        }
    }
}