using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    public class Grade
    {
        private static long currentID = 0;
        public Grade(int value, int scale)
        {
            Id=++currentID;
            _value = value;
            _scale = scale;
        }
        public long Id { get; set; }
        private int _value;
        public int _scale;
        public int Value
        {
            get
            {
                return _value;
            }
            set
            {
                if (value >= 1 && value <= 6)
                    _value = value;
            }
        }
        public int Scale
        {
            get
            {
                return _scale;
            }
            set
            {
                if (value >= 1 && value <= 4)
                    _scale = value;
            }
        }
        public int PointsForAverage
        {
            get
            {
                return _value * _scale;
            }
        }
    }
}
