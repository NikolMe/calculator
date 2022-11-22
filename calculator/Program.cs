using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class UsualCalculator
    {
        public double num1;
        public double num2;

        protected internal double Sum()
        {
            return num1 + num2;
        }

        protected internal double Difference()
        {
            return num1 - num2;
        }

        protected internal double Multiplication()
        {
            return num1 * num2;
        }

        protected internal double Division()
        {
            return (num1 / num2);
        }
    }
   
    internal class EngineerCalculator : UsualCalculator
    {
        protected internal static double Log(double num)
        {
            return Math.Log(num);
        }

        protected internal static double Sqrt(double num)
        {
            return Math.Sqrt(num);
        }
    }
    
    internal class Program
    {
        //примерно набросала, потом будет полностью и по красивому
        static void Main()
        {
            Console.WriteLine("CALCULATOR \nSelect mode: \n1 - ordinary \n2 - advanced \nEnter 0 to exit.");
            string input = Console.ReadLine();
            while (input != "exit")
            {
                if (input == "1")
                {
                    string operation = Console.ReadLine();

                }
                else if (input == "2")
                {

                }
                else
                {
                    Console.WriteLine("Please, choose number.");
                }
            }
        }
    }
}
