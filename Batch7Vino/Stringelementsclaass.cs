using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch7Vino
{
    internal class Stringelementsclaass
    {
        static void Main(string[] args)
        {
            string[] element = new string[10];
            int count = 0;
            Console.Write("Enter the string array :");
            for (int i = 0; i < element.Length; i++)
            {
                element[i] = Console.ReadLine();
            }
            Console.WriteLine("The elements in string array ");
            for(int i=0;i<10;i++)
            {
                Console.Write(element[i]+" ");
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                count = 0;
                for (int j = 1; j < 10; j++)
                {
                    if (element[i] == element[j])
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    Console.WriteLine($"{element[i]}-{count}times repeated");
                }

            }
            
        }
    }
}
