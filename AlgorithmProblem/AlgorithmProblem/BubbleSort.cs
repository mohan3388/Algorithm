using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblem
{
    public class BubbleSort
    {
        public void Bubble(int[] arr)
        {
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }
        public void Display(int[] arr)
        {
            Console.WriteLine("Sorted Element is: ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
