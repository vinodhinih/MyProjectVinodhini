using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch7Vino
{
    internal class Patternclass
    {
        public static void Main(string[] args)
        {
            int number = 6;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if(i+j>=number-1)
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

    }
}
