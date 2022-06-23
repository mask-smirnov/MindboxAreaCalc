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
    public class DecimalMathTests
    {
        [TestMethod()]
        public void Epsilon__moreThan0()
        {
            decimal epsilon = DecimalMath.EpsilonDecimal();

            Assert.IsTrue(epsilon > 0);
        }
        [TestMethod()]
        public void SqrtDecimal_1_1()
        {
            decimal x = 1m;

            decimal ret = DecimalMath.SqrtDecimal(x);

            Assert.AreEqual(ret, 1m);
        }
        [TestMethod()]
        public void SqrtDecimal_777_SmallDiff()
        {
            decimal x = 777m;

            decimal ret = DecimalMath.SqrtDecimal(x);

            Assert.IsTrue(Math.Abs(ret * ret - x) <= DecimalMath.EpsilonDecimal()*100);
        }
    }
}