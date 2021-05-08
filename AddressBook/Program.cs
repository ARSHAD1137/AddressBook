using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
            Implement myobj = new Implement();
            myobj.myMethod1();
            myobj.myMethod2();
            myobj.myMethod3();
        }
    }
}
