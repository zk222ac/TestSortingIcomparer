using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSorting
{
    class PersonAgeComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int result = 0;
            if (x != null && y != null)
            {
                result = x.Age.CompareTo(y.Age);
            }
            else
            {
                Console.WriteLine($"X: is {x}, Y: is {y}");
            }
            return result;
        }
    }
}
