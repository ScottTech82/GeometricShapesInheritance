using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class Quad
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }
        public int Side4 { get; set; }

        public int Perimeter()
        {
            return Side1 + Side2 + Side3 + Side4;
        }
            //virtual is saying this can be overridden at runtime
        public virtual string Print()
        {
            return $"Side1[{Side1}], Side2[{Side2}], Side3[{Side3}], Side4[{Side4}]";
        }
         //constructor allows you to initialize the properties of new instance
        public Quad(int side1, int side2, int side3, int side4)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            Side4 = side4;
        }
    }
}
