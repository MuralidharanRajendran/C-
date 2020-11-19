using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Mosh.LoopingStatements
{
    class forloop
    {

        // Continuue - Jump to the next iteration
        // Break - Jump out of the exsisting loop


        //Use for loop when you know the number of times you want to do the iteration
        //While - when you are not sure how many times you want to iterate

        public static void main(string[] args)
        {
            //Display even nos from 1-10
            for (int i = 0; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }

            //Reverse
            for (int i = 10; i >= 0; i -= 2)
            {
                Console.WriteLine(i);
            }

            //For Each

            // this also works on lists, enums, arrays ~ Any iteratables etc
            string sample = "Muralidharan Rajendran";

            foreach (var cahrs in sample)
            {
                     if (Char.IsWhiteSpace(cahrs))
                     {
                         Console.WriteLine(cahrs);
                    }
            }

            //String declaration with new key-word
            string cv = new string("Murali");
            Console.WriteLine(cv);


            //Check if a string is empty
            string chk = "";
            bool flag = string.IsNullOrEmpty(chk);
            Console.WriteLine(flag);
        }

        

        

        
    }
}
