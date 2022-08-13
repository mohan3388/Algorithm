using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblem
{
    public class MergeSort
    {
        public void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] Left = new int[n1];
            int[] Right = new int[n2];
            int i, j;
            for (i = 0; i < n1; i++)
            {
                Left[i] = arr[left + i];
            }
            for (j = 0; j < n2; j++)
            {
                Right[j] = arr[mid + 1 + j];
            }
            i = 0;

            j = 0;
            int k = left;
            while (i < n1 && j < n2)
            {
                if (Left[i] <= Right[j])
                {
                    arr[k] = Left[i];
                    i++;
                }
                else
                {
                    arr[k] = Right[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = Left[i];
                i++;
                k++;
            }
        }

        public void Sorting(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                Sorting(arr, left, mid);
                Sorting(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }
        public void DisplayMerge(int[] arr)
        {
            Console.WriteLine("Sorted Element is: ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
