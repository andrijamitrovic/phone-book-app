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
        private string? name { get; set; }
        private string? surname { get; set; }
        private string? phonenum { get; set; }
        private Preference preference { get; set; }

        public Contact(string name, string surname, string phonenum, Preference preference)
        {
            this.name = name;
            this.surname = surname;
            this.phonenum = phonenum;
            this.preference = preference;
        }

    }
}
