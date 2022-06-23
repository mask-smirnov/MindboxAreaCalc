namespace MindboxAreaCalc
{
    public abstract class Figure
    {
        public abstract decimal Area();
        public abstract bool isRectangular();

        public static Figure Construct(string _type, decimal _dimension1) //конструктор фигур с одним параметром
        {
            switch (_type)
            {
                case string t when t == Circle.Type() : return new Circle(_dimension1);
            }

            throw new Exception(String.Format("Type {0} is not supported", _type));
        }

        public static Figure Construct(string _type, int _dimension1) 
            => Figure.Construct(_type, (decimal)_dimension1);
        public static Figure Construct(string _type, float _dimension1) 
            => Figure.Construct(_type, (decimal)_dimension1);
        public static Figure Construct(string _type, double _dimension1) 
            => Figure.Construct(_type, (decimal)_dimension1);

        public static Figure Construct(string _type, decimal _dimension1, decimal _dimension2, decimal _dimension3) //конструктор фигур с тремя параметрами
        {
            switch (_type)
            {
                case string t when t == Triangle.Type(): return new Triangle(_dimension1, _dimension2, _dimension3);
            }

            throw new Exception(String.Format("Type {0} is not supported", _type));
        }
        public static Figure Construct(string _type, int _dimension1, int _dimension2, int _dimension3) 
            => Figure.Construct(_type, (decimal)_dimension1, (decimal)_dimension2, (decimal)_dimension3);
        public static Figure Construct(string _type, float _dimension1, float _dimension2, float _dimension3)
            => Figure.Construct(_type, (decimal)_dimension1, (decimal)_dimension2, (decimal)_dimension3);
        public static Figure Construct(string _type, double _dimension1, double _dimension2, double _dimension3)
            => Figure.Construct(_type, (decimal)_dimension1, (decimal)_dimension2, (decimal)_dimension3);

    }
}