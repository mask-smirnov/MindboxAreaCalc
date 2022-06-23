namespace MindboxAreaCalc
{
    public static class DecimalMath
    {
        public const decimal PI = 3.141592653589793238462643383279m;

        public static decimal EpsilonDecimal()
        {
            return (decimal)(1 / Math.Pow(10, 28)); //допустимая погрешность
        }

        //Нахождение квадратного корня методом касательных Ньютона
        //См. https://math.mit.edu/~stevenj/18.335/newton-sqrt.pdf
        //Math.Sqrt() работает только с double
        public static decimal SqrtDecimal(decimal x)
        {
            if (x < 0) throw new OverflowException("Cannot calculate square root from a negative number");

            decimal current = (decimal)Math.Sqrt((double)x); //сначала вычисляем грубо в double
            decimal previous;
            do
            {
                previous = current;
                if (previous == 0.0M) return 0;
                current = (previous + x / previous) / 2m;
            }
            while (Math.Abs(previous - current) > DecimalMath.EpsilonDecimal());
            return current;
        }
    }
}