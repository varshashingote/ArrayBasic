using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrrayBasic
{
    public class CopyElement
    {
        public  void CopyArray()
        {
            int[] Array1=new int[5];
            int[] Array2=new int[5];
            int i, n;
            Console.WriteLine("Enter the ArraySize");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Element do u want to insert",n);
            for(i=0;i<n;i++)
            {
                Console.WriteLine(" ",i);
               Array1 [i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                Array2[i] = Array1[i];
            }
            Console.WriteLine("display elements in first Array:");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("{0}", Array1[i]);
            }
            Console.WriteLine("display array element second array:");
            for(i=0;i<n;i++)
            {
                Console.WriteLine("{0}", Array2[i]);
            }
            Console.ReadLine();
 

        }
}
}
