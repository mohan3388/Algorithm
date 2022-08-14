using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblem
{
    public class GuessGame
    {
        public int Find()
        {
            int low = 0, high = 127, mid;
            while (low != high)
            {
                mid = (low + high) / 2;
                Console.WriteLine("enter 1 if no is between" + low + "-" + mid + "\n Enter 2 if no is between" + (mid + 1) + "-" + high);
                int c = Convert.ToInt32(Console.ReadLine());
                mid = (low + high) / 2;
                if (c == 1)
                {
                    high = mid;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return low;
        }
    }
}
