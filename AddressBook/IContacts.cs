using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    // interface method
    interface Name
    {
        void myMethod1();
    }
    interface Address
    {
        void myMethod2();
    }
    interface ContactDetails
    {
        void myMethod3();
    }
    class Implement : Name, Address, ContactDetails
    {
      public void myMethod1()
      {
            string name1;
            string name2;
            Console.WriteLine("First Name:");
            name1 = Console.ReadLine();
            Console.WriteLine("Last Name:");
            name2 = Console.ReadLine();     
      }
      public void myMethod2()
      {
            string city;
            string state;
            int zip;
            Console.WriteLine("City:");
            city = Console.ReadLine();
            Console.WriteLine("State:");
            state = Console.ReadLine();
            Console.WriteLine("Zip Code:");
            zip = Convert.ToInt32(Console.ReadLine());
      }
      public void myMethod3()
      {
            int contact;
            string email;
            Console.WriteLine("Phone Number:");
            contact = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Email Address:");
            email = Console.ReadLine();
      }
    }
}
