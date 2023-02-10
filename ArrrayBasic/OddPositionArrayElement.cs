using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrrayBasic
{
    internal class OddPositionArrayElement
    {
        public void FindOddPositionArrayElement()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter the element in array:");
             for ( int i = 0; i < 10; i++)
            {
                Console.WriteLine(" ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Display Array element");


            for (int i=0;i<10; i=i+2)
            {
                Console.WriteLine("{0} ",arr[i]);
            }
            Console.ReadLine();

        }
    }
}
