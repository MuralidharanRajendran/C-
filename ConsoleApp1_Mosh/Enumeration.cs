using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Mosh
{
    //Note that since Enum is of NEW Type it has to be defined at the name space level
    //The below can be written with enum as :-
    //IMPORTANT - ENUM IS Internally an Integer
    public enum ShippingMethods : byte   //Here byte means : Since by default enum is an integer, 
        //You can actuallty type cast it into byte for your convinence if needed
    {
        //VERY IMPORTANT
        //If the numbers are not intialised, 
        //The first value will be defaulted to 0 and followed by incrementing to 1 each

        RegularMail = 1,   //0 (By default)
        RegularAirMail =2,  //1 (By default)
        ExpressMail = 3     //2 (By default)

        // So its always suggested to initalise vales
    }

    

    class Enumeration
    {

        public static void main(string[] args)
        {

            //Enums - Represents a set of name/value pairs (Constants)
            //Its used in places where you have number of related constants

            //The below looks complicated, the same can be made simpler with the help of Enums
            //See above
            const int regularMail = 1;
            const int regularAirMail = 2;
            const int expressMail = 3;

            //Usin the Enum
            var shipmethod = ShippingMethods.ExpressMail;
            Console.WriteLine(shipmethod); //ExpressMail
            //you can cast the above to integer or byte to see the corresponding integer for that type
            Console.WriteLine((byte)shipmethod); //3

            //Converting integer/Byte to corresponding Enum value
            var num = 3;
            Console.WriteLine((ShippingMethods)(num)); //ExpressMail

            //Convering to string
            //All objects in c# have tostring method
            Console.WriteLine(shipmethod.ToString());
            //Console.WriteLine always displays its output in the form of string
            //Which means by default .ToString() method is called



            //********************IMPORTANT***********************************
            //Converting String to ENUM - This can be done by parsing
            //Parsing means getting a string and converting it to a different type
            var tobeAddedtoEnumList = "ExpressMail";

            //Since the return type of this method is an object - You have to cast it to the Enum Name

            var ship = (ShippingMethods)Enum.Parse(typeof(ShippingMethods), tobeAddedtoEnumList);

            //What is Type in C# - Type is a class in .NET that represents metadata about other types
            //Whenever you see this Type in tool tip - u can use the typeOf() operator

            Console.WriteLine(ship); //ExpressMail

            //Assume you are getting the below string as an input, you have to map it to our
            //Enum to get the rite outpuy
            //Repeating the same practice
            var practice = "RegularAirMail";
            //Using parse
            var toadd = (ShippingMethods)Enum.Parse(typeof(ShippingMethods), practice);
            Console.WriteLine(toadd); //RegularAirMail
        }




    }
}
