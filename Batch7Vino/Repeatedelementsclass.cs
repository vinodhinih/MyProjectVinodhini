using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch7Vino
{
    internal class Repeatedelementsclass
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int count = 1;
            Console.WriteLine("Enter array elements");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                count = 1;
                for (int j = i + 1; j < array.Length; j++)
                {


                    if (array[i] == array[j])
                    {
                        count++;
                    }
                }
                if (count > 1)
                    Console.WriteLine($"{array[i]}-{count}times repeated");
            }
            Console.Write("Enter the element to search:");
            int s = Convert.ToInt32(Console.ReadLine());
            int b=Array.BinarySearch(array,s);
            if (s>b)
            {
                Console.WriteLine("Element is found");
            }
            else {
                Console.WriteLine("Element is not found");
            }

        }
    }
}

    

