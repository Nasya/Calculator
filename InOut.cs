using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class InOut
    {
        private static readonly string[] operations = { "+", "-", "*", "/" };
        double firstNumber;
        double secondNumber;

        private string stringOperation;

        public double FirstNumber
        {
            get => firstNumber;
            set => firstNumber = value;
        }
        public double SecondNumber
        {
            get => secondNumber;
            set => secondNumber = value;
        }
        public string StringOperation
        {
            get => stringOperation;
            set => stringOperation = value;
        }

        public void InputValue()
        {
            FirstNumber = SetNumber("Enter your first number : ");
            SecondNumber = SetNumber("Enter your second number: ");
            StringOperation =
               SetOperation(
                  "Enter the operation + (addition), - (soustraction), * (multiplication), " +
                  "/ (division):");
        }

        private static double SetNumber(string outputText)
        {
            double parse;
            Console.Write(outputText);
            string tempInput = Console.ReadLine();
            while (!double.TryParse(tempInput, out parse))
            {
                Console.WriteLine("Incorrect input !");
                Console.Write(outputText);
                tempInput = Console.ReadLine();
            }
            return double.Parse(tempInput);
        }

        private static bool IsValidOperation(string input)
        {
            return operations.Contains(input);
        }

        private static string SetOperation(string outputText)
        {
            Console.Write(outputText);
            string tempInput = Console.ReadLine();
            while (!IsValidOperation(tempInput))
            {
                Console.WriteLine("Incorrect input !");
                Console.Write(outputText);
                tempInput = Console.ReadLine();
            }
            return tempInput;
        }
    }
}


