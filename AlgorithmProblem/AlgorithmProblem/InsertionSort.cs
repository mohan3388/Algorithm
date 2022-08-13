using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblem
{
    public class InsertionSort
    {
        public void Insertion(String[] arr)
        {
            Console.Write("unsored array: ");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                string temp = arr[i];
                int j = i - 1;
                while (j >= 0 && temp.Length < arr[j].Length)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
        }
        public void Display(String[] arr)
        {
            Console.WriteLine("Sorted Element is: ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
