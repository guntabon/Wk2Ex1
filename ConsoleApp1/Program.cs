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
            //This line Informs the user what the program is for
            Console.WriteLine("Interest Calculator Program");
            //This line asks for the principal loan amount
            Console.WriteLine("What is the principal amount of the loan in dollars?");
            //Initializes the int myPrin as user input, converted to an int vallue
            int myPrin = Convert.ToInt32(Console.ReadLine());
            //This prompts the user to enter interest rate
            Console.WriteLine("What is the interest rate?");
            //Converts user input into a double called myRate
            double myRate = Convert.ToDouble(Console.ReadLine());
            //Asks for the period of time the loan is
            Console.WriteLine("What is the period of loan in years?");
            //Converts user input into an int named period
            int period = Convert.ToInt32(Console.ReadLine());
            //Initializes totalInterest double as myPrin * myRate * period
            double totalInterest = Convert.ToDouble(myPrin * myRate * period);
            //Informs the user of the total interest
            Console.WriteLine($"Total interest of Loan: {totalInterest}");


        }
    }
}
