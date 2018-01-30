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

            var jans = people.Where(x => x.FirstName == "Jan").FirstOrDefault();
            //WriteAllElements(jans);

            Person jan = people.Where(x => x.FirstName == "Jan").FirstOrDefault();
            //Console.WriteLine($"{jan.FirstName} {jan.LastName} {jan.Age}");

            Person filip = people.Where(x => x.FirstName == "Filip").FirstOrDefault();
            if (filip == null)
            {
                //Console.WriteLine("Filipa nie ma w kolekcji");
            }

            var ordered = people.Where(x => x.FirstName == "Jan")
                                .OrderByDescending(x => x.Age);
            //WriteAllElements(ordered);

            //Console.WriteLine("Suma: "+ people.Sum(x => x.Age));

            //Console.WriteLine("Średnia wieku: "+people.Average(x => x.Age));

            //Console.WriteLine("Ilość osób w kolekcji: "+ people.Count());

            try
            {
                people.Single(x => x.FirstName == "Stefan");
            }
            catch (Exception)
            {

                //Console.WriteLine("Stefana nie ma");
            }

            //Console.WriteLine(people.Where(x => x.Age == 44).Any());

            var orderedTwice = people.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            WriteAllElements(orderedTwice);


            //WriteAllElements(people.OrderBy(x => x.FirstName + x.LastName));
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
