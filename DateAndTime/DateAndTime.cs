using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Problem 14. Create a console application that prints the current date and time.
namespace DateAndTime
{
    class DateAndTime
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine(string.Format("{0:hh:mm:sstt G\\MT zz}", dt));
            Console.WriteLine(dt.ToString("dddd dd MMMM, yyyy г."));
        }
    }
}
