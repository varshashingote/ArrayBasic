using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrrayBasic
{
    internal class SumOFArray
    {
        public void findSumOFArray()
        {
            int[] arr = new int[10];
            //declare and intitialization array
            Console.WriteLine("Enter Element in the array");
            int i;
            int Sum=0;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(" ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i=0;i<10;i++)
            {
                Sum+= arr[i];
            }
            Console.WriteLine("Sum of array element {0}", Sum);

            Console.ReadLine();

            
        }
    }
}
