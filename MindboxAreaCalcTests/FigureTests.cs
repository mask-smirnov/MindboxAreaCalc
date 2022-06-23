﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxAreaCalc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxAreaCalc.Tests
{
    [TestClass()]
    public class FigureTests
    {
        [TestMethod()]
        public void Construct_Circle_Constructed()
        {
            Figure c1 = Figure.Construct(Circle.Type(), 10);

            string classTypeStr = c1.GetType().Name;

            Assert.AreEqual(classTypeStr, "Circle");
        }
        [TestMethod()]
        public void SqrtDecimal_1_1()
        {
            decimal x = 1m;

            decimal ret = MindboxAreaCalc.DecimalMath.SqrtDecimal(x);

            Assert.AreEqual(ret, 1m);
        }
    }
}