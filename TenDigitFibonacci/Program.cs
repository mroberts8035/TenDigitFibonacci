using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenDigitFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setting up the first few numbers of the sequence and the formula
            int a = 0, b = 1, c = (a + b);
            //Adding it into a typed list so that the list can be expanded
            List<int> FibValues = new List<int>() { a, b, c, };

            //Adding numbers to the FibValues list until the first value that creates 10 digits because the number is added to the list after the last loop. 
            do
            {
                a = b;
                b = c;
                c = a + b;
                FibValues.Add(c);
            } while (c.ToString().Length < 10);

            //This for each loop is to test what I'm adding to the list.
            //foreach (var i in FibValues)
            //{
            //    Console.WriteLine(i);
            //}


            //print the answer in the console            
            Console.WriteLine($"The index of the first Fibonacci value to contain 10 digits is {(FibValues.Count - 1)}.\nThat Fibonacci value is {(FibValues[(FibValues.Count - 1)]):n0}.");
        }
    }
}
