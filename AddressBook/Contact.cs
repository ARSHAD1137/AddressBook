using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Contact
    {
        public Contact(string firstName, string lastName, string address, string city, string state, int pincode, int phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Pincode = pincode;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Pincode { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }

    }
}