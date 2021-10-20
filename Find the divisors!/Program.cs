using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_the_divisors_
{
    class Program
    {
        static void Main(string[] args)
        {
            Divisors(12);
        }

        /*
         * Create a function named divisors/Divisors that takes an integer n > 1 and returns an array with all of the integer's 
         * divisors(except for 1 and the number itself), from smallest to largest. 
         * If the number is prime return the string '(integer) is prime' (null in C#) 
         * (use Either String a in Haskell and Result<Vec<u32>, String> in Rust).
         */

        public static int[] Divisors(int n)
        {
            List<int> divizori = new List<int>();


            for (int i = 2; i <= n/2; i++)
            {
                if (n%i==0)
                {
                    divizori.Add(i);
                }
            }

            if (!(divizori[0]==null))
            {
                Console.WriteLine("pula pula");
            }

            if (divizori.Count==0)
            {
                return null;
            }
            
            return divizori.ToArray();
        }
    }
}
