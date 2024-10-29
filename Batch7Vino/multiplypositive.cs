using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch7Vino
{
    internal class multiplypositive
    {
        public static void main(string[] args)
        {
            int[] array = { 2, 1, 0, -1, -6, 34 };
            int multiply = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0 )
                {
                    multiply = multiply * array[i];
                }
            }
            Console.WriteLine("Multiplication of an array" + multiply);
        }
    }
}
