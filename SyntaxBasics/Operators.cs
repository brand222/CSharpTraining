using System;
using System.Collections.Generic;
using System.Text;

namespace SyntaxBasics
{
    class Operators
    {
        static void Main(string[] args)
        {
            /*
             * Addition: +
             * Multiplication: *
             * Subtraction: -
             * Division: /
             * Modulus: %
             */

            var product = 5 * 5; //should be 25
            var added = 5 + 5; // should be 10
            var subtracted = 5 - 5; //should be 0
            var divided = 5 / 5; //should be 1
            //**work on this one more**
            //var remainder = 15 % 3; // should be 2

            Console.WriteLine("Product = " + product);
            Console.WriteLine("Sum = " + added);
            Console.WriteLine("Subtracted = " + subtracted);
            Console.WriteLine("Divided = "  + divided);
            // Console.WriteLine("Modulus = " + remainder);

            //absolute value example - Math.abs
            Console.WriteLine("Absolute value of -10 is: " + Math.Abs(-10));

            //Raising something up with an exponent
            //Math.Pow(5, 2) <- this means '5' to the 2nd power (2)
            Console.WriteLine("5 to the power of 2 is: " + Math.Pow(5, 2));

            //rounding a number (basic rounding rules)
            Console.WriteLine("5.2 rounded equals: " + Math.Round(5.2));

            //getting floor value of a number (rounding down)
            Console.WriteLine("Rounding 5.2 down = " + Math.Floor(5.2));

            //getting ceiling value of a number (rounding up)
            Console.WriteLine("Rounding 5.2 up = " + Math.Ceiling(5.2));






        }
    }
}
