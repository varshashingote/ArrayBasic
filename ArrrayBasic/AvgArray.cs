using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrrayBasic
{
    internal class AvgArray
    {
        public void ArrayPrint()
        {
            int[] arr = new int[10];
            //declare and intitialization array
            Console.WriteLine("Enter Element in the array");
            int i;
            int sum = 0;
            float avg = 0.0f;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(" ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
           

            for (i = 0; i < 10; i++)
            {
                sum += arr[i];
            }
            avg = (float)sum / 10;
            Console.WriteLine("Array of avg{0}",avg);
            Console.ReadLine();

        }
    }
}



       

