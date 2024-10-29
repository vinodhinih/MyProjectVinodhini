using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch7Vino
{
    internal class Switchcase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the student no 1 to 5");
            int student_no = int.Parse(Console.ReadLine());
            switch (student_no)
            {
                case 1:
                    {
                        Console.WriteLine("student 1=vino");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("student 2=vinoth");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("student 3=jai");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("student 4=haribabu");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("student 5=viji");
                        break;
                    }
            }
        }
    }
}
