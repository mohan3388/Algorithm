using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblem
{
    public class PrimeNumber
    {

        public void CheckPrime()
        {
            int i, j, count;
            for (i = 1; i <= 1000; i++)
            {
                count = 0;
                for (j = 1; j <= i; j++)
                {

                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
