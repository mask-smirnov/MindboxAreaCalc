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
        public Triangle(decimal sideA, decimal sideB, decimal sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB; 
            this.sideC = sideC;
        }
        public override decimal Area()
        {
            decimal halfPerimeter = (sideA + sideB + sideC) / 2m;

            return DecimalMath.SqrtDecimal(    halfPerimeter 
                                            * (halfPerimeter - sideA)
                                            * (halfPerimeter - sideB)
                                            * (halfPerimeter - sideC));
        }
        public override bool isRectangular()
        {
            //В прямоугольном треугольнике выполняется теорема Пифагора
            //Существует сторона, квадрат которой равен сумме квадратов двух других сторон
            //Такая проверка по-любому быстрее, чем считать арксинусы
            decimal a2 = sideA * sideA;
            decimal b2 = sideB * sideB;
            decimal c2 = sideC * sideC;

            if ((Math.Abs(a2 - b2 - c2) <= DecimalMath.EpsilonDecimal()) ||
                (Math.Abs(b2 - c2 - a2) <= DecimalMath.EpsilonDecimal()) ||
                (Math.Abs(c2 - a2 - b2) <= DecimalMath.EpsilonDecimal()))
                return true;

            return false;
        }
        public static string Type()
        {
            return typeof(Triangle).Name;
        }

    }
}
