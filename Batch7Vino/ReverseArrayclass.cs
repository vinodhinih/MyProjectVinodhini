using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch7Vino
{
    internal class ReverseArrayclass
    {
        public static void Main(string[]args)
        {
            int[] arrA = new int[10] { 2, 5, 3, 4, 7, 6, 5, 8, 45, 90 };
            int[] arrB = new int[8] { 34,67,54,89,90,78,80,89};
            Console.WriteLine("Elements in arrA" + " ");
            foreach (int i in arrA)
            {
                Console.WriteLine(i+" ");
            }
            Console.WriteLine("Elements in arrB"+" ");
            foreach (int i in arrB)
            {
                Console.Write(i + " ");
            }
            Array.Copy(arrA, 0, arrB, 0, 3);
            Console.WriteLine("Elements of array in arrB after copying");
            foreach (int i in arrB)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("Elements of reversed array arrA");
            Array.Reverse(arrB);
            foreach (int i in arrA)
            {
                Console.WriteLine(i + " ");
            }

        }
    }
}
