﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class Rect : Quad //Inheriting from Quad
    {                                       // base is Quad and only need 2 sides
        public int Area()
        {
            return Side1 * Side2;
        }

        //Polymorphism -using the override string print, so it will print only 2 sides instead of all 4 sides.
        public override string Print()
        {
            return $"Side1[{Side1}], Side2[{Side2}]";
        }
        
        public Rect(int side1, int side2) : base(side1, side2, side1, side2)
        {

        }
    }

}
