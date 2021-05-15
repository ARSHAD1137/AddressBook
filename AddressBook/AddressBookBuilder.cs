
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
        public  void DisplayContact()
        {
            foreach (var Contact in list)
            {
                Console.WriteLine(Contact.FirstName + "" + Contact.LastName + ""+Contact.Address+""+Contact.City+""+Contact.State+""+Contact.Pincode+""+Contact.PhoneNumber+""+Contact.Email+"");
            }
        }
       

      
    }
}
