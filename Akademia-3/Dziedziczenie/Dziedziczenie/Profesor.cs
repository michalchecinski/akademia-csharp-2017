using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    public class Profesor : Employee
    {
        public Profesor(string name, string surname, string pesel, int age, double salary) : base(name, surname, pesel, age, salary)
        {
        }

        public override void FireYourself()
        {
            Console.WriteLine("Idę do dziekana się zwolnić.");
        }
        public override void Work()
        {
            Console.WriteLine("I am teaching");
        }
        public void GradeStudent(Student student,int value, int scale)
        {
            student.AddGrade(value, scale);
        }
    }
}
