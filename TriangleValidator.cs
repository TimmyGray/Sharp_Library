using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_Library
{
    public class TriangleValidator
    {
        private double _cathet_1;
        private double _cathet_2;
        private double _hypotenuse;
        internal double Cathet_1 { get { return _cathet_1; } }
        internal double Cathet_2 { get { return _cathet_2; } }
        internal double Hypotenuse { get { return _hypotenuse; } }

        public bool IsPossibleSides(double side_1, double side_2, double side_3)
        {
            if (side_1 < side_2 + side_3 &&
                side_2 < side_1 + side_3 &&
                side_3 < side_1 + side_2)
            {
                double[] triangle_sides = new double[] {side_1, side_2, side_3};
                Array.Sort(triangle_sides);

                _cathet_1 = triangle_sides[0];
                _cathet_2 = triangle_sides[1];
                _hypotenuse = triangle_sides[2];

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsRightTriangle(Triangle triangle)
        {
            if (Math.Pow(triangle.Hypotenuse, 2) == Math.Pow(triangle.Cathet_1, 2) + Math.Pow(triangle.Cathet_2, 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
