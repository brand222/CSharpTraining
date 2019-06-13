using System;
using System.Collections.Generic;
using System.Text;

namespace SyntaxBasics
{
    class MethodsEnum
    {
        static void Main(string[] args)
        {
            //pass by value vs value by reference
            double x = 5;
            double y = 4;
            Console.WriteLine("5 + 4 = {0}",
                GetSum(x, y));

            Console.WriteLine("x {0}", x);


            int solution;
            DoubleIt(15, out solution);
            Console.WriteLine(solution);


            //call the reference variable
            int num1 = 10;
            int num2 = 20;

            Console.WriteLine("Before Swap num1 : {0} num2 : {1}", num1, num2);

            Swap(ref num1, ref num2);


            Console.WriteLine("1 + 2 + 3 = {0}", getSumMore(1, 2, 3));

        }


        //here we are taking in a variable number of parameters and returng a result
        static double getSumMore(params double[] nums)
        {
            double sum = 0;
            foreach(int i in nums)
            {
                sum += i;
            }
            return sum;
        }

        public static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        private static void DoubleIt(int v, out int solution)
        {
            solution = v * 2;
        }

        //simple method example
        static double GetSum(double x = 1, double y = 1)
        {
            double temp = x;
            x = y;
            y = temp;
            return x + y;
        }
    }
}
