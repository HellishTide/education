using System;

namespace Sorting
{
    class Program
    {
        static void Main()
        {
            Sort sort = new Sort();
            int[] array = { 3, 5, 2, 10, 7 };
            sort.SelectionSort(array);
            for (int i = 0; i < array.Length; ++i)
                Console.Write(array[i]);
        }
    }
}
