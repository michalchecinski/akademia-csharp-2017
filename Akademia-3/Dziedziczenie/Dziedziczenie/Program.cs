using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personsList = new List<Person>();
            personsList.Add(new Person("Ola", "Piękna", "123456789", 21));
            personsList.Add(new Student("Eryk", "Silny", "222333444", 23,"23221"));
            personsList.Add(new ITStudent("Monika", "Mądra", "525325323", 19, "432432"));
            Profesor profesor = new Profesor("Jan", "Uczony", "111111", 44, 4500);
            iterateList(personsList);
            profesor.GradeStudent((Student)personsList[0], 4, 2);
            iterateList(personsList);
            (personsList[1] as Student).RemoveGrade(2);
            iterateList(personsList);
            Console.ReadLine();
        }
        public static void iterateList(List<Person> personsList)
        {
            foreach (var person in personsList)
            {
                person.SayHi();
                if (person is Student)
                {
                    if (person is ITStudent)
                    {
                        (person as ITStudent).HackGrades();
                    }
                    (person as Student).TellYourAverage();
                }
            }
        }
    }
}
