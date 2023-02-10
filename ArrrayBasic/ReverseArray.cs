using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrrayBasic
{
   public  class ReverseArray
    { 
        public void FindReverseArray()
        {
            int[] arr = new int[10];
            //declare and intitialization array
            Console.WriteLine("Enter Element in the array");
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(" ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Display Array element");

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}", arr[i]);
            }
            Console.WriteLine("Revser Array is");
            for(i=10-1; i>=0;i--)
            {
                Console.WriteLine("{0}", arr[i]);
            }
            Console.ReadLine();
        }
    }
}
