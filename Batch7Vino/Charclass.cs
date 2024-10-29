using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch7Vino
{
    internal class Charclass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string name = Console.ReadLine();
            char[]charArray =name.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                Console.Write(charArray[i]+" ");
            }
        }
    }
}
