using System;

namespace PhoneBookApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Contact, Call[]> calls = new Dictionary<Contact, Call[]>();

            
        }

        public void writeMenu()
        {
            Console.WriteLine("1. List all contacts\n" +
                                "2. Add a new contact \n" +
                                "3. Delete a contact \n" +
                                "4. Edit a contact's preference \n" +
                                "5. Manage a contact\n" + 
                                "6. List all calls\n" + 
                                "7. Exit the application\n");
        }
    }
}