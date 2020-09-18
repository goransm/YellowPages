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
            List<Person> contacts = new List<Person>();
            contacts.Add(new Person("Sean", "Skinner"));
            contacts.Add(new Person("Samantha", "Carter", 12345678));
            contacts.Add(new Person("Daniel", "Jackson"));
            contacts.Add(new Person("Sean", "Connery"));
            contacts.Add(new Person("Walter", "Skinner", 87654321));

            contacts.ForEach(delegate(Person p)
            {
                Console.WriteLine(p.Details);
            });

           
            Console.WriteLine("Type a name or a number to search for:");
            string search = "";
            do
            {
                search = Console.ReadLine();
                Console.WriteLine($"Showing results matching '{search}':");
                try
                {
                    int phone = int.Parse(search);
                    for(int i = 0; i < contacts.Count; i++)
                    {
                        if (contacts.ElementAt(i).search(phone))
                        {
                            Console.WriteLine(contacts.ElementAt(i).Details);
                        }
                    }
                } 
                catch
                {
                    for(int i = 0; i < contacts.Count; i++)
                        {
                            if (contacts.ElementAt(i).search(search))
                            {
                                Console.WriteLine(contacts.ElementAt(i).Details);
                            }
                        }
                }



            } while (search != "ragequit");
        }

    }
}
