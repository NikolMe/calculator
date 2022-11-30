using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class UsualCalculator
    {
        internal UsualCalculator()
        {
            Console.Write("You are using a usual calculator");
        }
        
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
            if (num2 == 0)
            { 
              Console.WriteLine("Incorrect value! It should not be 0.");
              return -1; 
            }
            else return (num1 / num2);
        }
    }
   
    internal class EngineerCalculator : UsualCalculator
    {
        public double num;
        
        internal EngineerCalculator()
        {
            Console.WriteLine("and an engineer calculator");
        }
        
        protected internal double Log()
        {
            return Math.Log(num);
        }

        protected internal double Sqrt()
        {
           if (num < 0)
            {
                Console.WriteLine("Incorrect value! It should be positiv");
                return -1;
            }
            
            else return Math.Sqrt(num);
        }
    }
    
    internal class Program
    {
        //просто накидала, в конце будет полностью и по красивому
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
