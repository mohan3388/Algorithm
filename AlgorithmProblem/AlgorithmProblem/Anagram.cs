using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblem
{
    public class Anagram
    {
        public void AnagramProblem(string Firstlength, string SecondLength)
        {
            var val1 = Firstlength.ToLower().ToArray();
            var val2 = SecondLength.ToLower().ToArray();
            Array.Sort(val1);
            Array.Sort(val2);
            if(new string(val1) == new string(val2))
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not Anagram");
            }
        }
    }
}
