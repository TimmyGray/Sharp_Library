using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_Library
{
    public class Triangle : Figure
    {

        private double _cathet_1;
        private double _cathet_2;
        private double _hypotenuse;

        public double Cathet_1 { 
            get { return _cathet_1; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Incorrect value for Cathet_1");
                }
                _cathet_1 = value;
            }
        }

        public double Cathet_2 { 
            get { return _cathet_2; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Incorrect value for Cathet_2");
                }
                _cathet_2 = value;
            }
        }

        public double Hypotenuse { 
            get { return _hypotenuse; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Incorrect value for Hypotenuse");
                }
                _hypotenuse = value;
            }
        }

        internal override double Area() => Math.Sqrt(HalfPerimetr()*(HalfPerimetr()-_cathet_1)*(HalfPerimetr()-_cathet_2)*(HalfPerimetr()-_hypotenuse));

        internal double HalfPerimetr() => (_cathet_1+_cathet_2+_hypotenuse)/2;


        public Triangle(double side_1, double side_2, double side_3)
        {
            TriangleValidator validator = new TriangleValidator();

            if (validator.IsPossibleSides(side_1,side_2,side_3))
            {
                _cathet_1 = validator.Cathet_1;
                _cathet_2 = validator.Cathet_2;
                _hypotenuse = validator.Hypotenuse;
            }
            else { throw new InvalidDataException("Incorrect values of triangle sides"); }
    
        }


    }
}
