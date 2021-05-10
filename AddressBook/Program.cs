using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
            
             Contact myObj = new Contact();

            Console.WriteLine("First Name:");
            myObj.FirstName = Console.ReadLine();
            Console.WriteLine(myObj.FirstName);

            Console.WriteLine("Last Name:");
            myObj.LastName = Console.ReadLine();
            Console.WriteLine(myObj.LastName);

            Console.WriteLine("Address:");
            myObj.Address = Console.ReadLine();
            Console.WriteLine(myObj.Address);

            Console.WriteLine("City:");
            myObj.City = Console.ReadLine();
            Console.WriteLine(myObj.City);

            Console.WriteLine("State:");
            myObj.State = Console.ReadLine();
            Console.WriteLine(myObj.State);

            Console.WriteLine("Pincode:");
            myObj.Pincode = Console.ReadLine();
            Console.WriteLine(myObj.Pincode);

            Console.WriteLine("Phone Number:");
            myObj.PhoneNumber = Console.ReadLine();
            Console.WriteLine(myObj.PhoneNumber);

            Console.WriteLine("Email:");
            myObj.Email = Console.ReadLine();
            Console.WriteLine(myObj.Email);
        }

    }
    
}    
