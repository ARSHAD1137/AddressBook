using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
            Console.WriteLine("Select Opertion\n 1: Add New Address Book\n 2: Display Address Book\n 3: Edit Address Book\n 4: Delete Address Book\n 5: Duplicate Address Book\n 6: Search Person By City or State\n X: Exit");

            string Choice = Console.ReadLine();
            var userInput = new AddressBookBuilder();
            while (true)
            {
                switch (Choice)
                {
                    case "1":
                        Console.WriteLine("Enter Name For Address Book");
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
                    case "5":
                        Console.WriteLine("Enter the Address Book Name:");
                        AddressBookBuilder.Duplicate();
                        break;
                    case "6":
                        AddressBookBuilder.Search();
                        break;
                    case "X":
                        return;

                }
                Console.WriteLine("Select Opertion\n 1: Add New Address Book\n 2: Display Address Book\n 3: Edit Address Book\n 4: Delete Address Book\n 5: Duplicate Address Book\n 6: Search Person By City or State\n X: Exit");
                Choice = Console.ReadLine();


            }



        }

    }

}
