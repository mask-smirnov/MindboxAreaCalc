using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MindboxAreaCalc;

namespace MindboxAreaCalc_usage
{
    //Пример добавления пользователем своей фигуры
    internal class Square_Ext : Figure
    {
        decimal sideLen;
        public Square_Ext(decimal _sideLen)
        {
            this.sideLen = _sideLen;
        }
        public override decimal Area()
        {
            return sideLen * sideLen;
        }
        public static string Type()
        {
            return typeof(Square_Ext).Name;
        }
        public override bool isRectangular()
        {
            throw new Exception("Не применимо для квадрата");
        }
    }

    public class Figure_Ext
    {
        public static IFigure Construct(string _type, decimal _dimension1, decimal _dimension2 = 0, decimal _dimension3 = 0)
        {
            switch (_type)
            {
                case string t when t == Square_Ext.Type(): return new Square_Ext(_dimension1);
            }

            return Figure.Construct(_type, _dimension1, _dimension2, _dimension3);
        }
        public static IFigure Construct(string _type, int _dimension1, int _dimension2 = 0, int _dimension3 = 0)
            => Figure_Ext.Construct(_type, (decimal)_dimension1, (decimal)_dimension2, (decimal)_dimension3);
        public static IFigure Construct(string _type, float _dimension1, float _dimension2 = 0, float _dimension3 = 0)
            => Figure_Ext.Construct(_type, (decimal)_dimension1, (decimal)_dimension2, (decimal)_dimension3);
        public static IFigure Construct(string _type, double _dimension1 = 0, double _dimension2 = 0, double _dimension3 = 9)
            => Figure_Ext.Construct(_type, (decimal)_dimension1, (decimal)_dimension2, (decimal)_dimension3);

    }
}
