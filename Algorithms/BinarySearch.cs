using System;
using System.Collections.Generic;
using Algorithms.Models;

namespace Algorithms
{
    public class BinarySearch
    {
        public const int SEARCH_TIME_PER_CONTACT = 200;

        public static int GetSearchTimeForContact(List<Contact> contacts, string contactFirstName)
        {
            int length = contacts.Count - 1;
            int left = 0;
            int right = length;
            int stepCounter = 0;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (contactFirstName.CompareTo(contacts[middle].FirstName) == 0)
                    return stepCounter * SEARCH_TIME_PER_CONTACT;
                if (contactFirstName.CompareTo(contacts[middle].FirstName) < 0)
                {
                    right = middle - 1;
                    stepCounter++;
                }
                if (contactFirstName.CompareTo(contacts[middle].FirstName) > 0)
                {
                    left = middle + 1;
                    stepCounter++;
                }
                else
                {
                    left = right + 1;
                    stepCounter++;
                }
            }
            stepCounter++;
            return stepCounter * SEARCH_TIME_PER_CONTACT; ;
        }
    }
}

