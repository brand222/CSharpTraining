using System;
using System.Collections.Generic;
using System.Text;

namespace SyntaxBasics
{
    class ConditionalsWhileExceptions
    {
        //static void Main(string[] args)
        //{
        //    /*
        //     *Conditonals examples
        //     * Relation Operations : > < >= <= == !=
        //     */

        //    int age = 17;
        //    if ((age >= 5) && (age <= 7))
        //    {
        //        Console.WriteLine("Go to Elementary School");
        //    }
        //    else if ((age > 7) && (age < 13))
        //    {
        //        Console.WriteLine("Go to middle school");
        //    }
        //    else if ((age > 14) && (age < 19))
        //    {
        //        Console.WriteLine("Go to highschool");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Go to college");
        //    }

        //    if ((age < 14) || (age < 19))
        //    {
        //        Console.WriteLine("You shouldnt work");
        //    }
        //    Console.WriteLine("! true = " + (!true));

        //    //ternary operator

        //    bool canDrive = age <= 16 ? true : false;

        //    //switch statement
        //    switch (age)
        //    {
        //        case 1:
        //        case 2:
        //            Console.WriteLine("Go to Day Care");
        //            break;
        //        case 3:
        //        case 4:
        //            Console.WriteLine("Go to preschool");
        //            break;
        //        case 5:
        //            Console.WriteLine("Go to kindergarten");
        //            break;
        //        default:
        //            Console.WriteLine("hello");
        //            goto OtherSchool;
        //    }

        //OtherSchool:
        //    Console.WriteLine("elementary, middle, high school");

        //    string name = "brandon";
        //    string name2 = "tom";
        //    if (name.Equals(name2, StringComparison.OrdinalIgnoreCase))
        //    {
        //        Console.WriteLine("Names are equal");
        //    }



        //    /*
        //     * Executing the while loop
        //     */
        //     //define the iterator here
        //    int i = 1;

        //    while (i <= 10)
        //    {
        //        if (i % 2 ==0)
        //        {
        //            //increment by 1
        //            i++;
        //            //jump back to the beginning of the loop to 'continue' iteration
        //            continue;
        //        }

        //        if (i == 9) break;
        //        Console.WriteLine(i);

        //        i++;
        //    }


        //    /*
        //     * do while loops
        //     */

        //    Random rnd = new Random();
        //    int secretNumber = rnd.Next(1, 11);
        //    int numberGuessed = 0;

        //    do
        //    {
        //        Console.WriteLine("Enter a number between 1 and 10");
        //        numberGuessed = Convert.ToInt32(Console.ReadLine());
        //    } while (secretNumber != numberGuessed);


        //    /*
        //     * Other coversion options:
        //     * ToBoolean, ToByte, ToChar, ToDecimal, ToDouble, ToInt64,
        //     * ToString, and they can covert from any type to another type
        //     */
        //}

    }
}
