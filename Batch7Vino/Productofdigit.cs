using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch7Vino
{
    internal class Productofdigit
    {
        public static void main(string[] args)
        {
            int number = 2354;
            int product = 1;
            int temp;
            int output=0;
            while (number > 0)
            {
                temp = number % 10;
                product = product * temp;
                number = number / 10;
            }
            Console.WriteLine("product of the given number:" + product);
            
            if (product % 3 == 0 || product % 5 == 0)
            {
                output = 1;
                Console.Write(output);
            }
            else 
            {
                Console.WriteLine("The product of the number is not divisible by 3 or 5");
            }

        }
    }
}
