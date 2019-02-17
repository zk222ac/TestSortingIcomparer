using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>()
            {
                new Person(99, "adam" ,100),
                new Person(44, "mike" ,34),
                new Person(33, "john" ,33),
                new Person(11, "peter" ,44),
                new Person(43, "steen" ,55),
                new Person(11, "poul" ,22),
                new Person(1, "lars" ,77),

            };
            
            Print(persons);
            Console.WriteLine("Sorting By Id");
            persons.Sort(new PersonIdComparator());
            Print(persons);
            Console.WriteLine("Sorting By Name");
            persons.Sort(new PersonNameComparator());
            Print(persons);
            Console.WriteLine("Sorting By Age");
            persons.Sort(new PersonAgeComparator());
            Print(persons);

            Console.ReadKey();

        }

        static void Print(List<Person> persons)
        {
            foreach (var p in persons)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine(".......................");
        }
    }
}
