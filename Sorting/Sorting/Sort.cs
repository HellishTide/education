using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public class Sort
    {
        public int[] SelectionSort(int[] arr, int index = 0)
        {
            int arrLength = arr.Length;

            if (index == arrLength)
                return arr;

            int minIndex = FindMinIndex(arr, index);
            if (index != minIndex)
                SwapIndex(ref arr[index], ref arr[minIndex]);

            return SelectionSort(arr, ++index);
        }

        public int FindMinIndex(int[] arr, int index)
        {
            int minIndex = index;
            int min = arr[index];

            if (index == arr.Length)
                return minIndex;

            for (int i = index; i < arr.Length; ++i)
            {
                int element = arr[i];

                if (min > element)
                    minIndex = i;
            }

            return minIndex;
        }

        public void SwapIndex(ref int notMinElement, ref int minElement)
        {
            int tempVar = notMinElement;
            notMinElement = minElement;
            minElement = tempVar;
        }
    }
}
