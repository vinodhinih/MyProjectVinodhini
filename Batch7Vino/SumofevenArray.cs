using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch7Vino
{
    internal class SumofevenArray
    {
        public static void Main(string[] args)
        {
            int number = 53424;
            int temp;
            int sum = 0;
            while (number > 0)
            {
                temp = number % 10;
                if (temp % 2 == 0)
                {
                    sum = sum + temp;
                }
                number = number / 10;
            }
            Console.WriteLine("sum of the even numbers are="+sum);
        }
    }
}
