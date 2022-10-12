using System;

namespace PhoneBookApp
{
    public class Program
    {
        Dictionary<Contact, Call[]?> calls = new();

        static void Main(string[] args)
        {
            Program p = new();
            while (true)
            {
                Console.Clear();
                p.WriteMenu();
                int key = int.Parse(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.Clear();
                        p.ListAllContacts();
                        Console.WriteLine("Press any key to go back\n");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        p.AddNewContact();
                        Console.WriteLine("Press any key to go back\n");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Enter the contact's phonenum: \n");
                        string phonenumDel = Console.ReadLine();
                        while(p.DeleteContact(phonenumDel) == false)
                        {
                            Console.Clear();
                            Console.WriteLine("Incorrect phonenum! Enter the contact's phonenum: \n");
                            phonenumDel = Console.ReadLine();
                        }
                        Console.WriteLine("Press any key to go back\n");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Enter the contact's phonenum: \n");
                        string phonenumPrefEdit = Console.ReadLine();
                        while (p.EditPreference(phonenumPrefEdit) == false)
                        {
                            Console.Clear();
                            Console.WriteLine("Incorrect phonenum! Enter the contact's phonenum: \n");
                            phonenumPrefEdit = Console.ReadLine();
                        }
                        Console.WriteLine("Press any key to go back\n");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private bool EditPreference(string? phonenumPrefEdit)
        {
            Contact? EditedContact = null;
            foreach (Contact contact in calls.Keys)
            {
                if (contact.phonenum == phonenumPrefEdit)
                    EditedContact = contact;
            }
            if (EditedContact == null)
                return false;

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
            Call[]? callsToCopy = calls[EditedContact];
            calls.Remove(EditedContact);
            EditedContact.preference = preference;
            calls.Add(EditedContact, callsToCopy);
            return true;
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
            if(calls == null)
                Console.WriteLine("No contacts");
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
        
        public bool DeleteContact(string phonenum)
        {
            Contact? DeletedContact = null;
            foreach(Contact contact in calls.Keys)
            {
                if(contact.phonenum == phonenum)
                    DeletedContact = contact;
            }
            if (DeletedContact == null)
                return false;

            calls.Remove(DeletedContact);
            return true;
        }

    }
}