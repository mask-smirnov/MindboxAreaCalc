using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxAreaCalc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxAreaCalc.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void Area_11Sqrt2_half()
        //треугольник со сторонами 1, 1, sqrt(2), площадь равна 1/2
        {
            Figure t1 = Figure.Construct(Triangle.Type(), 1, 1, DecimalMath.SqrtDecimal(2));

            decimal area = t1.Area();

            Assert.IsTrue(Math.Abs(area - 0.5m) <= DecimalMath.EpsilonDecimal());
        }
        [TestMethod()]
        public void Area_111_sqrt3div4()
        //треугольник со сторонами 1, 1, 1, площадь равна sqrt(3)/4
        {
            Figure t1 = Figure.Construct(Triangle.Type(), 1, 1, 1);

            decimal area = t1.Area();

            Assert.IsTrue((area - DecimalMath.SqrtDecimal(3m) / 4m) <= DecimalMath.EpsilonDecimal());
        }

        [TestMethod()]
        public void isRectangular_345_rect()
        {
            Figure t1 = Figure.Construct(Triangle.Type(), 3, 4, 5);

            bool isRect = t1.isRectangular();

            Assert.AreEqual(isRect, true);
        }
        [TestMethod()]
        public void isRectangular_111_NotRect()
        {
            Figure t1 = Figure.Construct(Triangle.Type(), 1, 1, 1);

            bool isRect = t1.isRectangular();

            Assert.AreEqual(isRect, false);
        }
        [TestMethod()]
        public void isRectangular_10E27_Exception()
        {
            Figure t1 = Figure.Construct(Triangle.Type(), 1E27m, 1, 1);
            bool overflow = false; 

            try
            {
                bool isRect = t1.isRectangular();
            }
            catch (System.OverflowException)
            {
                overflow = true;
            }

            Assert.AreEqual(overflow, true);
        }

    }
}