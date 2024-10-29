using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch7Vino
{
    internal class CompareArray
    {
        public static void Main(string[] args)
        {
            int[] input1 = { 2, 34, 12, 78, 54, 90 };
            int[] input2 = { 3, 56, 98, 24, 17,78 };
            int[] greatest=new int[6];
            for (int i = 0; i < input1.Length; i++)
            {
                for (int j = 0; j < input2.Length; j++)
                {
                    if (input1[i] < input2[j])
                    {
                        greatest[i] = input2[i];
                    }
                    else
                    {
                        greatest[i] = input1[i];
                    }
                }
            }
            for (int i = 0; i < input1.Length; i++)
            {
                Console.WriteLine(greatest[i]+" ");
            }
        }
    }
}
