using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_Library
{
    public class Circle : Figure
    {
        private double _radius;
        public double Radius { 
            get { return _radius; }
            set { if (value < 0)
                {
                    throw new ArgumentException("Incorrect radius value");
                }
                else
                {
                    _radius = value;
                }
            }
        }
        
        internal override double Area() => Math.PI*Math.Pow(_radius, 2);
    
        public Circle(double radius) => Radius = radius;

    }
}
