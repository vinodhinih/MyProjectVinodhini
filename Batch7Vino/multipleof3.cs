using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch7Vino
{
    internal class multipleof3
    {
        public static void Main(string[] args)
        {
            int[] input = {21,4,23,6,4,9};
            int output=0;
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] % 3 == 0) 
                {
                    output = input[i];
                }
                

            }
            Console.Write(output);

        }
    }
}
