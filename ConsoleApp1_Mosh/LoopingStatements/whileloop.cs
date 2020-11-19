using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Mosh.LoopingStatements
{
    class whileloop
    {

        
        public static void main(string[] args) {


            

            while (true)
            {
                //Using break and continue
                Console.WriteLine("Enter your name : ");
                string Name = Console.ReadLine();

                if (!String.IsNullOrEmpty(Name)) {

                    Console.WriteLine(Name);
                    continue; //Loop back to the starting of while loop
                }

                break; //Break out of the while loop
            }

        }
    }
}
