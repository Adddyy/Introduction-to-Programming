using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Problem 9. Write a program that prints the first 10 members of the sequence:  2, -3, 4, -5, 6, -7, ... 


    class Sequence
    {
        static void Main()
        {
            for (int i = 2; i <= 11; i++)
            {
                int val = i % 2 == 1 ? i * -1 : i;
                Console.WriteLine(val);
            }          
        }
    }


