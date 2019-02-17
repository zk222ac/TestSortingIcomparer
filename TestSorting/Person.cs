using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSorting
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Id:{Id} , Name:{Name}, Age:{Age}";
        }

        public override int GetHashCode()
        {
            return Id;
        }   

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            else if (ReferenceEquals(this, obj))
            {
                return true;
            }
            else if (obj.GetType() != this.GetType())
            {
                return false;
            }
            else
            {
                return Equals((Person)obj);
            }
           
           
        }
    }
}
