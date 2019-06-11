using System;
using System.Collections.Generic;
using System.Text;

namespace SyntaxBasics
{
    class DateTimePractice
    { 
        static void Main(string[] args)
        {
            //this prints the current date/time
            Console.WriteLine("Current date/time is : " + DateTime.Now);
            //create a variable which stores your birthday
            var birthday = new DateTime(1990, 04, 16);
            // here we create a variable which stores the 
            //difference between today's date and your birthday
            var difference = DateTime.Now - birthday;
            Console.WriteLine(difference);

            //create an new datetime
            var someTime = new DateTime(2017, 10, 18, 9, 51, 32);
            //this adds minutes to the time to go into the future
           Console.WriteLine(someTime.AddMinutes(134));
            //adding days, hours, miliseconds etc...
            // you can also subtract time...

            someTime.AddMinutes(-30);

        }
    }
}
