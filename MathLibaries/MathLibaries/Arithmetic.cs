// 
// Author: Craig Baldry M203210 
// Create Date: 1/08/18
// Version Control: 1.0
//
using System;

namespace MathLibaries
{
    public class Arithmetic
    {
        //Returns the value of adding a and b
        public static double Add(double a, double b)
        {
            return (a + b);
        }

        //Returns the value of subtracting a with b
        public static double Sub(double a, double b)
        {
            return (a - b);
        }

        //Returns the value of dividing a with b
        public static double Div(double a, double b)
        {
            return ((double)a / b);
        }

        //Returns the value of multiplying a and b
        public static double Mult(double a, double b)
        {
            return (a * b);
        }
    }
}
