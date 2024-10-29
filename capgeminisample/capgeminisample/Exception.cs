using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace capgeminisample
{
    class Operation
    {
       public double Num1 {  get; set; }
        public double Num2 { get; set; }
        public char Opr { get; set; }
        public Operation(double num1, double num2, char opr)
        {
            Num1 = num1;
            Num2 = num2;
            Opr = opr;
        }
    }
    class Sources
    {
       
        public static string ExceptionHandle(Operation o)
        {
            try
            {
                if (o.Opr!='+' && o.Opr != '-' && o.Opr != '*' && o.Opr != '/')
                {
                    throw new InvalidOperationException("Invalid operator.Use +,-,*,/");
                }
                if (o.Num2 == 0 && o.Opr == '/')
                {
                    throw new InvalidOperationException("Divisible by zero exception");
                }
                return "No Exception";
            }
            catch (InvalidOperationException ex)
            {
                return ex.Message;
            }
            catch(DivideByZeroException ex)
            {
                return ex.Message;
            }
        }
        public string Calculator(Operation o)
        {
            if (o.Num2 == 0 && o.Opr == '/')
            {
                return "Divide By Zero Exception";
            }
            double result = 0;
            switch (o.Opr)
            {
                case '+':
                    {
                        result = o.Num1 + o.Num2;
                        break;
                    }
                case '-':
                    {
                        result = o.Num1 - o.Num2;
                        break;
                    }
                case '*':
                    {
                        result = o.Num1 * o.Num2;
                        break;
                    }
                case '/':
                    {
                        result = o.Num1 / o.Num2;
                        break;
                    }
                default:
                    {
                      throw new InvalidOperationException("Invalid operator");
                    }
            }
            return $"{result}";
        }
    }
}
