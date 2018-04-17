using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculation
    {
        double result;

        public double Result { get => result; }

        public void Add(double displayValue, double currentValue)
        {
            result = currentValue + displayValue;
        }

        public void Subtract(double displayValue, double currentValue)
        {
            result = currentValue - displayValue;
        }

        public void Multiply(double displayValue, double currentValue)
        {
            result = currentValue * displayValue;
        }

        public void Divide(double displayValue, double currentValue)
        {
            result = currentValue / displayValue;
        }
    }
}
