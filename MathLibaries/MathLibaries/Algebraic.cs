// 
// Author: Craig Baldry M203210 
// Create Date: 1/08/18
// Version Control: 1.0
//
using System;
using System.Collections.Generic;
using System.Text;

namespace MathLibaries
{
    public class Algebraic
    {
        //Returns the Square Root of a
        public static double Square(double a)
        {
            return ((double)a * a);
        }

        //Returns the Cube of a
        public static double Cube(double a)
        {
            return ((double)a * a * a);
        }

        //Returns the Multiplicative inverse of a
        public static double Inverse(double a)
        {            
            return ((double)1 / a);
        }
    }
}
