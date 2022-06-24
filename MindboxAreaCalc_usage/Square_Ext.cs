using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MindboxAreaCalc;

namespace MindboxAreaCalc_usage
{
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

        public override bool isRectangular()
        {
            throw new NotImplementedException();
        }
    }
}
