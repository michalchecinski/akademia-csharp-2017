using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    public class Student:Person
    {
        public Student(string name, string surname, string pesel, int age,string index):base(name,surname,pesel,age)
        {
            IndexNumber = index;
            grades = new List<Grade>();
            grades.Add(new Grade(3, 2));
            grades.Add(new Grade(4, 3));
        }
        
        public string IndexNumber { get; set; }
        protected List<Grade> grades { get; set; }
        public void AddGrade(int value, int scale)
        {
            grades.Add(new Grade(value, scale));
        }
        public void RemoveGrade(int id)
        {
            foreach(Grade grade in grades)
            {
                if (grade.Id == id)
                {
                    grades.Remove(grade);
                    break;
                }
            }
        }
        public List<Grade> Grades
        {
            get
            {
                return grades;
            }
        }
        public void TellYourAverage()
        {
            int sum=0;
            int sumOfScales=0;
            foreach (var grade in grades)
            {
                sum += grade.PointsForAverage;
                sumOfScales += grade.Scale;
            }
            Console.WriteLine("Moja średnia to: " + (double)sum / sumOfScales);
        }
    }

    public sealed class ITStudent : Student
    {
        public ITStudent(string name, string surname, string pesel, int age, string index) : base(name, surname, pesel, age, index)
        {
        }

        public void HackGrades()
        {
            foreach (var grade in grades)
            {
                grade.Value = 6;
            }
        }
    }

    //public class EE_ITStudent : ITStudent
    //{

    //}
}
