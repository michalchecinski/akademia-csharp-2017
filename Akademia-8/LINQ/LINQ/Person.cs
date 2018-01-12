using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    class Person
    {
        public string FirstName { get; private set; }
        public string  LastName { get; private set; }
        public int Age { get; private set; }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}
