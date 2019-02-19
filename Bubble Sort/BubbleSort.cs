using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class BubbleSort
    {
        public static void AscendingSort( int[] arg)
        {
            int repeat = arg.Length;

            for( int i = 0; i < arg.Length - 1; i++ )
            {
                for( int j = 0; j < repeat - 1; j++ )
                {
                    if( arg[j] > arg[j + 1] )
                    {
                        Swap(ref arg[j], ref arg[j + 1]);
                    }
                }
                --repeat;
            }
        }

        public static void DescendingSort( int[] arg )
        {
            int repeat = arg.Length;

            for( int i = 0; i < arg.Length - 1; i++ )
            {
                for( int j = 0; j < repeat - 1; j++ )
                {
                    if( arg[j] < arg[j + 1] )
                    {
                        Swap(ref arg[j], ref arg[j + 1]);
                    }
                }
                --repeat;
            }
        }


        static void Swap( ref int a, ref int b )
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
