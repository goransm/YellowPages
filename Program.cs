using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace YellowPages
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact>();
            contacts.Add(new Contact("Sean", "Skinner"));
            contacts.Add(new Contact("Samantha", "Carter"));
            contacts.Add(new Contact("Daniel", "Jackson"));
            contacts.Add(new Contact("Sean", "Connery"));
            contacts.Add(new Contact("Walter", "Skinner"));

            contacts.ForEach(delegate(Contact contact)
            {
                Console.WriteLine(contact.toString());
            });

           
            Console.WriteLine("Type a name to search for:");
            string search = "";
            do
            {
                search = Console.ReadLine();
                Console.WriteLine($"Showing results matching '{search}':");
                for(int i = 0; i < contacts.Count; i++)
                {
                    if (contacts.ElementAt(i).search(search))
                    {
                        Console.WriteLine(contacts.ElementAt(i).toString());
                    }
                }
            } while (search != "ragequit");
        }
    }

    class Contact
    {
        string firstName, lastName;
        public string fullName
        {
            get
            {
                return firstName + " " + lastName;
            }
        }

        public Contact(string a, string b)
        {
            firstName = a;
            lastName = b;
        }
        public bool search(string searchString)
        {
            return caseInsensitiveMatch(firstName, searchString) || caseInsensitiveMatch(lastName, searchString) || caseInsensitiveMatch(fullName, searchString);
        }

        private bool caseInsensitiveMatch(string text, string searchString)
        {
            return text.ToLower().Contains(searchString.ToLower());
        }

        public string toString()
        {
            return fullName;
        }
    }
}
