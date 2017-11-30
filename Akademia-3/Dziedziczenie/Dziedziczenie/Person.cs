using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    public class Person
    {
        public Person(string name, string surname, string pesel, int age)
        {
            Name = name;
            Surname = surname;
            Pesel = pesel;
            Age = age;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pesel { get; set; }
        public int Age { get; set; }
        public void SayHi()
        {
            Console.WriteLine("Cześć, milo mi jestem:{0} {1} ", Name, Surname);
        }
    }
}
