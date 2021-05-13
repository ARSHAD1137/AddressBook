using Amazon.DynamoDBv2.DocumentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBook
{
    public class AddressBookBuilder
    {
        private LinkedList<Contact> list = new LinkedList<Contact>();
        
        public void AddContact()
        {


        }
        public void DisplayContact()
        {
            if (list.Count > 0)
            {
               foreach(var contact in list)
               {
                    Console.WriteLine("First Name" + contact.FirstName + "Last Name");
               }
            }
            else
            {
                Console.WriteLine("List is Empty");
            }
        }
        public void SearchContact()
         
        {
            private static Search()
            {

            }
            
            var resultList = list.Where(x => x.FirstName == search.FirstName).ToList;
            int i = 1;
            foreach(var contact in resultList)
            {
                Console.WriteLine("Result {0} : {1}", i++, list[i].ToString());
            }
        }

      
    }
}
