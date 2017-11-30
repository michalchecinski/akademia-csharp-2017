using System;
using System.Runtime.InteropServices;

namespace ValueReference
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 20;
            AddByValue(number);
            Console.WriteLine("Zmienna liczba po zmianie w metodzie: "+number);

            Console.WriteLine();

            Rectangle rectangle = new Rectangle(1, 1);
            Console.WriteLine("Prostokąt po utworzeniu to: " + rectangle.Write());

            AreaByReference(rectangle);
            Console.WriteLine("Prostokąt po zastosowaniu metody: " + rectangle.Write());

        }

        static int AddByValue(int a)
        {
            a = 2;
            return a + a;
        }

        static int AreaByReference(Rectangle rectangle)
        {
            rectangle.Height = 2;
            rectangle.Width = 4;

            return rectangle.Field();
        }
    }
}
