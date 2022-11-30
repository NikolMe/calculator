using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public interface IAdvanced
    {
        double Log();
        double Sqrt();
    }

    internal class AdvancedCalc : OrdinaryCalc, IAdvanced
    {
        internal AdvancedCalc()
        {
            Mode = "Advanced";
            Console.WriteLine("and an {0} calculator \n% - sqrt\n# - log \n(Example: 12 #)", Mode);

            Operation.Add('%', Sqrt);
            Operation.Add('#', Log);
        }

        public double Log()
        {
            return Math.Log(num1);
        }

        public double Sqrt()
        {
            if (num1 < 0)
            {
                Console.WriteLine("Incorrect value! It should be positiv.");
                return -1;
            }

            else return Math.Sqrt(num1);
        }
    }

}
