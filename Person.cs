using System;
using System.Collections.Generic;
using System.Text;

namespace YellowPages
{
    class Person
    {
        private string firstName, lastName;
        private int telephone;
        public string Name { get => firstName + " " + lastName; }
        public string Details { get => $"{Name} - {(telephone != 0 ? telephone.ToString() : "N/A")}"; }

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.telephone = 0;
        }

        public Person(string firstName, string lastName, int telephone)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.telephone = telephone;
        }

        public bool search(string searchString)
        {
            return caseInsensitiveMatch(firstName, searchString) || caseInsensitiveMatch(lastName, searchString) || caseInsensitiveMatch(Name, searchString);
        }

        public bool search(int phone)
        {
            // if phone number is not set, searching with parameter 0 should not return true
            return this.telephone != 0 && this.telephone == phone;
        }

        private bool caseInsensitiveMatch(string text, string searchString)
        {
            return text.ToLower().Contains(searchString.ToLower());
        }

    }
}
