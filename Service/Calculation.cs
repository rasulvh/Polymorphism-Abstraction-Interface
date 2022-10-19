using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class Calculation : ICalculation
    {
        public void Calculate()
        {
            int result;
            Console.WriteLine("1-ci ededi daxil edin:");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Etmek istediyiniz emeli daxil edin -----> '+' '-' '*' '/'");
            string operation = Console.ReadLine();
            Console.WriteLine("2-ci ededi daxil edin:");
            int num2 = Int32.Parse(Console.ReadLine());

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine("Cavab: " + result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine("Cavab: " + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine("Cavab: " + result);
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine("Cavab: " + result);
                    break;
                default:
                    Console.WriteLine("Duzgun daxil edin");
                    break;
            }
        }
    }
}
