using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public abstract class AbstractCalc
    {
        public string Mode { get; set; }
        public abstract double Sum();
        public abstract double Difference();

        public abstract double Multiplication();

        public abstract double Division();

    }

    internal class OrdinaryCalc : AbstractCalc
    {
        internal OrdinaryCalc() 
        {
            Mode = "Ordinary";

            Console.Write("You are using a {0} calculator ", Mode);

            Operation.Add('+', Sum);
            Operation.Add('-', Difference);
            Operation.Add('*', Multiplication);
            Operation.Add('/', Division);
        }

        public Dictionary<char, Func<double>> Operation { get; set; } = new(); //створюємо словник, де символ операції - ключ, а фукція - значення


        protected double num1;
        protected double num2;

        public double GetNum1()
        {
            return num1;
        }

        public void SetNum1(double num)
        {
            num1 = num;
        }

        public double GetNum2()
        {
            return num2;
        }

        public void SetNum2(double num)
        {
            num2 = num;
        }

        public override double Sum()
        {
            return num1 + num2;
        }

        public override double Difference()
        {
            return num1 - num2;
        }

        public override double Multiplication()
        {
            return num1 * num2;
        }

        public override double Division()
        {
            if (num2 == 0)
            {
                Console.WriteLine("Incorrect value! It should not be 0.");
                return -1;
            }
            else return (num1 / num2);
        }
    }

}
