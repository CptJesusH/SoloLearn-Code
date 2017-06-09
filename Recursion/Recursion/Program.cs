using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static double Fact(double num)
        {
            if(num == 1.0)
            {
                return 1;
            }
            return num * Fact(num - 1.0);
        }
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter a number to calculate its factorial.");
                double userInput = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine(Fact(userInput));
            }
        }
    }
}
