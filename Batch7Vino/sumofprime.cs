using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch7Vino
{
    internal class sumofprime
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size :");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] input1 = { 1, 2, 3, 4, 5 };
            int output = 0;
            int sum = 0;

            if (size < 0)
            {
                output = -2;
            }
            else
            {
                for (int i = 0; i < input1.Length; i++)
                {
                    if (input1[i] < 0)
                    {
                        output = -1;
                        break;
                    }

                    else if (IsPrime(input1[i]))
                    {
                        sum += input1[i];
                    }
                    else
                    {
                        output = -3;
                    }
                }
            }
            Console.WriteLine($"Sum of prime numbers: {sum}");

        }


        public static bool IsPrime(int n)
        {
            if (n == 0 || n == 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        
    }
}
