using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Mosh.DateAndime
{
    class DateTimeTutorial
    {

        static void main(string[] args) {

            //Declaration
            //They are immutable
            var dateTime = new DateTime(2020,1,1);
            var now = DateTime.Now;
            Console.WriteLine(now);
            var hour = now.Hour;
            var min = now.Minute;
            var newhour = now.AddHours(4);
            var yesterday = now.AddDays(-1);
            var today = DateTime.Today;

            //Ways you can format your op.. There are many more ways too
            Console.WriteLine(today);
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("D"));
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:MM"));

        }
    }
}
