using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch7Vino
{
    internal class GreatestNumberclass
    {
        public static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            Console.WriteLine("Enter the value of num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of num3");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine(num1 + ":is greatest number");
            }
            else if (num2 > num3)
            {
                Console.WriteLine(num2 + ":is greatest number");
            }
            else {
                Console.WriteLine(num3 + ":is greatest number");
            }
        }
    }
}
