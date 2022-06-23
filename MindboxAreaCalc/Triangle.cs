using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxAreaCalc
{
    public class Triangle : Figure
    {
        decimal sideA, sideB, sideC;
        public override decimal Area()
        {
            decimal halfPerimeter = (sideA + sideB + sideC) / 2m;

            return 0;// Math.Sqrt() 
        }
    }
}
