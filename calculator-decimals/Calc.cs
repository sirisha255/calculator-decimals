using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace calculator_decimals
{
    public class calc
    {
        private double num1;
        private double num2;
        private double total;
        public double Total
        {
            get
            {
                return total;
            }
        }
        public double Num1
        {
            get
            {
                return num1;
            }
            set
            {
                num1 = value;
            }
        }
        public double Num2
        {
            get
            {
                return num2;
            }
            set
            {
                num2 = value;
            }
        }

        public static double Addition(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double subtraction(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double Multiplication(double num1, double num2)
        {
            return num1 * num2;

        }
        public static double division(double num1, double num2)
        {
            if (num2 == 0)
            throw new ArgumentException("Cannot divide by zero!");
            return num1 / num2;

        }

        public static double Addition(double[] arr)
        {    
    
            throw new NotImplementedException();
        }

        public static double subtraction(double[] arr)
        {
            throw new NotImplementedException();
        }
    }
}
