using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Batch7Vino
{
    class ArrayAscendDesec
    {
        public static void Main(string[] args)
        {
            int[] arr1 = {2,5,7,4,8,1};
            int[] arr2 = {3,6,1,8,3,9};
            int[] arr3 = new int[6];
            Array.Sort(arr1);
            Array.Sort(arr2);
            Array.Reverse(arr2);
            for(int i=0,j= arr2.Length-1;i < arr1.Length; i++,j--)
            {
                arr3[i] = arr1[i] * arr2[j];
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]); 
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine(arr3[i]);
            }
        }

    }
}
