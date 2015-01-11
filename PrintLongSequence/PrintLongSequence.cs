using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Problem 16. Write a program that prints the first 1000 members of the sequence:  2, -3, 4, -5, 6, -7, … 



    class PrintLongSequence
    {
        static void Main()
        {
            for (int i = 2; i < 1001; i++) 
            { 
              if (i % 2 == 0) 
              { 
                 Console.Write(i + " "); 
               } 
              else 
               { 
                  Console.Write(i * (-1) + " "); 
               } 
            }
            Console.WriteLine();
        }
    }
