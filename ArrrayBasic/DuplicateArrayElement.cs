using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArrrayBasic
{
    internal class DuplicateArrayElement
    {
        public void FindSmallestLargest()
        {
            int[] arr1 = { 2, 3, 4, 11, 2, 4 };
            int maxno = arr1[0];
            int minno = arr1[0];
            for (int i = 0; i < arr1.Length; i++)
            {
           
                    if (maxno < arr1[i])
                    {
                        maxno = arr1[i];
                        
                    }
                else if(minno > arr1[i])
                    {
                    minno = arr1[i];
                    }

                }
            Console.WriteLine("LargestNumber"+maxno);
            Console.WriteLine("SmallestNumber"+minno);
            Console.ReadLine();
            }
        }
    }

    



    

       
            


          
             

    







