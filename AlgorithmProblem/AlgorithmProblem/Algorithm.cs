using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblem
{
    public class Algorithm
    {
        public int BinarySearch(String[] arr, String x)

        {
            int l = 0, r = arr.Length;
            while (l <= r)
            {
                int m = l + (r - l) / 2;
                int res = x.CompareTo(arr[m]);
                if (res == 0)
                {
                    return m;
                }
                if (res > 0)
                {
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }
            }
            return -1;
        }
    }
}
