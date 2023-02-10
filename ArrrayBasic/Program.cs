using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrrayBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Choice:1.LegthofArray\n2.AvgArray\n3.ReverseArray" +
                "\n4.SumOFArray\n5.CopyElement\n6.DuplicateElement\n7.Duplicate\n8.OddpositionArray\n9.EvenPositionArray");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    LengthOfArray lengthOfArray = new LengthOfArray();
                    lengthOfArray.FindLength();
                    break;
                case 2:
                    AvgArray avgArray = new AvgArray();
                    avgArray.ArrayPrint();
                    break;
                case 3:
                    ReverseArray reverseArray = new ReverseArray();
                    reverseArray.FindReverseArray();
                    break;
                case 4:
                    SumOFArray sumOFArray = new SumOFArray();
                    sumOFArray.findSumOFArray();
                    break;
                case 5:
                    CopyElement copyElement = new CopyElement();
                    copyElement.CopyArray();
                    break;
                case 6:
                    DuplicateArrayElement duplicateArray = new DuplicateArrayElement();
                    duplicateArray.FindSmallestLargest();
                    break;
                case 7:
                    Duplicate duplicate = new Duplicate();
                    duplicate.findDuplicate();
                    break;
                case 8:
                    OddPositionArrayElement oddPositionArrayElement = new OddPositionArrayElement();
                    oddPositionArrayElement.FindOddPositionArrayElement();
                    break;
                case 9:
                    EvenPositionArray evenPositionArray = new EvenPositionArray();
                    evenPositionArray.FindEven();
                    break;



            }
        }
    }
}