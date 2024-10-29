using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch7Vino
{
    internal class Searchelement
    {
        public static void Main(string[] args)
        {
            int[] input = {2,1,4,5,8,2,6,9};
            Console.WriteLine("Enter the elemnet to search:");
            int s = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == s)
                {
                    Console.WriteLine("The location of the element"+" "+s+"="+i);
                }
            }
        }
    }
}
