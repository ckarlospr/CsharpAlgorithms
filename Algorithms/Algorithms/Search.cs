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

        public static Boolean binarySearch(int[] ints, int num, int start, int end)
        {
            int mid = (start+end)/2;
            Boolean result = false;
            if (ints[mid] == num)
            {
                result = true;
            }else if (ints[mid] < num)
            {
                binarySearch(ints, num, mid, end);
            }
            else if(ints[mid] > num)
            {
                binarySearch(ints, num, start, mid);
            }
            else
            {
                result = false;
            }
            return result;
        }
    }


}
