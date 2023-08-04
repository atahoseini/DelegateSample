using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample
{

    public delegate string PersonToString(Person person);
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class PersonFullName
    {
        public static string GetPersonFullName(Person person) => $"{person.FirstName} {person.LastName}";
    }
    public class PersonFullNameReverse
    {
        public static string GetPersonFullName(Person person) => $"{person.LastName} {person.FirstName} ";
    }
    public class PersonPrinter
    {
        public void Print(Person person)
        {
            string s= PersonFullName.GetPersonFullName(person);
            Console.WriteLine(s);
        }

        public void Print2(PersonToString personToString,Person person)
        {
            string s = personToString(person);
            Console.WriteLine(s);
        }
    }
}
