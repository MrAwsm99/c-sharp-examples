using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            string fname = "john";
            string lname = "doe";
            string fullname = $"hello {fname} {lname}"

            //Task 2
            int a;
            Console.WriteLine("Enter a Number");
            a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");

            //Task 3
            int n, number, fact = 1;
            Console.WriteLine("Enter a number");
            number = int.Parse(Console.Readline());
            for (n = 1; n < number, n++)
            {
                fact = fact * n; 
            }
            Console.WriteLine(fact);
        
        }
    }
}
