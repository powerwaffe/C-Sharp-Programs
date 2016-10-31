using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    class Circle
    {
        // Fields
        private double _area;
        private double _circumference;
        private int _count;

        // Constructor
        public Circle()
        {
            _area = 0;
            _circumference = 0;
            _count = 0;
        }

        public double Area { get; set; }

        public double Circumference { get; set; }

        public int Count { get; set; }

        // ToString override
        public override string ToString()
        {
            return "Area: " + decimal.Round((decimal)Area,
                2, MidpointRounding.AwayFromZero) + " Circumference: " + decimal.Round(
                    (decimal)Circumference, 2, MidpointRounding.AwayFromZero);
        }
    }
}
