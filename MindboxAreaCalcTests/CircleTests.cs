using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MindboxAreaCalc.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void Area_DecimalRadius_CorrectValue()
        //радиус decimal
        {
            IFigure c1 = Figure.Construct(Circle.Type(), 10m);

            decimal area = c1.Area();

            Assert.AreEqual(area, DecimalMath.PI * 10m * 10m);
        }
        [TestMethod()]
        public void Area_intRadius_CorrectValue()
        //радиус int
        {
            IFigure c1 = Figure.Construct(Circle.Type(), 10);

            decimal area = c1.Area();

            Assert.AreEqual(area, DecimalMath.PI * 10m * 10m);
        }
        [TestMethod()]
        public void Area_floatRadius_CorrectValue()
        //радиус float
        {
            float radius = .12344F;
            IFigure c1 = Figure.Construct(Circle.Type(), radius);

            decimal area = c1.Area();

            Assert.AreEqual(area, DecimalMath.PI * (decimal)radius * (decimal)radius);
        }
        [TestMethod()]
        public void Area_doubleRadius_CorrectValue()
        //радиус double
        {
            IFigure c1 = Figure.Construct(Circle.Type(), (double).1m);

            decimal area = c1.Area();

            Assert.AreEqual(area, DecimalMath.PI * 0.1m * 0.1m);
        }


        [TestMethod()]
        public void getType__ReturnsCircle()
        {
            String str = Circle.Type();

            Assert.AreEqual(str, "Circle");
        }
        [TestMethod()]
        public void isRectangular__Exception()
        {
            IFigure t1 = Figure.Construct(Circle.Type(), 1);
            bool exception = false;

            try
            {
                bool isRect = t1.isRectangular();
            }
            catch 
            {
                exception = true;
            }

            Assert.AreEqual(exception, true);
        }
    }
}