using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch7Vino
{
    internal class AsciiValueclass
    {
        public static void Main(string[] args)
        {
            int i = 1;
            for (i = 1; i < 122; i++)
            {
                Console.WriteLine(i+"=Ascii value :"+(char)i); 
            }
        }
    }
}
