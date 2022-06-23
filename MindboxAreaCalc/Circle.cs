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
            return DecimalMath.PI * Radius * Radius;
        }
        public override bool isRectangular()
        {
            throw new Exception("Не применимо для окружности");
        }

        public static string Type()
        {
            return typeof(Circle).Name;
        }        
    }
}
