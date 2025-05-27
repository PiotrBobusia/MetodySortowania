using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodySortowania.Tests
{
    internal class Person : IComparable<Person>
    {
        public string? FirstName { get; set; } = default;
        public string? LastName { get; set; } = default;

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public int CompareTo(Person? other)
        {
            return LastName.CompareTo(other.LastName);
        }
    }
}
