using System;
using System.Collections.Concurrent;
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

        public void QuickSort(int[] arr, int start, int end)
        {
            if (start >= end) return;
            int index = start;

            index = partition(arr, start, end);
            QuickSort(arr, start, index-1);
            QuickSort(arr, index+1, end);
        }

        public int partition(int[] arr, int start, int end)
        {
            int pivotIndex = start;
            int pivotValue = arr[end];

            for (int i = start; i < end; i++)
            {
                if (arr[i] < pivotValue)
                {
                    swap(arr, i, pivotIndex);
                    pivotIndex++;
                }
            }
            swap(arr, pivotIndex, end);

            return pivotIndex;
        }

        public void swap(int[] arr, int pos1, int pos2)
        {
            int temp = arr[pos1];
            arr[pos1] = arr[pos2];
            arr[pos2] = temp;
        }

        public void insertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                int temp = arr[i];

                while (j >= 0 && arr[j] > temp)
                {
                    arr[j+1] = arr[j];
                    arr[j] = temp;
                    j--;
                }
            }
        }
    }
}
