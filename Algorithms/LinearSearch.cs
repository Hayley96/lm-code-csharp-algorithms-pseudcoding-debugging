using System;
using System.Collections.Generic;
using Algorithms.Models;

namespace Algorithms
{
    public class LinearSearch
    {
        public const int SEARCH_TIME_PER_CONTACT = 200;

        public static int GetSearchTimeForContact(List<Contact> contacts, string contactFirstName)
        {
            int stepCounter = 0;

            foreach (Contact contact in contacts)
            {
                if(contact.FirstName.Equals(contactFirstName))
                {
                    stepCounter++;
                    return stepCounter * SEARCH_TIME_PER_CONTACT;
                }
                else
                    stepCounter++;
            }
            stepCounter++;
            return stepCounter * SEARCH_TIME_PER_CONTACT;
        }
    }
}
