using System;
using System.Linq;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            CountBits(1234);
        }

        public static int CountBits(int n)
        {
            string binary = Convert.ToString(n, 2);

            int[] bits = binary.Select(o => Convert.ToInt32(o) - 48).ToArray();
            int counter = 0;

            foreach (var item in bits)
            {
                if (item == 1)
                {
                    counter++;
                }
            }


            return counter;
        }

        public static int CountBits_Kata(int n)
        {
            return Convert.ToString(n, 2).Count(x => x == '1');
        }
    }
}
