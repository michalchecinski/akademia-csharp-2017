using System;
using System.Collections.Generic;

namespace CollectionsTests
{
    class Program
    {
        static void Main(string[] args)
        {


            double max =  Operations.Max<double>(5.6, 10.7);
             Console.WriteLine(max);

            Dictionary<string, string> openWith = new Dictionary<string, string>();

            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            //openWith.Add("txt", "notepad++.exe"); //Spowoduje wyjątek -> wyżej juz jest obiekt o kluczu "txt"

            Console.WriteLine("Słownik:");
            foreach (var item in openWith)
            {
               Console.WriteLine($"{item.Key} open with: {item.Value}");
            }

            Queue<string> kolejka = new Queue<string>();

            //kolejka.Enqueue("Michał");
            //kolejka.Enqueue("Kasia");
            //kolejka.Enqueue("Ola");
            //kolejka.Enqueue("Rafał");
            //kolejka.Enqueue("Kacper");

            //Console.WriteLine(kolejka.Dequeue());
            //Console.WriteLine(kolejka.Dequeue());
            //Console.WriteLine(kolejka.Dequeue());
            //Console.WriteLine(kolejka.Dequeue());
            //Console.WriteLine(kolejka.Dequeue());
            //Console.WriteLine(kolejka.Dequeue());

            //Stos kontra kolejka:
            Console.WriteLine("Stos kontra kolejka:");

            Stack<string> stos = new Stack<string>();
            stos.Push("Zawód: Programista");
            stos.Push("Krzyżacy");
            stos.Push("Pan Tadeusz");
            stos.Push("Zrozumieć programowanie");

            Console.WriteLine("Stos:");
            Console.WriteLine(stos.Pop());
            Console.WriteLine(stos.Pop());
            Console.WriteLine(stos.Pop());
            Console.WriteLine(stos.Pop());


            kolejka.Enqueue("Zawód: Programista");
            kolejka.Enqueue("Krzyżacy");
            kolejka.Enqueue("Pan Tadeusz");
            kolejka.Enqueue("Zrozumieć programowanie");

            Console.WriteLine("Kolejka:");
            Console.WriteLine(kolejka.Dequeue());
            Console.WriteLine(kolejka.Dequeue());
            Console.WriteLine(kolejka.Dequeue());
            Console.WriteLine(kolejka.Dequeue());

        }
    }
}
