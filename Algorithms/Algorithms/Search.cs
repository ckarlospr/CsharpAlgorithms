using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class Search
    {

        public static int binarySearch(int[] ints, int n)
        {
            int start, end, mid, r = -1;
            start = 0;
            end = ints.Length;

            while (start<end)
            {
                mid = (start + end)/2;
                if (ints[mid] == n)
                {
                    r = mid;
                    break;
                }else if (n > ints[mid])
                {
                    start = mid;
                }
                else
                {
                    end = mid;
                }
            }

            return r;
        }
    }


}
