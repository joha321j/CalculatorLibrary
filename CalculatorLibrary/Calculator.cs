using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculator
    {
        public static double Add(double v1, double v2)
        {
            throw new NotImplementedException();
        }

        public static double Subtract(double v1, double v2)
        {
            return v1 - v2;
        }

        public static double Multiply(double v1, double v2)
        {
            throw new NotImplementedException();
        }

        public static double Divide(double v1, double v2)
        {
            return v1 / v2;
        }

        public static double Sum(double[] numbers)
        {
            throw new NotImplementedException();
        }

        public static double Minimum(double[] numbers)
        {
            double minimum = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i]<minimum)
                {
                    minimum = numbers[i];
                }
            }
            return minimum;
        }

        public static double Maximum(double[] numbers)
        {
            throw new NotImplementedException();
        }

        public static double Average(double[] numbers)
        {
            
        }
    }
}
