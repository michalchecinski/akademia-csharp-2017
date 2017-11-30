using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //SimpleStatic.MethodStatic();

            string complexDesc = ComplexNumber.Description();
            Console.WriteLine(complexDesc);

            ComplexNumber complexNumber = new ComplexNumber(2,5);

            string complexNumberString = complexNumber.Get();
            Console.WriteLine(complexNumberString);
        }
    }
}
