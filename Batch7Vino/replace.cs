using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch7Vino
{
    internal class replace
    {
        public static void Main(string[] args)
        {


            int[] array = { 2, 5, 4, 3, 7, 8, 9, 6, 1 };
            int[] array1 = [array.Length];
            for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
            {

                if (i < j)
                {
                    int tem = array[i];
                    array[i] = array[j];
                    array[j] = tem;
                }
            }
            Console.WriteLine("replaced array");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

        }
    }
}
