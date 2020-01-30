namespace Sorting
{
    public class Sort
    {
        public int[] QuickSort(int[] arr)
        {
            if (arr.Length < 2)
                return arr;
            else
                return QuickSort(arr, 0, arr.Length - 1);

        }

        public int[] QuickSort(int[] arr, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
                return arr;

            int pivot = Partition(arr, minIndex, maxIndex);
            QuickSort(arr, minIndex, pivot - 1);
            QuickSort(arr, pivot + 1, maxIndex);

            return arr;
        }

        public int Partition(int[] arr, int minIndex, int maxIndex)
        {
            int pivot = minIndex;
            for (int i = minIndex; i < maxIndex; ++i)
            {
                if (arr[i] < arr[maxIndex])
                {
                    Swap(ref arr[pivot], ref arr[i]);
                    pivot++;
                }
            }
            Swap(ref arr[pivot], ref arr[maxIndex]);

            return pivot;
        }

        public int[] SelectionSort(int[] arr, int index = 0)
        {
            int arrLength = arr.Length;

            if (index == arrLength)
                return arr;

            int minIndex = FindMinIndex(arr, index);
            if (index != minIndex)
                Swap(ref arr[index], ref arr[minIndex]);

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

        public void Swap(ref int notMinElement, ref int minElement)
        {
            int tempVar = notMinElement;
            notMinElement = minElement;
            minElement = tempVar;
        }
    }
}
