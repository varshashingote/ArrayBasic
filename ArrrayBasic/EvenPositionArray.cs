using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrrayBasic
{
    internal class EvenPositionArray
    {
        public void FindEven()
        {


            int[] arr = new int[4];
            int i;
            Console.WriteLine("Enter Array element");
            for(i=0;i<4;i++)
            {
                Console.WriteLine(" ",i);
               arr[i]= Convert.ToInt32(Console.ReadLine());

            }
         
            for(i=1;i<4;i=i++)
            {
                Console.WriteLine("{0} ", arr[i]);
            }
            Console.ReadLine();
        }
    }
}
