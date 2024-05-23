using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.App
{
    public class Mathoperations
    {
        public double Sum(double num1, double num2)
        {
            double sum = num1 + num2;
            return sum;
        }

        public double Multiplication(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }

        public double Division (double num1, double num2)
        {
            double result = 1;
            if (num2 != 0)
            {
               result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Can't divide by 0!");
            }
            return result;
        }

        public double Substraction (double num1, double num2) {
            double remain = num1 - num2;
            return remain;
        }
    }
}
