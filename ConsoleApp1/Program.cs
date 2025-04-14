using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interest Calculator Program");

            Console.WriteLine("What is the principal amount of the loan in dollars?");

            int myPrin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the interest rate?");

            double myRate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the period of loan in years?");

            int period = Convert.ToInt32(Console.ReadLine());

            double totalInterest = Convert.ToDouble(myPrin * myRate * period);

            Console.WriteLine($"Total interest of Loan: {totalInterest}");


        }
    }
}
