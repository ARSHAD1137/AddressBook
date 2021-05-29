using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            FileExists();
            ReadFromStreamReader();
            WriteUsingStreamWriter();
            Console.ReadKey();
        }

        public static void FileExists()
        {
            String path = @"C:\Users\Arshad\source\repos\AddressBook\FileIO\AddressBookFile.txt";
            if (File.Exists(path))
                Console.WriteLine("File exists");
            else
                Console.WriteLine("File doesn't exists");
        }
        public static void ReadFromStreamReader()
        {
            String path = @"C:\Users\Arshad\source\repos\AddressBook\FileIO\AddressBookFile.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                String s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

        }

        public static void WriteUsingStreamWriter()
        {
            String path =  @"C:\Users\Arshad\source\repos\AddressBook\FileIO\AddressBookFile.txt";

            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Rahul,Roy,Hill Town,Mumbai,Maharashtra,424211,812121111,rahul@1212");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
        }

    }
}
