using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    public abstract class Employee : Person
    {
        public double Salary { get; set; }
        public Employee(string name, string surname, string pesel, int age, double salary) : base(name, surname, pesel, age)
        {
            Salary = salary;
        }
        public abstract void FireYourself();
        public virtual void Work()
        {
            Console.WriteLine("I am working");
        }
    }
}
