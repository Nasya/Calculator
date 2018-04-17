using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {   
        static void Main(string[] args)
        {
            Calculation calc = new Calculation();
            InOut inOut = new InOut();
            inOut.InputValue();

            switch (inOut.StringOperation)
            {
                case "+":
                case "addition":
                    calc.Add(inOut.FirstNumber, inOut.SecondNumber);
                    break;
                case "-":
                case "subtraction":
                    calc.Subtract(inOut.FirstNumber, inOut.SecondNumber);
                    break;
                case "*":
                case "multiplication":
                    calc.Multiply(inOut.FirstNumber, inOut.SecondNumber);
                    break;
                case "/":
                case "division":
                    calc.Divide(inOut.FirstNumber, inOut.SecondNumber);
                    break;
            }
            Console.WriteLine("Result of {0} {1} {2} = {3}", inOut.FirstNumber, 
                inOut.StringOperation, inOut.SecondNumber, calc.Result);
            Console.ReadKey();
        }

    }
}
