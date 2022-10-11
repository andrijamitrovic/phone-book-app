using System;

namespace PhoneBookApp
{
    public class Program
    {
        Dictionary<Contact, Call[]?> calls = new();

        static void Main(string[] args)
        {

            
        }

        public void WriteMenu()
        {
            Console.WriteLine("1. List all contacts\n" +
                                "2. Add a new contact \n" +
                                "3. Delete a contact \n" +
                                "4. Edit a contact's preference \n" +
                                "5. Manage a contact\n" + 
                                "6. List all calls\n" + 
                                "7. Exit the application\n");
        }

        public void ListAllContacts()
        {
            foreach (var contact in calls.Keys)
            {
                Console.WriteLine("Contact name: " + contact.name
                                + "\n Contact surname: " + contact.surname
                                + "\n Contact phonenum " + contact.phonenum
                                + "\n Contact preference: " + contact.preference);
            }
        }

        public void AddNewContact()
        {
            Console.WriteLine("Contact name: ");
            string? name = Console.ReadLine();
            Console.WriteLine("Contact surname: ");
            string? surname = Console.ReadLine();
            Console.WriteLine("Contact phonenum: ");
            string? phonenum = Console.ReadLine();
            bool correct = false;
            Preference preference = Preference.normal;

            while (correct == false)
            {
                Console.WriteLine("Contact preference: \n 1. Favourite \n 2. Normal \n 3. Blocked");
                int pref = int.Parse(Console.ReadLine());

                switch (pref)
                {
                    case 1:
                        correct = true;
                        preference = Preference.favourite;
                        break;
                    case 2:
                        correct = true;
                        preference = Preference.normal;
                        break;
                    case 3:
                        correct = true;
                        preference = Preference.blocked;
                        break;
                    default:
                        Console.WriteLine("Non-existant preference selected! Select one from bellow: \n");
                        break;
                }
            }
            Contact contact = new Contact(name, surname, phonenum, preference);
            calls.Add(contact, null);
        }
    }
}