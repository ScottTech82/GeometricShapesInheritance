using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class Sqr : Rect
    {
       
        public override string Print()
        {
            return $"Side1[{Side1}]";
        }

          //constructor using same property variable, using this.in front.
        public Sqr(int Side1) : base(Side1, Side1)
        {
            
        }
    }
}
