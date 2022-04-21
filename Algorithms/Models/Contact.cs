using System;
namespace Algorithms.Models
{
    public class Contact
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string TelephoneNumber { get; private set; }

        public Contact(string firstName, string lastName, string telephoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            TelephoneNumber = telephoneNumber;
        }
    }
}

