using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch7Vino
{
    internal class Sumofcubeclass
    {
        static void Main(string[] args)
        {
            int number = 567;
            Console.WriteLine("The number is:"+number);
            int sum = 0;
            int rem = 0;
            int cube = 1;
            while (number > 0)
            {
                rem = number % 10;
                //rem = rem+number;
                cube = rem * rem * rem;
                number = number / 10;
                sum = sum + cube;
            }
            Console.WriteLine("sum of the cube are="+sum);
           
        }
    }
}
