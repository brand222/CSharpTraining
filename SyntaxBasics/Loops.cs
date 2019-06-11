using System;
using System.Collections.Generic;
using System.Text;

namespace SyntaxBasics
{
    class Loops
    {
        static void Main(string[] args)
        #region While Loop
        //here is an example of a while loop
        {
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("Now a for Loop: ");
            #region For Loop
            for (int f = 0; f <= 10; f++)
            {
                Console.WriteLine(f);
                #endregion
            }
            #endregion
            Console.WriteLine("Now a foreach loop: ");

            #region Foreach Loop
            int[] numbers = { 2, 4, 6, 8, 10 };
            foreach (int n in numbers)
            {
                Console.WriteLine(n * 2);
            }

            #endregion



        }
    }
}
