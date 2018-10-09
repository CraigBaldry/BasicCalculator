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
    public class Trigonometric
    {
        //Returns the tangent of specified angle
        public static double Tan(double angle)
        {
            double radians = angle * (Math.PI / 180);
            return (Math.Tan(radians));
        }

        //Returns the sine of a specified angle
        public static double Sine(double degrees)
        {
            double angle = (Math.PI / 180) * degrees;

            return (Math.Sin(angle));
        }

        //Returns the cos of a specified angle
        public static double Cos(double degrees)
        {
            double angle = (Math.PI *degrees) / 180;

            return (Math.Cos(angle));
        }
    }
}
