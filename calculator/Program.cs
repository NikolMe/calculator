using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
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
