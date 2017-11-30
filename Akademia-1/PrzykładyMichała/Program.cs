using System;

namespace PrzykładyMichała
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pierwszy program - Hello world
            Console.WriteLine("Hello World!");


            //Pierwszy przykład - zmienne. Program prosi o podanie imienia...
            Console.WriteLine("Podaj imię: ");

            string name = Console.ReadLine(); //...przypisuje imię do zmiennej...

            Console.WriteLine("Twoje imię to: "+name);//... i wypisuje imię zapisane w zmiennej na konsoli.


            //Drugi przykład - ify (instrukcje warunkowe).
            if(name == "Michał") //Jeżeli imię to Michał...
            {
                Console.WriteLine("Yay!"); //...wypisz yay! ...
            }
            else //...jeżeli nie...
            {
                Console.WriteLine("Nie jesteś Michał :( "); // Wypisz NIe jesteś Michał
            }


            
            
            //Trzeci przykład - ify z liczbami:
            int age = 20;

            if(age < 18) //Jeżeli wiek mniejszy niż 18 to wypisz nie jesteś pełnoletni...
            {
                Console.WriteLine("Nie jesteś pełnoletni");
            }
            else if(age >= 18 && age < 65) //Jeżeli wiek większy niż 18 I zarazem mniejszy niż 65 to wypisz Jesteś pełnoletni
            {
                Console.WriteLine("Jesteś pełnoletni");
            }
            else //Gdy żadny z powyższych przypadków nie jest spełniony (w praktyce wiek większy lub równy 65) wypisz Jesteś emerytem
            {
                Console.WriteLine("Jesteś emerytem");
            }


            
            
            //Czwarty - ostatni - przykład: instrukcja switch case. Wypisuje nazwę dnia tygodnia dla podanego numeru dnia tygodnia:
            int dayOfWeekNumber = 20;

            switch (dayOfWeekNumber)
            {
                case 1 : //Jeżeli dzien tygodnia ma numer 1 to:
                    Console.WriteLine("Poniedziałek");
                    break;

                case 2 : //Jeżeli dzien tygodnia ma numer 2 to: itd...
                    Console.WriteLine("Wtorek");
                    break;

                case 3 :
                    Console.WriteLine("Środa");
                    break;

                case 4 :
                    Console.WriteLine("Czwartek");
                    break;

                case 5 :
                    Console.WriteLine("Piątek");
                    break;

                case 6 :
                    Console.WriteLine("Sobota");
                    break;

                case 7 :
                    Console.WriteLine("Niedziela");
                    break;
                
                default: //Jeżeli żaden z powyższych warunków nie jest spełniony:
                    Console.WriteLine("Tydzie nie ma "+ dayOfWeekNumber+" dnia");
                    break;
            }

        }
    }
}
