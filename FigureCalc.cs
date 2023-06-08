using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_Library
{
    public class FigureCalc : ICalc
    {
        public double AreaCalc(Figure figure) => figure.Area();
    }
}
