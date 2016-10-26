using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    class Shape
    {
        // Fields
        private double _hypotenuse;
        private double _area;
        private double _perimeter;

        // Constructor
        public Shape()
        {
            _hypotenuse = 0;
            _area = 0;
            _perimeter = 0;
        }

        public double Hypotenuse{ get; set; }

        public double Area{ get; set; }

        public double Perimeter{ get; set; }

        // ToString override
        public override string ToString()
        {
            return "Hypotenuse: " + Hypotenuse + " Area: " + Area +
                " Perimeter: " + Perimeter;
        }
    }
}
