using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Mosh
{
    class ReferenceAndValueTypes
    {

        //In C# we have two main types from which we build new types
        // 1. Classes
        // - Arrays, - Strings, -Custom classes
        // 2. Structures
        // - All "primitive types" are structures - Because they are small, 
        // Thats why they are dfined as structs
        // - Custom classes


        //Classes and structures behaves differently during runtime
        //Structure - called "Value types" - Memory automatically Allocated on stack, 
        //Immmediately removed when the variable is out of scope by the CLR 


        //Classes - called "Refernce Types"
        //You have to allocate the memory yourself - "new operator"
        //Memory allocated on heap - this memory is more susutainable
        //If an object goes out of scope, it continues to remain in memory for a little while
        //The garbage collection process will actually remove this


        //DEMO 
        //1. Value type
        public static void main(string[] args) {

            var a = 10;
            var b = a;
            b++;

            Console.WriteLine(string.Format("a : {0}, b: {1}",a,b));
            //Value of a = 10 - This is because here a is a value type and not referce type
            //Value of b = 11 //Here copy of that value is taken and stored in b
            // which means they are in two seperate memory location.
            // cHANGE OF ONE VALUE, DOES NOT IMPACT THE OTHER

            //2. Reference Type
            //Array is a class - which means its of reference type
            //In the stack memory we actually have the address of the memory location in heap
            //Unlike having value in case of Value type
            // Which means any change that is made to one array will impact the other

            var myarr = new int[3] { 0, 1, 2 };
            var newarr = myarr;
            myarr[0] = 15;

            foreach (var item in myarr)
            {
                Console.WriteLine(item);
            }
            // 15 1 2
            foreach (var item in newarr)
            {
                Console.WriteLine(item);
            }
            // 15 1 2

            //As you can see the value in both the arrays have changed
        }

    }
}
