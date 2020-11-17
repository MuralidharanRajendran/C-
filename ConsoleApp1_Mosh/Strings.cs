using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Mosh
{
    class Strings
    {

        static void main(String[] args) {

            //String formatting

            string firstName = "Murali"; //Static Class
            string LastName = "Dharan";
            string FullName = string.Format("{0} {1}", firstName, LastName);
            int num = 25; //Struct
            bool flag; //Struct
            Console.WriteLine(FullName);

            //.joint
            var arr = new int[3] { 1, 2, 3 };
            int[] array  = { 4, 5, 6 };

            string list = string.Join(";", arr);
            Console.WriteLine(list);
            Console.WriteLine(string.Join("~",array));

            //Unlike Java here strings can be indexed, but they are *********NOT IMMUTABLE***********
            Console.WriteLine(firstName[1]);

            //Escape characters
            //New Line
            Console.WriteLine("Murali\ndharan");

            //Tab sapce
            Console.WriteLine("Murali\tdharan");

            //Backslash
            Console.WriteLine("Murali\\dharan");

            //double quote
            Console.WriteLine("Murali\"dharan\"");

            Console.WriteLine("Murali'dharan'");

            //VERBATIAM STRING
            var filePath = "c:\\murali\\dharan\\file.txt";

            //The above can be instead written as
            string fp = @"c:\murali\dharan\file.txt";

            //Using String from .net frame work
            //I have used a captila S here
            //This will automatically impor the System class here - As it is coming from .NET framework
            String fromDotNet = "Hello"; //How ever it does not make any difference relative to using string
            //This is same in case of using int32
            

            //Since string is a non primitive type - you are declaring its size and its vaues
            var names = new string[3] { "Name1", "Name2", "Name3" };
            var formattedName = string.Join(",", names);
            var formattedArray = string.Join(",", array);
            Console.WriteLine(formattedName);


            //Using VERBADIAM string you need not use \t \n etc too
            var text = @"Murali
                        dharan  Rajendran";
            Console.WriteLine(text);
            








        } 
    }
}
