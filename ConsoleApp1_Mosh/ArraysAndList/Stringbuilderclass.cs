using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Mosh.ArraysAndList
{

    // By default strings are immutable
    //String builder will help you to work with string manupulation
    //Not for searching
    //This dont create a new copy of string - it will mutate the already exsisting string
    // So StringBuilder is preferred.


    //Append , Insert, Remove, Replace, Clear, Insert ...
    class Stringbuilderclass
    {

         static void main(string[] args)
        {
            // String builder declaration
            var obj = new StringBuilder();

            // it also allows you to chain the commands
            obj.Append('-', 10)
            .AppendLine("otha")
            .Append("dei")
            .Replace('d', '$');
            Console.WriteLine(obj);

        }
    }
}
