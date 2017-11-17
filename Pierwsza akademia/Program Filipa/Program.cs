using System;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrzywitajSie("Filip");
            int[] liczby = {1, 34, -19, 19, -9, -7 };
            Console.WriteLine("Liczb dodatnich w tablicy jest: " + IleDodatnich(liczby));
            string[] imiona = {"Kasia", "Ola", "Zuzia"};
            PrzywitajSieGrupowe(imiona);
            int a = 5;
            int b = 0;
            Console.WriteLine("{0} do potegi {1} wedlug metody z while = {2}, wedlug metody z do while = {3}",a,b,PotegaWhile(a,b),PotegaDoWhile(a,b));
            Console.ReadLine();
        }

        static void PrzywitajSie(string imie)
        {
            Console.WriteLine(imie);
        }

        static int IleDodatnich(int[] liczby)
        {
            int ileDodatnich = 0;
            for (int i = 0; i < liczby.Length; i++)
            {
                if (liczby[i] >= 0)
                {
                    ileDodatnich++;
                }
            }
            return ileDodatnich;
        }

        static void PrzywitajSieGrupowe(string[] imiona)
        {
            foreach (string imie in imiona)
            {
                Console.WriteLine("Czesc, jestem "+ imie);
            }
        }

        static int PotegaWhile(int a,int b)
        {
            int i = 0;
            int potega = 1;
            while (i < b)
            {
                i++;
                potega *= a;
            }
            return potega;
        }

        static int PotegaDoWhile(int a, int b)//ta metoda psuje się dla wykładnika potęgi 0 
        {
            if (b == 0)
            {
                return 1;
            }

            int i = 0;
            int potega = 1;
            //Dzieję się tak ponieważ w przeciwiestwie do while do while wykona sie przynajmniej raz. 
            //Gdyż najpierw występuje wykonanie kodu w bloku do a dopiero później sprawdzany jest warunek we while
            do
            {
                i++;
                potega *= a;
            } while (i < b);
            return potega;

        }
    }
}
