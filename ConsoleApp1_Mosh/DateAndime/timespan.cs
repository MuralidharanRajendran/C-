using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Mosh.DateAndime
{
    class timespan
    {

        public static void main(string[] args) 
        {
            //Time span is used to represent length of time
            var timespan = new TimeSpan(12,59,59); //(h,m,s)

            //Difference between start and end date returns a time span
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2.5);

            var diff = end - start;
            Console.WriteLine(diff); //00:02:30.0070041
        }
    }
}
