using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;


namespace SyntaxBasics
{
    class LoopingArraysStringBuilders
    {
        //static void Main(string[] args)
        //{
        //    //implicit typing
        //    //c# is smart enough to know that this is an integer
        //    var intVal = 1234;
        //    Console.WriteLine("intVal Type : {0}", intVal.GetType());


        //    //integer array 
        //    int[] favNums = new int[3];

        //    favNums[0] = 23;
        //    Console.WriteLine("favNum 0 : {0}", favNums[0]);



        //    //string array
        //    string[] customers = { "Bob", "Sally", "Sue" };

        //    //heres another way to create an array
        //    var employees = new[] { "Mike", "Paul", "Rick" };

        //    //object is the base type for all types in C#
        //    object[] randArray = { "Paul", 45, 1.2345 };
        //    //get data type of array item
        //    Console.WriteLine("randomArray : {0}", randArray[0].GetType());
        //    //getting array length
        //    Console.WriteLine("randomArray length: {0}", randArray.Length);
        //    //cycle through array
        //    for (int i = 0; i < randArray.Length; i++)
        //    {
        //        Console.WriteLine("Array{0} : Value : {1}", i, randArray[i]);
        //    }

        //    //multidimensional array examples
        //    string[,] custNames = new string[2, 2] { { "Bob", "Smith" }, { "Sally", "Marks" } };

        //    Console.WriteLine("D Values : {0}",
        //        custNames.GetValue(1, 1));

        //    //cycle through md arrays

        //    for (int i = 0; i < custNames.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < custNames.GetLength(1); j++)
        //        {
        //            Console.WriteLine("{0}",
        //                custNames[i, j]);
        //        }
        //        Console.WriteLine();
        //    }

        //    //foreach loop example
        //    int[] randNums = { 1, 4, 9, 2 };
        //    //sorting an array
        //    Array.Sort(randNums);
        //    //reversing an array
        //    Array.Reverse(randNums);
        //    //set a value within an array
        //    randNums.SetValue(0, 1);
        //    //searching for a particular index of an array item
        //    Console.WriteLine("1 at Index : {0}",
        //        Array.IndexOf(randNums, 1));
        //    PrintArray(randNums, "ForEach");

        //    //source array where we will copy from
        //    int[] srcArray = { 1, 2, 3 };
        //    //the destination array we will copy to
        //    int[] destinationArray = new int[2];
        //    //starting index
        //    int startInd = 0;
        //    int length = 2;
        //    //here we do the copy command on the arrays
        //    Array.Copy(srcArray, startInd, destinationArray, startInd, length);
        //    //here we can see it copied 1 and to into the destination array
        //    PrintArray(destinationArray, "Copy");

        //    //here is another way of creating an array of a specific type
        //    //as well as defining the size of the array (using CreateInstance and typeof)
        //    Array anotherArray = Array.CreateInstance(typeof
        //        (int), 10);

        //    srcArray.CopyTo(anotherArray, 5);

        //    foreach (int m in anotherArray)
        //    {
        //        Console.WriteLine("CopyTo : {0}", m);
        //    }

        //    int[] numArray = { 1, 11, 22 };
        //    //array.find finds the first item in the array which fits the criteria
        //    Console.WriteLine("> 10 : {0}", Array.Find(numArray, GreaterThan10));

        //    //array.findAll finds all the matches which fit the criteria
        //    Console.WriteLine(">10 : {0}", Array.FindAll(numArray, GreaterThan10));



        //    //string builder practice

        //    StringBuilder sb = new StringBuilder("Brandon McDOnald");
        //    Console.WriteLine("Capacity : " + sb.Capacity);
        //    StringBuilder sb2 = new StringBuilder("Effrosini Chatzistogianni");
        //    Console.WriteLine("Capacity" + sb2.Capacity);
        //    Console.WriteLine("Length" + sb.Length);

        //    sb.AppendLine("\nClay");

        //    CultureInfo enUs = CultureInfo.CreateSpecificCulture("en-US");

        //    string bestCust = "Bob Smith";
        //    sb2.AppendFormat(enUs, "Best Customer : {0}", bestCust);

        //    Console.WriteLine(sb2.ToString());

        //    sb2.Replace("Bob", "character");
        //    Console.WriteLine(sb2.ToString());

        //    sb2.Clear();

        //    sb2.Append("Random Text");

        //    Console.WriteLine(sb.Equals(sb2));

        //    sb2.Insert(11, " that's great");

        //    Console.WriteLine(sb2);

        //    //remove characters 

        //    sb2.Remove(11, 2);

        //    Console.WriteLine(sb2);





        //    /*
        //     * Casting!!!!!
        //     */

        //    long num1 = 123;
        //    int num2 = (int)num1;

        //    Console.WriteLine(num2.GetType());
        //}

        //static void PrintArray(int[] intArray, string message)
        //{
        //    foreach (int k in intArray)
        //    {
        //        Console.WriteLine("{0} : {1}", message, k);
        //    }
        //}

        //private static bool GreaterThan10(int value)
        //{
        //    return value > 10;
        //}
    }
}
