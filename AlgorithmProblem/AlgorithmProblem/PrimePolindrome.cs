using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblem
{
    public class PrimePolindrome
    {
        public void PrimePalindromNumber()
        {
            int cnt = 0;
            Console.WriteLine("Enter The start Number: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The End Number: ");
            int end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Prime Palindrome Numbers are: ");
            for (int i = start; i <= end; i++)
            {
                int num = i, revNum = 0;
                while (num != 0)
                {
                    int digit = num % 10;
                    num /= 10;
                    revNum = revNum * 10 + digit;
                }
                if (revNum == i)
                {
                    bool isprime = true;
                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            isprime = false;
                            break;
                        }
                    }
                    if (isprime)
                    {
                        Console.Write(i + " ");
                        cnt++;
                        if (cnt == 10)
                        {
                            cnt = 0;
                        }
                    }
                }
            }
        }
    }
}
