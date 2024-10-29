using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch7Vino
{
    internal class PatternProgram
    {
        public static void Main(string[] args)
        {
            int number = 5;
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
