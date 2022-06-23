using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxAreaCalc
{
    public class Circle : Figure
    {
        public decimal Radius; 

        public Circle(decimal _radius)
        {
            Radius = _radius;
        }

        public override decimal Area()
        {
            return ((decimal) Math.PI) * Radius * Radius;
        }

        public static string Type()
        {
            return typeof(Circle).Name;
        }        
    }
}
