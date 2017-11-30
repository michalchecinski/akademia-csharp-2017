using System;

namespace WitajcieObiekty
{
    class Program
    {
        static void Main(string[] args)
        {
            Student studentPierwszy = new Student(20, "Michał", "Chęciński", 284907);
            //studentPierwszy.Wiek = 19; //to przypisanie nie zadziała - set właściwości(property) Wiek jest ustawiona na private

            Student studentDrugi = new Student(22, "Filip", "Kapczyński", 282907);

            Console.WriteLine("Dane obiektu studentPierwszy:");
            studentPierwszy.DaneStudenta();
            Console.WriteLine(); //wypisuję pustą linię w celu czytelniejszego 
            Console.WriteLine("Dane obiektu studentDrugi:");
            studentDrugi.DaneStudenta();
            
            Console.ReadLine();

        }
    }
}
