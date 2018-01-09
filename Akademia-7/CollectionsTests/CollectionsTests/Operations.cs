using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsTests
{
    public class Operations
    {
        public static int Max(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        public static T Max<T>(T a, T b) where T : IComparable<T>
        {
            if (a.CompareTo(b) > 0)
                return a;
            else
                return b;
        }

    }
}
