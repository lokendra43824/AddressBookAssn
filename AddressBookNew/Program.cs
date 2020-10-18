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

            firstContact.displayContact();
        }
    }
}