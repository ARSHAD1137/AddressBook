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

    }
}