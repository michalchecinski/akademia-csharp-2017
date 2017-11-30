using System;

namespace PracaDomowa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę: ");
            string input = Console.ReadLine();

            //Konsola zawsze odczytuje dane jako string (napis).
            //Poniższa linja konwertuje wczytany napis na liczbę całkowitą
            int a = Int32.Parse(input);

            Console.WriteLine("Podaj operację: ");
            string op = Console.ReadLine();

            Console.WriteLine("Podaj drugą liczbę: ");
            input = Console.ReadLine();

            int b = Int32.Parse(input);

        }

        static int Add(int a, int b)
        {
            //TO-DO
            return 0;
        }

        static int Subtract(int a, int b)
        {
            //TO-DO
            return 0;
        }

        static double Divide(int a, int b)
        {
            //TO-DO
            return 0;
        }

        static int Multiply(int a, int b)
        {
            //TO-DO
            return 0;
        }

        static int Compound(int a, int b)
        {
            //TO-DO
            return 0;
        }
    }
}
