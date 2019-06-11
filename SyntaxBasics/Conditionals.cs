using System;
using System.Collections.Generic;
using System.Text;

namespace SyntaxBasics
{
    class Conditionals
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isEvenNumber(3));
            Console.WriteLine(isEvenNumber(2));
            Console.WriteLine(isEvenNumber(14));
            Console.WriteLine(isEvenNumber(43));

            Console.WriteLine(isXGreaterThanY(2, 1));
            Console.WriteLine(isXGreaterThanY(200, 400));
        }

        //here we created a simple boolean method 
        //which contains a very basic conditional statement
        //takes in a number as a param
        public static bool isEvenNumber(int number)
        {
            //simple conditional to check it a number is divisible by 2 
            //("is the number even?")
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //here we created a simple ternary operator conditonal
        /*
         * (evaluation) ? (first statement - if true) : (second statement - if false)
         */
        public static String  isXGreaterThanY(int x, int y)
        {
            // ? (if true) : (otherwise, do this statement)
            var result = x > y ? "x is greater than y!" : "y is greater than or equal to x!";
            return result;
        }
    }
}
