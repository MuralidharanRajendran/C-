using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1_Mosh.ProceduralProgramming
{
    //In CS we have a name space called system.IO - It contians
    // 1. File - static methods (Can be used for simple operations)- Security checks are done each time before accessing the methods
    //So for bigger operations its not suitable - Affects perfomance
    // FileInfo - instance methods () - Here security check is done only once while instantiating the class

    // 2. Directory - static, DirectoryInfo - instance methods

    // 3. Path
    
    class filesClass
    {
        //DEMO - Files and FileInfo

        public static void main(String[] args)
        {
            //lets create a file
            var path = @"C: \Users\mural\source\repos\C -\C -\ConsoleApp1_Mosh\WorkingWithFiles";
            _ = File.Create(@"C:\Users\mural\source\repos\C-\C-\ConsoleApp1_Mosh\WorkingWithFiles\sample.txt");

            //For fileinfo you have to create an onject
            var finfo = new FileInfo(path);
        }
    }
}

