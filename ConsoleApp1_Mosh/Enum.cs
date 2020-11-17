using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Mosh
{
    //Note that since Enum is of NEW Type it has to be defined at the name space level
    //The below can be written with enum as :-
    //IMPORTANT - ENUM IS Internally an Integer
    public enum ShippingMethods
    {
        //VERY IMPORTANT
        //If the numbers are not intialised, 
        //The first value will be defaulted to 0 and followed by incrementing to 1 each

        RegularMail = 1,   //0 (By default)
        RegularAirMail =2,  //1 (By default)
        ExpressMail = 3     //2 (By default)

        // So its always suggested to initalise vales
    }
    class Enum
    {

        public static void Main(string[] args)
        {

            //Enums - Represents a set of name/value pairs (Constants)
            //Its used in places where you have number of related constants

            const int regularMail = 1;
            const int regularAirMail = 2;
            const int expressMail = 3;


        }

       


    }
}
