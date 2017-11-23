using System;

namespace WitajcieObiekty
{
    public class Student
    {
        //Tylko z wewnątrz możemy ustawić te propertisy za sprawą słówka kluczowego private przy operacji set
        public int Wiek { get; private set; }
        public int NumerIndexu { get; private set; }
        public string KierunekStudiow { get; private set; }
        public string Imie { get; private set; }
        public string Nazwisko { get; private set; }

        public Student(int Wiek, string imie, string nazwisko, int numerIndexu)
        {
            this.Wiek = Wiek;
            Imie = imie;
            Nazwisko = nazwisko;
            NumerIndexu = numerIndexu;
        }

        public void UczSie()
        {
            Console.WriteLine("Uczę się!!!!");
        }


        public int ZwiekszWiek()
        {
            Wiek += 1; //Wiek = Wiek + 1 Wiek++
            return Wiek;
            //return Wiek++; //zamiast dwóch linijek powyżej można tą operację za pomocą tej jednej. W jednej linii najpierw zwiększam wiek o 1 a później zwracam tą nową wartość
        }

        public void DaneStudenta()
        {
            Console.WriteLine("Mój wiek: " + Wiek);
            Console.WriteLine("Moje imię: " + Imie);
            Console.WriteLine("Moje nazwisko: " + Nazwisko);
        }

    }
}
