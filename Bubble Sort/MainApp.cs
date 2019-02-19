using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Program
    {
        static void Main( string[] args )
        {
            int[] arg = { 3, 7, 5, 8, 9, 11, 4, 8 };
            Print();
            Console.WriteLine("\n");

            BubbleSort.AscendingSort(arg);
            Print();
            Console.WriteLine("\n");

            BubbleSort.DescendingSort(arg);
            Print();
            Console.WriteLine("\n");


            void Print()
            {
                foreach( int i in arg )
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
