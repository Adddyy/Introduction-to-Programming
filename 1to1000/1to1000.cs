using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Problem 17. Write a program that prints at the console the numbers from  1 to 1000 , each at a separate line.
//Set a breakpoint in the line, which prints the next number in the Visual Studio code editor. Run the program through the debugger using the  [F5]  key. When the debugger stops at the breakpoint trace the code execution with  [F10]  key.


    class Program
    {
            static void Main(string[] args)
        {
            Console.BufferHeight = 1001;
            for (int i = 1; i < 1001; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " ");
                }
                else
                {
                    Console.WriteLine(i * 1 + " ");
                }
            }
         }
    }

 

