using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Mosh.ArraysAndList
{
    class ArraysInDepth
    {
        //Multi dimensional arrays types - "ONE SQUARE BRACKET WITH COMMA SEPERATED VALUE"
        // 1. Rectangular array - Each row has the exact same number of columns - Eg: 3*5 (5 colums in all 3 rows)

        // 1 2 3 3 3
        // 4 5 6 7 3
        // 8 9 3 3 3

        // Eg of declaring a rectangular 2d array
        //var matrix = new int [3,5]; 

        //intialising
        //var matrix = new int [3,5]
        //{
        //{1,2,3,3,3},{4,5,6,7,3},{8,9,3,3,3}
        //};

        //Accessing Num 9
        // matrix[2,1];




        // 2. Jagged arrays - Its an array of arrays - "TWO SQUARE BRACKET"

        // 1 2 3
        // 4 5 6 7
        // 8 9

        //Important - Here each element is considered as an array

        // var array = new int [3][]; 
        //3 represents number of rows
        //First [] - No of elements in your top level array

        //array[0] = new int[3]; // Since 3 Elements
        //array[1] = new int[4]; // Since 4 Elments
        //array[2] = new int[2];

        //To access number 1 
        //array[0][0];


        //Static methods can be accesses only by its class name, Not by the object created to that class
        // Array is a clas which has both static methods as well as
        //methods that can be accessed only by instantiating a object to that class

        //Demo

        public static void main(string[] args) 
        {

            inbuiltMethodsArray();


        }

        static void inbuiltMethodsArray() {


            //Declaring an array

            var numArray = new[] { 4, 5, 6, 7, 8 };

            //Array useful methods
            // 1. Array.IndexOf
            // 2.Length
            // 3.Clear -> This will clear the value and set the value to 0

            //The below mwthod will clear the values of the elements starting form index positon 1 and
            //till index position 2 set "their value to 0"

            //Clearing boolean means setting theie values to "FALSE"
            //Clearing String means setting theie values to "NULL"

            Array.Clear(numArray, 1, 2);
            //foreach (var item in numArray)
            //{
            //    Console.WriteLine(item);
            //}

            // 4. Copy method
            int[] another = new int[3];
            Array.Copy(numArray, another, 3);

            foreach (var item in another)
            {
                Console.WriteLine(item);
            }

            // 5. Sort
            // 6. Reverse

        }
    }
}
