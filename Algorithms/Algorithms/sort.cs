using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class sort
    {
        
        //Buble sort 
        public void bubbleSort(int[] data)
        {
            Boolean sorted = false;
            int cnt = data.Length;

            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < cnt - 1; i++)
                {
                    if (data[i] > data[i + 1])
                    {
                        int d = data[i];
                        data[i] = data[i + 1];
                        data[i + 1] = d;
                        sorted = false;
                    }
                }
                cnt--;
            }
        }
        

    }
}
