using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
            Console.WriteLine("Select Opertion\n 1: Add New Contact Details\n 2: Display Contact List\n 3: Edit Contact Details\n 4: Delete Contact Details\n X: Exit");

            string Choice = Console.ReadLine();
            var userInput = new AddressBookBuilder();
            while (true)
            {
                switch (Choice)
                {
                    case "1":
                        AddressBookBuilder.Add();
                        break;
                    case "2":
                        AddressBookBuilder.DisplayContact();
                        break;
                    case "3":
                        Console.WriteLine("Enter the Name of Address Book You Want to Edit:");
                        AddressBookBuilder.Edit();
                        break;
                    case "4":
                        Console.WriteLine("Enter First Name of Contact To Delete Contact Details");
                        AddressBookBuilder.Delete();
                        break;
                    case "X":
                        return;

                }
                Console.WriteLine("Select Opertion\n 1: Add New Contact Details\n 2: Display Contact List\n 3: Edit Contact Details\n 4: Delete Contact Details\n X: Exit");
                Choice = Console.ReadLine();


            }



        }

    }

}
