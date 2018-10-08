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
            // lægger 2  tal sammen.
             return v1 + v2;           
        }

        public static double Subtract(double v1, double v2)
        {
            return v1 - v2;
        }

        public static double Multiply(double v1, double v2)
        {
            // ganger 2  tal 
            return v1 * v2;
        }

        public static double Divide(double v1, double v2)
        {   // dividerer v1 med v2
            return v1 / v2;
        }

        public static double Sum(double[] numbers)
        {
            double res = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                // resultat 
                res = res + numbers[i];  

            }
            return res;
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
            double res = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if(res < numbers[i])
                {
                    res = numbers[i];
                }
            }
            return res;
        }

        public static double Average(double[] numbers)
        {
            return Divide(Sum(numbers), numbers.Length);  
        }

        //public static double Expression(string v)
        //{
        //    v = v.Replace(',', '.');
        //    v = v.Replace(" ", string.Empty);
        //    string numberString = string.Empty;
        //    double numberOne = 0;
        //    double numberTwo = 0;
        //    double result = 0;
        //    string mathSymbol = string.Empty;


        //    for (int i = 0; i < v.Length; i++)
        //    {
        //        if (char.IsNumber(v[i]))
        //        {
        //            while (v[i] != ' ' ||
        //                   v[i] != '+' ||
        //                   v[i] != '-')
        //            {
        //                numberString += v[i];
        //                i++;
        //            }
        //            double.TryParse(numberString, out numberOne);
        //        }
        //        else if (v[i] == '+')
        //        {
        //            mathSymbol = "add";
        //        }
        //        else if (v[i] == '-')
        //        {
        //            mathSymbol = "subtract";
        //        }
        //        if (char.IsNumber(v[i]))
        //        {
        //            while (v[i] != ' ' ||
        //                   v[i] != '+' ||
        //                   v[i] != '-')
        //            {
        //                numberString += v[i];
        //                i++;
        //            }
        //            double.TryParse(numberString, out numberTwo);
        //        }

        //        if (mathSymbol == "add")
        //        {
        //            result += Add(numberOne, numberTwo);
        //        }
        //        else if (mathSymbol == "subtract")
        //        {
        //            result += Subtract(numberOne, numberTwo);
        //        }
        //    }
            
        //    return result;
        //}
    }
}
