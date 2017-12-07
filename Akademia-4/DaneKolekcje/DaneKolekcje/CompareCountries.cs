using System;
using System.Collections.Generic;
using System.Text;

namespace DaneKolekcje
{
    class CompareCountries : IComparer<Country>
    {
        public int Compare(Country x, Country y)
        {
            if (x.Population > y.Population)
                return 1;
            else if (x.Population < y.Population)
                return -1;
            else
                return 0;
        }
    }
}
