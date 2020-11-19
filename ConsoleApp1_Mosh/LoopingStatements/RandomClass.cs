using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Mosh.LoopingStatements
{
    class RandomClass
    {
        public static void Main(string[] args)
        {

            var random = new Random();

            //Generating a set of random numbers
            for (int i = 0; i < 10; i++)
            {
                var randint = random.Next(); //It has got three overloads
               // Console.WriteLine(randint);
            }

            //see how you case an alphabet to number
            var op = (int)'a';
            //Console.WriteLine(op); //97 - ASCII value of a

            //var opt = Convert.ToInt32("Raj");
            //Console.WriteLine(opt);

            //Generating a random password
            //ASCII value of a - 97
            //ASCII value of z - 122

            //suppose you want to generate a 10 char password

            var pass = "";

            for (int i = 0; i <=10; i++)
            {
               //Cast the integers to characters to generate a string for you password
               // pass += (char)random.Next(97, 122);

                //instead of passing the ascii values - we know english alphabets contain 26 characters

                pass += (char)('a' + random.Next(0, 26));
                //Here 'a' represents 97 ~ So it generates from 97 to 122 Charac string
            }
           
            Console.WriteLine("password : " + pass);

        }
    }
}
