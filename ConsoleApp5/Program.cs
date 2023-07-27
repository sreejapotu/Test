using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("enter your first number ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your second number ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("The sum is = " + c);
            Console.ReadKey();
            //The user gets the sum of two numbers
            
        }
    }
}
