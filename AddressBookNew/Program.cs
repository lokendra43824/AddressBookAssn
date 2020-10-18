using System;

namespace adressBook
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book program");

            contactBook firstContact = new contactBook("lokendra", "yeddula", "tpt", "AP", 533293, "9866256666", "xyz@abc.com");
            contactBook secondContact = new contactBook("harish", "reddy", "vskp", "TS", 580466, "9492227597", "abc@gmail.com");

            firstContact.displayContact();
            secondContact.displayContact();
        }
    }
}