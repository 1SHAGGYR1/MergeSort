using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testarr = new int[9];
            for (int i = 0; i < 9; i++)
                testarr[i] = int.Parse(Console.ReadLine());
            MergeSortRec(testarr, 0, 8);
            for (int i = 0; i < testarr.Length; i++)
                Console.Write(testarr[i] + " ");
            Console.ReadKey(true);
        }
        static void Merge (int[] arr, int left, int mid, int right)
        {
            int lh = 0, rh = 0;
            int[] result = new int[right - left + 1];
            while ((left + lh <= mid)&&(mid + rh + 1<= right))
            {
                if (arr[left + lh] <= arr[mid + rh + 1])
                {
                    result[lh + rh] = arr[left + lh];
                    lh++;
                }
                else
                {
                    result[lh + rh] = arr[mid + rh + 1];
                    rh++;
                }
            }
            while (left + lh <= mid)
            {
                result[lh + rh] = arr[left + lh];
                lh++;
            }
            while (mid + rh + 1 <= right)
            {
                result[lh + rh] = arr[mid + rh + 1];
                rh++;
            }
            for (int i = 0; i < result.Length; i++)
                arr[left + i] = result[i];
            return;
        }
        static void MergeSortRec (int [] arr, int left, int right)
        {
            if (left == right)
                return;
            else
            {
                int mid = (right + left) / 2;
                MergeSortRec(arr, left, mid);
                MergeSortRec(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }
    }
}
