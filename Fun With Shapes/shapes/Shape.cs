using System;

namespace shapes
{
    class Shape
    {
        // Fields
        private double _hypotenuse;
        private double _area;
        private double _perimeter;
        private int _count;

        // Constructor
        public Shape()
        {
            _hypotenuse = 0;
            _area = 0;
            _perimeter = 0;
            _count = 0;
        }

        public double Hypotenuse{ get; set; }

        public double Area{ get; set; }

        public double Perimeter{ get; set; }

        public double Count { get; set; }

        // ToString override
        public override string ToString()
        {
            return "Hypotenuse: " + decimal.Round((decimal)Hypotenuse, 
                2, MidpointRounding.AwayFromZero) + " Area: " + decimal.Round((decimal)Area,
                2, MidpointRounding.AwayFromZero) + " Perimeter: " + decimal.Round(
                    (decimal)Perimeter, 2, MidpointRounding.AwayFromZero);
        }
    }
}
