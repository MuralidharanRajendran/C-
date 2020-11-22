using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Mosh.DateAndime
{
    class Debugging
    {
        // Ctrl + F5 -> To run your code in normal mode
        // F9 To set a debug point F9
        // F5 run in debug mode
        // F10 to step over - We execute one line at a time
        // You can drag the yellow pointer with your mouse and move the pointer back to your debugpoint
        // F11 -> Step into - To go into the submethod
        // Shift + F11 to stepout of the sub method
        // Shift + F5 to stop the debug mode
        // Ctrl + Shift +f5 -> Stop from Debug mode and restart execution in non debug mode
        // F5 will take you to the next debug point
        // Disable/Enable/List/Delete the break points Debug-> Windows -> breakpoints

        //The watch window
        //Debug -> Windows -> Watch -> Watch1 -> It allows you to add the variables that you wanted to watch
        // So the next time you need not hover your mouse over the variable which you need to watch
        // VERY USEFUL


        //Locals and autos window
        //Debug-> Windows -> autos  ------> The best
        //Its like a watch window but with automatic list of variables

        //Debug-> Windows -> locals


        //SIDE EFFECTS -> Your method is being affected by someother factor (Eg: Removing a number of elements in a list)
        //This makes the method un reliable
        //For this reason we create a copy of the original list and work on the copied list. This list is generally called the buffer
        //This will remove the side effect
        //This is the best practice


        //See below method how to copy a list 
        static void method()
        {
            //Copying a list

            //Copying a list
            var ogLis = new List<int>() { 1, 2, 3 };
            var buffer = new List<int>(ogLis);

          //if (count > list.count)
            throw new ArgumentOutOfRangeException("count","You have entered an invalid count");
            throw new ArgumentNullException("count", "You have entered a null list");
        }

        //Defensive programming
        // Raising exceptions
        // If a user wants to find 3 smallest numbers out of given 2 numbers - Its not a vaild input
        // In this case we raise exceptions
        // So we have to chk the IP first before processing
        //throw new Argument - See line 44


        //Call stack window
        //Debug-> Windows -> Call stack
        //This shows the prder of methods that were called from the time you started until the point ypu are currently in


       

    }
}
