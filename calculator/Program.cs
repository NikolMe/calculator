using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {

        static void Main()
        {
            Console.WriteLine("CALCULATOR \nSelect mode: \n1 - ordinary \n2 - advanced \nEnter 0 to exit.");
            string input = Console.ReadLine().Trim();

            while (input != "0")
            {
                try
                {
                    if (input == "1")
                    {
                        AbstractCalc calc = new OrdinaryCalc();
                        Console.WriteLine();
                        while (true) //для виходу з циклу слугує блок if
                        {
                            Console.Write("Enter operation: ");
                            input = Console.ReadLine().Trim();

                            if (input.Length == 1) { break; } //якщо користувач ввів номер команди

                            var numbers = input.Split(' ');

                            calc.SetNum1(double.Parse(numbers[0]));
                            calc.SetNum2(double.Parse(numbers[2]));
                            Console.WriteLine(calc.Operation[char.Parse(numbers[1])]()); //зі словнику викликаємо відповдний метод
                        }
                    }

                    else if (input == "2")
                    {
                        IAdvanced calc = new AdvancedCalc();
                        Console.WriteLine();
                        while (true)
                        {
                            Console.Write("Enter operation: ");
                            input = Console.ReadLine().Trim();

                            if (input.Length == 1) { break; } //якщо користувач ввів номер команди

                            var numbers = input.Split(' ');

                            ((AbstractCalc)calc).SetNum1(double.Parse(numbers[0]));
                            if (numbers.Length > 2) { ((AbstractCalc)calc).SetNum2(double.Parse(numbers[2])); }
                            
                            Console.WriteLine(((AbstractCalc)calc).Operation[char.Parse(numbers[1])]()); //зі словнику викликаємо відповідний метод
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please, choose number.");
                        input = Console.ReadLine().Trim();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong data. Choose mode:");
                    input = Console.ReadLine().Trim(); 
                }
            }

            Console.WriteLine("Bye!");
        }
    }
}
