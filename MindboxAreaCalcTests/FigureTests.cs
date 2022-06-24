using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MindboxAreaCalc.Tests
{
    [TestClass()]
    public class FigureTests
    {
        [TestMethod()]
        public void Construct_Circle_Constructed()
        {
            IFigure c1 = Figure.Construct(Circle.Type(), 10);

            string classTypeStr = c1.GetType().Name;

            Assert.AreEqual(classTypeStr, "Circle");
        }

    }
}