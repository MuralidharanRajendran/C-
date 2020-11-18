using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Mosh.ConditionalStatements
{
    partial class IfElse
    {

        //Tips : ctrl + W to choose an entire loop

        // 1 .If Else
        static void main(string[] args) {
            bool isGoldCustomer = true;

            //float price;
            //if (isGoldCustomer)
            //{
            //    price = 19.95f;
            //}
            //else {
            //    price = 29.98f;
            //}

            //The above if else can be written as :
            //Using conditional statement
            float price = (isGoldCustomer) ? 19.95f : 29.95f; //19.95
            Console.WriteLine(price); //19.95


            // 2 .Switch case

            var season = Seasons.Atumn;

            switch (season)
            {
                case Seasons.Atumn:
                    Console.WriteLine("Its Atumn");
                    break;

                case Seasons.Spring:
                    Console.WriteLine("Its Spring");
                    break;

                //This means in any of the below two cases the followind cw will be executed
                case Seasons.Winter:
                case Seasons.Summer:
                    Console.WriteLine("Its rither winter or summer");
                    break;

                default:
                    Console.WriteLine("None");
                    break;


            }
        }
    }
}
