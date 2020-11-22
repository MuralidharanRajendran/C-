using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Mosh.WorkingWithText
{
    class strings
    {
        public static void Main()
        {

            // Formatting
            // 1. ToLower()  2. ToUpper()  3. Trim() - Remove white space at beginning or at end of a string

            // Searching
            // You can serch for a character or a string
            // 1. IndexOf("Hello") 2. LastIndexOf ("Hello")

            //SubString - To create a subsring form a given string
            //1. Substring(startIndex)  ~ Till the end
            //2. Substring(startIndex, length)

            //Replacing
            //Replace('a','!')
            //Replace("mosch","murali")


            //Converting Number to String

            //int i = 1234;
            //string t = i.ToString("C");  //"$1,234.00"  -> This returns the currency value with decimal point
            //string t = i.ToString("C0");  //"$1,234"  -> This returns the currency value with no decimal point
            //Have a look at the format strings in google

            //IsNullOrWhiteSoace() -> This is the advanced and preferred method - So use this
            var sentence = "murali dharan rajendran";
            int len = sentence.Length;
            Console.WriteLine(len); //23 -> Total num of chars

            //String.join()
            //Converting string list to string using join
            var summarylis = new List<string>() { "My","Name","is","Murali"};
            var summary = String.Join(" ", summarylis);
            Console.WriteLine(summary); //My Name is Murali
        }
    }
}
