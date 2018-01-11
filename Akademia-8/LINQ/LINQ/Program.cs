using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person("Michał", "Chęciński", 21),
                new Person("Adaś", "Miałczyński", 44),
                new Person("Euzebiusz", "Smolarek", 35),
                new Person("Maciej", "Aniserowicz", 34),
                new Person("Mirek", "Burnejko", 32),
                new Person("Jan", "Kowalski", 13),
                new Person("Jan", "Nowak", 23),
                new Person("Jan", "Traczyk", 29),
                new Person("Jan", "Lewandowski", 50),
                new Person("Paweł", "Małoletni", 9),
                new Person("Iwona", "Nowak", 5),
                new Person("Lena", "Wójcik", 16),
                new Person("Karol", "Wójcik", 75),
                new Person("Ilona", "Jarząbek", 50),
                new Person("Anna", "Krawczyk", 25),
                new Person("Katrzyna", "Lewandowska", 27),
                new Person("Andrzej", "Wiśniewski", 28)
            };

        }


        static void WriteAllElements(IEnumerable<Person> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} {item.Age}" );
            }
        }

    }
}
