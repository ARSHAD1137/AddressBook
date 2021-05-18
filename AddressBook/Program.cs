using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
            Console.WriteLine("Select Opertion\n 1: Add New Contact Details\n 2: Display Contact List\n 3: Edit Contact Details\n X: Exit");

            string Choice = Console.ReadLine();
            var userInput = new AddressBookBuilder();
            while (true)
            {
                switch (Choice)
                {
                    case "1":

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
                        userInput.AddInput(Input);
                        break;
                    case "2":
                        userInput.DisplayContact();
                        break;
                    case "3":
                        Console.WriteLine("Enter First Name Of Contact To Edit Contact Details");
                        string EnterName = Console.ReadLine();
                        userInput.Edit(EnterName);
                        break;
                    case "X":
                        return;

                }
                Console.WriteLine("Select Opertion\n 1: Add New Contact Details\n 2: Display Contact List\n 3: Edit Contact Details\n X: Exit");
                Choice = Console.ReadLine();


            }



        }

    }

}
