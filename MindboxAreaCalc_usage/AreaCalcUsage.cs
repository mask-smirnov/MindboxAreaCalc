using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MindboxAreaCalc;

namespace MindboxAreaCalc_usage
{
    internal class AreaCalcUsage
    {
        public void run()
        {
            //простой вариант использования
            this.Test(Figure.Construct(Circle.Type(), 10));
            this.Test(Figure.Construct(Triangle.Type(), 1, 1, 1.5));

            this.Test(Figure.Construct("Circle", 20)); //Чтобы совсем точно не знать тип в compile time
            this.Test(Figure.Construct("Triangle", 3, 4, 5));

            //Пользовательское расширение - формула добавленная без модификации библиотеки
            this.Test(Figure_Ext.Construct(Square_Ext.Type(), 12));
            this.Test(Figure_Ext.Construct(Circle.Type(), 12));
            this.Test(Figure_Ext.Construct("Triangle", 12, 12, 12));

        }
        private void Test(IFigure figure)
        {
            Console.WriteLine("Фигура типа '{0}', площадь {1}", figure.GetType().Name, figure.Area());

            if (figure.GetType().Name == Triangle.Type())
                Console.WriteLine(figure.isRectangular() ? "Прямоугольный треугольник" : "Не прямоугольный треугольник");
        }
    }
}
