namespace MindboxAreaCalc
{
    public abstract class Figure
    {
        public abstract decimal Area();
        public static Figure Construct(string _type, decimal _dimension1) //конструктор фигур с одним параметром
        {
            switch (_type)
            {
                case string t when t == Circle.Type() : return new Circle(_dimension1);
            }

            throw new Exception(String.Format("Type {0} is not supported", _type));
        }

        public static Figure Construct(string _type, int _dimension1) => Figure.Construct(_type, (decimal)_dimension1);
        public static Figure Construct(string _type, float _dimension1) => Figure.Construct(_type, (decimal)_dimension1);
        public static Figure Construct(string _type, double _dimension1) => Figure.Construct(_type, (decimal)_dimension1);


    }
}