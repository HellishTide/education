using System;

namespace binary_search
{
    public class BinSearch
    {
        public string search(int[] array_of_number, int find)
        {
            int low = 0;
            int high = array_of_number.Length - 1;            

            while (low <= high)
            {
                int mid = (low + high) / 2;

                int guess = array_of_number[mid];

                if (guess == find)
                    return String.Format("{0}", mid);
                else
                    if (guess > find)
                        high--;
                    else
                        low++;

            }

            return String.Format("None");
        }

        static void Main(string[] args)
        {
            int[] ar = { 0, 1, 2, 3, 5, 6, 7, 8, 9 };
            int num = 5;

            BinSearch bc = new BinSearch();
            string res = bc.search(ar, num);
            Console.WriteLine("Find {0} on pos {1}", num, res);
        }
    }
}
