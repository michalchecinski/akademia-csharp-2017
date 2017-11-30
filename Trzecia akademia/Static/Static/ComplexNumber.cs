using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public class ComplexNumber
    {
        private int RealPart;
        private int ImaginaryPart;

        public ComplexNumber(int realPart, int imaginaryPart)
        {
            RealPart = realPart;
            ImaginaryPart = imaginaryPart;
        }

        public string Get()
        {
            return $"{RealPart} + {ImaginaryPart}i";
        }

        public static string Description()
        {
            return "Jest to uporządkowana para liczb. Liczba zepsolona posiada część rzeczywistą i urojoną.";
        }
    }
}
