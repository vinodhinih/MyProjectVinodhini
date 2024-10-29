using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch7Vino
{
    internal class Numberclass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number :");
            int number=Convert.ToInt32(Console.ReadLine());
            if (number >= 0 && number < 9)
            {
                Console.WriteLine("The number you pressed = "+number);
            }
            else {
                Console.WriteLine("Not allowed");
            }
        }
    }
}
