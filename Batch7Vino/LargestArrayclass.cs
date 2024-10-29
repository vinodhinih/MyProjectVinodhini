using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch7Vino
{
    internal class LargestArrayclass
    {
        static void Main(string[] args)
        {
            int largest1 = 0, largest2 = int.MaxValue,largest3=int.MaxValue;
            int[] arrayLarge = new int[10];
            Console.Write("Enter the elements:");
            for (int i = 0; i < arrayLarge.Length; i++)
            {
                arrayLarge[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arrayLarge.Length; i++)
            {
                Console.Write(arrayLarge[i]);
            }
            largest1 = arrayLarge[0];
            for (int i = 0; i < arrayLarge.Length-1; i++)
            {
                if (largest1 < arrayLarge[i])
                {
                    largest3 = largest2;
                    largest2 = largest1;
                    largest1 = arrayLarge[i];
                }
                else if (arrayLarge[i] > largest2)
                {
                    largest3 = largest2;
                    largest2 = arrayLarge[i];
                }
                else if (arrayLarge[i] > largest3)
                {
                    largest3 = arrayLarge[i];
                }  
            }
            Console.WriteLine("First largest=" + largest1);
            Console.WriteLine("Second largest=" + largest2);
            Console.WriteLine("Third largest=" + largest3);
        }
    }
}
