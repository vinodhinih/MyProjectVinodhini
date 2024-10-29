using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch7Vino
{
    internal class RepeatedArray
    {
        public static void Main(string[] args)
        {
            
            
            int[] array = {2,8,3,2,2,3,8,8};
            int[] output=new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    int count = 1;
                    if (array[i] == array[j] && array[i]!=int.MaxValue)
                   
                    {
                        count++;
                        if(count>1)
                        {
                            output[i] = array[j];
                            
                        }

                        array[j] = int.MaxValue;
                    }
                    
                }
                
            }
            
            Console.WriteLine("Repeated elements");
            for (int i = 0; i < output.Length; i++)
            {
                if (output[i] >1)
                
                    Console.Write(output[i]+" ");
                
            }
        }
    }
}
