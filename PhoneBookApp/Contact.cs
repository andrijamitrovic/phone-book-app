using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    public enum Preference
    {
        favourite,
        normal,
        blocked
    }

    public class Contact
    {
        public string? name { get; set; }
        public string? surname { get; set; }
        public string? phonenum { get; set; }
        public Preference preference { get; set; }

        public Contact(string name, string surname, string phonenum, Preference preference)
        {
            this.name = name;
            this.surname = surname;
            this.phonenum = phonenum;
            this.preference = preference;
        }

    }
}
