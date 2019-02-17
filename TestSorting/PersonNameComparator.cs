using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSorting
{
    class PersonNameComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int result = 0;
            if (x != null && y != null)
            {
                result = String.Compare(x.Name, y.Name, StringComparison.Ordinal);
            }
            else
            {
                Console.WriteLine($"X: is {x}, Y: is {y}");
            }
            return result;
        }
    }
}
