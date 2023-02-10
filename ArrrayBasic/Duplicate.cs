using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrrayBasic
{
    internal class Duplicate
    {
        public void findDuplicate()
        {
            int[] arr = { 2,3,4,11,2,4 };
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=0;j<arr.Length;j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine("Duplicate Element found:" + arr[i]);
                            
                    }
                }
                Console.ReadLine();
                    
            }
            

                
        }
    }
}
